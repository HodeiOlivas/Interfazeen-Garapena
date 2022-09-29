namespace EsaldiakLotu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEsaldi1 = new System.Windows.Forms.Button();
            this.btnEsaldi2 = new System.Windows.Forms.Button();
            this.btnEsaldi3 = new System.Windows.Forms.Button();
            this.btnEsaldi4 = new System.Windows.Forms.Button();
            this.btnEsaldi5 = new System.Windows.Forms.Button();
            this.btnLotu = new System.Windows.Forms.Button();
            this.btnEzabatu = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEsaldi1
            // 
            this.btnEsaldi1.Location = new System.Drawing.Point(129, 187);
            this.btnEsaldi1.Name = "btnEsaldi1";
            this.btnEsaldi1.Size = new System.Drawing.Size(75, 23);
            this.btnEsaldi1.TabIndex = 0;
            this.btnEsaldi1.Text = "Esaldi 1";
            this.btnEsaldi1.UseVisualStyleBackColor = true;
            this.btnEsaldi1.Click += new System.EventHandler(this.btnEsaldi1_Click);
            // 
            // btnEsaldi2
            // 
            this.btnEsaldi2.Location = new System.Drawing.Point(255, 187);
            this.btnEsaldi2.Name = "btnEsaldi2";
            this.btnEsaldi2.Size = new System.Drawing.Size(75, 23);
            this.btnEsaldi2.TabIndex = 1;
            this.btnEsaldi2.Text = "Esaldi 2";
            this.btnEsaldi2.UseVisualStyleBackColor = true;
            this.btnEsaldi2.Click += new System.EventHandler(this.btnEsaldi2_Click);
            // 
            // btnEsaldi3
            // 
            this.btnEsaldi3.Location = new System.Drawing.Point(376, 187);
            this.btnEsaldi3.Name = "btnEsaldi3";
            this.btnEsaldi3.Size = new System.Drawing.Size(75, 23);
            this.btnEsaldi3.TabIndex = 2;
            this.btnEsaldi3.Text = "Esaldi 3";
            this.btnEsaldi3.UseVisualStyleBackColor = true;
            this.btnEsaldi3.Click += new System.EventHandler(this.btnEsaldi3_Click);
            // 
            // btnEsaldi4
            // 
            this.btnEsaldi4.Location = new System.Drawing.Point(129, 262);
            this.btnEsaldi4.Name = "btnEsaldi4";
            this.btnEsaldi4.Size = new System.Drawing.Size(75, 23);
            this.btnEsaldi4.TabIndex = 3;
            this.btnEsaldi4.Text = "Esaldi 4";
            this.btnEsaldi4.UseVisualStyleBackColor = true;
            this.btnEsaldi4.Click += new System.EventHandler(this.btnEsaldi4_Click);
            // 
            // btnEsaldi5
            // 
            this.btnEsaldi5.Location = new System.Drawing.Point(255, 262);
            this.btnEsaldi5.Name = "btnEsaldi5";
            this.btnEsaldi5.Size = new System.Drawing.Size(75, 23);
            this.btnEsaldi5.TabIndex = 4;
            this.btnEsaldi5.Text = "Esaldi 5";
            this.btnEsaldi5.UseVisualStyleBackColor = true;
            this.btnEsaldi5.Click += new System.EventHandler(this.btnEsaldi5_Click);
            // 
            // btnLotu
            // 
            this.btnLotu.Location = new System.Drawing.Point(376, 262);
            this.btnLotu.Name = "btnLotu";
            this.btnLotu.Size = new System.Drawing.Size(75, 23);
            this.btnLotu.TabIndex = 5;
            this.btnLotu.Text = "Lotu";
            this.btnLotu.UseVisualStyleBackColor = true;
            this.btnLotu.Click += new System.EventHandler(this.btnLotu_Click);
            // 
            // btnEzabatu
            // 
            this.btnEzabatu.Location = new System.Drawing.Point(168, 355);
            this.btnEzabatu.Name = "btnEzabatu";
            this.btnEzabatu.Size = new System.Drawing.Size(75, 23);
            this.btnEzabatu.TabIndex = 6;
            this.btnEzabatu.Text = "Ezabatu";
            this.btnEzabatu.UseVisualStyleBackColor = true;
            this.btnEzabatu.Click += new System.EventHandler(this.btnEzabatu_Click);
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(307, 355);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(75, 23);
            this.bntExit.TabIndex = 7;
            this.bntExit.Text = "EXIT";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 103);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.btnEzabatu);
            this.Controls.Add(this.btnLotu);
            this.Controls.Add(this.btnEsaldi5);
            this.Controls.Add(this.btnEsaldi4);
            this.Controls.Add(this.btnEsaldi3);
            this.Controls.Add(this.btnEsaldi2);
            this.Controls.Add(this.btnEsaldi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEsaldi1;
        private Button btnEsaldi2;
        private Button btnEsaldi3;
        private Button btnEsaldi4;
        private Button btnEsaldi5;
        private Button btnLotu;
        private Button btnEzabatu;
        private Button bntExit;
        private TextBox textBox1;
    }
}