namespace Twitter
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnTweet = new System.Windows.Forms.Button();
            this.txtBoxTweet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Location = new System.Drawing.Point(84, 228);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(297, 40);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTweet
            // 
            this.btnTweet.Location = new System.Drawing.Point(195, 202);
            this.btnTweet.Name = "btnTweet";
            this.btnTweet.Size = new System.Drawing.Size(87, 23);
            this.btnTweet.TabIndex = 1;
            this.btnTweet.Text = "Tweet";
            this.btnTweet.UseVisualStyleBackColor = true;
            this.btnTweet.Click += new System.EventHandler(this.btnTweet_Click);
            // 
            // txtBoxTweet
            // 
            this.txtBoxTweet.Location = new System.Drawing.Point(84, 13);
            this.txtBoxTweet.Multiline = true;
            this.txtBoxTweet.Name = "txtBoxTweet";
            this.txtBoxTweet.Size = new System.Drawing.Size(297, 183);
            this.txtBoxTweet.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.txtBoxTweet);
            this.Controls.Add(this.btnTweet);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnTweet;
        private System.Windows.Forms.TextBox txtBoxTweet;
    }
}

