namespace SdkInterface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.capacityLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.evaluateButton = new System.Windows.Forms.Button();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityLabel.Location = new System.Drawing.Point(52, 149);
            this.capacityLabel.Margin = new System.Windows.Forms.Padding(6);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(90, 29);
            this.capacityLabel.TabIndex = 8;
            this.capacityLabel.Text = "User id";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(52, 102);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(126, 29);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Flag token";
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenTextBox.Location = new System.Drawing.Point(324, 102);
            this.tokenTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.Size = new System.Drawing.Size(414, 35);
            this.tokenTextBox.TabIndex = 6;
            // 
            // evaluateButton
            // 
            this.evaluateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluateButton.Location = new System.Drawing.Point(324, 223);
            this.evaluateButton.Margin = new System.Windows.Forms.Padding(6);
            this.evaluateButton.Name = "evaluateButton";
            this.evaluateButton.Size = new System.Drawing.Size(162, 56);
            this.evaluateButton.TabIndex = 7;
            this.evaluateButton.Text = "Evaluate";
            this.evaluateButton.UseVisualStyleBackColor = true;
            this.evaluateButton.Click += new System.EventHandler(this.evaluateButton_Click);
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdTextBox.Location = new System.Drawing.Point(324, 149);
            this.userIdTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(414, 35);
            this.userIdTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 391);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.tokenTextBox);
            this.Controls.Add(this.evaluateButton);
            this.Controls.Add(this.userIdTextBox);
            this.Name = "Form1";
            this.Text = "Evaluate Flag";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox tokenTextBox;
        private System.Windows.Forms.Button evaluateButton;
        private System.Windows.Forms.TextBox userIdTextBox;
    }
}

