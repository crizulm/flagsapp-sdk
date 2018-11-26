using System.Net;
using System.IO;
using System;
using System.Net.Cache;
using System.Threading;

namespace EvaluateSdk
{
    public class EvaluateFlag
    {
        public string Url { get; set; }
        private static readonly string DEFAULT_URL = "http://flagsapp-ort.herokuapp.com";
        private HttpRequestCachePolicy policy;
        private bool resultOfRequest;
        private static object locker = new object();

        public EvaluateFlag(string url)
        {
            this.Url = url;
            this.policy = new HttpRequestCachePolicy(HttpCacheAgeControl.MaxAge,
                TimeSpan.FromMinutes(2));
            resultOfRequest = false;
        }

        public EvaluateFlag()
        {
            this.Url = DEFAULT_URL;
            this.policy = new HttpRequestCachePolicy(HttpCacheAgeControl.MaxAge,
                TimeSpan.FromMinutes(2));
            resultOfRequest = false;
        }

        public bool Evaluate(string flagToken, string userId)
        {
            Thread t = new Thread(() => RunEvaluate(flagToken, userId));
            t.Start();
            bool result = false;
            if (!t.Join(TimeSpan.FromMilliseconds(1000)))
            {
                t.Abort();
                result = false;
            }
            else
            {
                lock (locker)
                {
                    result = resultOfRequest;
                }
            }
            return result;
        }

        public void RunEvaluate(string flagToken, string userId)
        {
            bool returnValue = false;
            string requestUrl = this.Url + "/flags/" + flagToken + "/evaluate";
            try
            {
                string result = DoRequest(requestUrl, userId).Split(':')[1];
                string value = result.Remove(result.Length - 1);
                if (value == "true")
                {
                    returnValue = true;
                }
            }
            catch (Exception)
            {
                returnValue = false;
            }

            lock (locker)
            {
                resultOfRequest = returnValue;
            }
        }

        private string DoRequest(string requestUrl, string userId)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUrl);
            request.Headers["client_id"] = userId;
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            request.CachePolicy = policy;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}

