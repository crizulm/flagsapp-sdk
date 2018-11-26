using EvaluateSdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SdkInterface
{
    public partial class Form1 : Form
    {

        EvaluateSdk.EvaluateFlag sdk = new EvaluateSdk.EvaluateFlag();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void evaluateButton_Click(object sender, EventArgs e)
        {
            bool result = sdk.Evaluate(tokenTextBox.Text, userIdTextBox.Text);
            MessageBox.Show("Result: " + result,
                            "Evaluate",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
