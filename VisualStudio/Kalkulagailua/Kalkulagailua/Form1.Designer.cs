namespace Kalkulagailua
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
            this.textzenbakia1 = new System.Windows.Forms.TextBox();
            this.textzenbakia2 = new System.Windows.Forms.TextBox();
            this.btnGehiketa = new System.Windows.Forms.Button();
            this.btnKenketa = new System.Windows.Forms.Button();
            this.btnZatiketa = new System.Windows.Forms.Button();
            this.btnBiderketa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textzenbakia1
            // 
            this.textzenbakia1.Location = new System.Drawing.Point(234, 106);
            this.textzenbakia1.Name = "textzenbakia1";
            this.textzenbakia1.Size = new System.Drawing.Size(100, 23);
            this.textzenbakia1.TabIndex = 0;
            this.textzenbakia1.TextChanged += new System.EventHandler(this.textzenbakia1_TextChanged);
            this.textzenbakia1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textzenbakia1_KeyPress);
            // 
            // textzenbakia2
            // 
            this.textzenbakia2.Location = new System.Drawing.Point(440, 106);
            this.textzenbakia2.Name = "textzenbakia2";
            this.textzenbakia2.Size = new System.Drawing.Size(100, 23);
            this.textzenbakia2.TabIndex = 1;
            this.textzenbakia2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textzenbakia2_KeyPress);
            // 
            // btnGehiketa
            // 
            this.btnGehiketa.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGehiketa.Location = new System.Drawing.Point(265, 185);
            this.btnGehiketa.Name = "btnGehiketa";
            this.btnGehiketa.Size = new System.Drawing.Size(69, 64);
            this.btnGehiketa.TabIndex = 2;
            this.btnGehiketa.Text = "+";
            this.btnGehiketa.UseVisualStyleBackColor = true;
            this.btnGehiketa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKenketa
            // 
            this.btnKenketa.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKenketa.Location = new System.Drawing.Point(440, 185);
            this.btnKenketa.Name = "btnKenketa";
            this.btnKenketa.Size = new System.Drawing.Size(69, 64);
            this.btnKenketa.TabIndex = 3;
            this.btnKenketa.Text = "-";
            this.btnKenketa.UseVisualStyleBackColor = true;
            this.btnKenketa.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnZatiketa
            // 
            this.btnZatiketa.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZatiketa.Location = new System.Drawing.Point(440, 317);
            this.btnZatiketa.Name = "btnZatiketa";
            this.btnZatiketa.Size = new System.Drawing.Size(69, 64);
            this.btnZatiketa.TabIndex = 4;
            this.btnZatiketa.Text = "/";
            this.btnZatiketa.UseVisualStyleBackColor = true;
            this.btnZatiketa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBiderketa
            // 
            this.btnBiderketa.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBiderketa.Location = new System.Drawing.Point(265, 317);
            this.btnBiderketa.Name = "btnBiderketa";
            this.btnBiderketa.Size = new System.Drawing.Size(69, 64);
            this.btnBiderketa.TabIndex = 5;
            this.btnBiderketa.Text = "*";
            this.btnBiderketa.UseVisualStyleBackColor = true;
            this.btnBiderketa.Click += new System.EventHandler(this.btnBiderketa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "HASIERATU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBiderketa);
            this.Controls.Add(this.btnZatiketa);
            this.Controls.Add(this.btnKenketa);
            this.Controls.Add(this.btnGehiketa);
            this.Controls.Add(this.textzenbakia2);
            this.Controls.Add(this.textzenbakia1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textzenbakia1;
        private TextBox textzenbakia2;
        private Button btnGehiketa;
        private Button btnKenketa;
        private Button btnZatiketa;
        private Button btnBiderketa;
        private Button button1;
        private Button button2;
    }
}