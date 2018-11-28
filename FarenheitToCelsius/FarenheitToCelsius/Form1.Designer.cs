namespace FarenheitToCelsius
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
            this.txtboxAM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNoon = new System.Windows.Forms.TextBox();
            this.txtBoxPM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FAM = new System.Windows.Forms.Label();
            this.FNOON = new System.Windows.Forms.Label();
            this.FPM = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CAM = new System.Windows.Forms.Label();
            this.CNOON = new System.Windows.Forms.Label();
            this.CPM = new System.Windows.Forms.Label();
            this.lblSmart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxAM
            // 
            this.txtboxAM.Location = new System.Drawing.Point(378, 46);
            this.txtboxAM.Name = "txtboxAM";
            this.txtboxAM.Size = new System.Drawing.Size(100, 20);
            this.txtboxAM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter three temperatures for today in either Fairenheit or Celsius";
            // 
            // txtBoxNoon
            // 
            this.txtBoxNoon.Location = new System.Drawing.Point(378, 93);
            this.txtBoxNoon.Name = "txtBoxNoon";
            this.txtBoxNoon.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNoon.TabIndex = 2;
            // 
            // txtBoxPM
            // 
            this.txtBoxPM.Location = new System.Drawing.Point(378, 146);
            this.txtBoxPM.Name = "txtBoxPM";
            this.txtBoxPM.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(311, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "A.M. Temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(307, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Noon Temp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(311, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "P.M. Temp";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(390, 172);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(184, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fairenheit";
            // 
            // FAM
            // 
            this.FAM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FAM.Location = new System.Drawing.Point(163, 257);
            this.FAM.Name = "FAM";
            this.FAM.Size = new System.Drawing.Size(100, 23);
            this.FAM.TabIndex = 9;
            // 
            // FNOON
            // 
            this.FNOON.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FNOON.Location = new System.Drawing.Point(163, 304);
            this.FNOON.Name = "FNOON";
            this.FNOON.Size = new System.Drawing.Size(100, 23);
            this.FNOON.TabIndex = 10;
            // 
            // FPM
            // 
            this.FPM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FPM.Location = new System.Drawing.Point(163, 349);
            this.FPM.Name = "FPM";
            this.FPM.Size = new System.Drawing.Size(100, 23);
            this.FPM.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(600, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Celsius";
            // 
            // CAM
            // 
            this.CAM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CAM.Location = new System.Drawing.Point(573, 257);
            this.CAM.Name = "CAM";
            this.CAM.Size = new System.Drawing.Size(100, 23);
            this.CAM.TabIndex = 13;
            // 
            // CNOON
            // 
            this.CNOON.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CNOON.Cursor = System.Windows.Forms.Cursors.Default;
            this.CNOON.Location = new System.Drawing.Point(573, 304);
            this.CNOON.Name = "CNOON";
            this.CNOON.Size = new System.Drawing.Size(100, 23);
            this.CNOON.TabIndex = 14;
            // 
            // CPM
            // 
            this.CPM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CPM.Location = new System.Drawing.Point(573, 349);
            this.CPM.Name = "CPM";
            this.CPM.Size = new System.Drawing.Size(100, 23);
            this.CPM.TabIndex = 15;
            // 
            // lblSmart
            // 
            this.lblSmart.AllowDrop = true;
            this.lblSmart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSmart.Location = new System.Drawing.Point(322, 226);
            this.lblSmart.Name = "lblSmart";
            this.lblSmart.Size = new System.Drawing.Size(197, 35);
            this.lblSmart.TabIndex = 16;
            this.lblSmart.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSmart);
            this.Controls.Add(this.CPM);
            this.Controls.Add(this.CNOON);
            this.Controls.Add(this.CAM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FPM);
            this.Controls.Add(this.FNOON);
            this.Controls.Add(this.FAM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxPM);
            this.Controls.Add(this.txtBoxNoon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxAM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxAM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNoon;
        private System.Windows.Forms.TextBox txtBoxPM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label FAM;
        private System.Windows.Forms.Label FNOON;
        private System.Windows.Forms.Label FPM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CAM;
        private System.Windows.Forms.Label CNOON;
        private System.Windows.Forms.Label CPM;
        private System.Windows.Forms.Label lblSmart;
    }
}

