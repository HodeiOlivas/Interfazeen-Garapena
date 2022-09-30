namespace Ariketa2_List
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHurrengoa = new System.Windows.Forms.Button();
            this.btnGarbitu = new System.Windows.Forms.Button();
            this.btnirten = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1Zenbakia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(374, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 23);
            this.textBox1.TabIndex = 8;
            // 
            // btnHurrengoa
            // 
            this.btnHurrengoa.Location = new System.Drawing.Point(244, 280);
            this.btnHurrengoa.Name = "btnHurrengoa";
            this.btnHurrengoa.Size = new System.Drawing.Size(92, 48);
            this.btnHurrengoa.TabIndex = 9;
            this.btnHurrengoa.Text = "Hurrengoa";
            this.btnHurrengoa.UseVisualStyleBackColor = true;
            // 
            // btnGarbitu
            // 
            this.btnGarbitu.Location = new System.Drawing.Point(374, 280);
            this.btnGarbitu.Name = "btnGarbitu";
            this.btnGarbitu.Size = new System.Drawing.Size(92, 48);
            this.btnGarbitu.TabIndex = 10;
            this.btnGarbitu.Text = "Garbitu";
            this.btnGarbitu.UseVisualStyleBackColor = true;
            this.btnGarbitu.Click += new System.EventHandler(this.btnGarbitu_Click);
            // 
            // btnirten
            // 
            this.btnirten.Location = new System.Drawing.Point(505, 280);
            this.btnirten.Name = "btnirten";
            this.btnirten.Size = new System.Drawing.Size(92, 48);
            this.btnirten.TabIndex = 11;
            this.btnirten.Text = "Irten";
            this.btnirten.UseVisualStyleBackColor = true;
            this.btnirten.Click += new System.EventHandler(this.btnirten_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "Hurrengoa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1Zenbakia
            // 
            this.label1Zenbakia.AutoSize = true;
            this.label1Zenbakia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1Zenbakia.Location = new System.Drawing.Point(241, 126);
            this.label1Zenbakia.Name = "label1Zenbakia";
            this.label1Zenbakia.Size = new System.Drawing.Size(104, 25);
            this.label1Zenbakia.TabIndex = 16;
            this.label1Zenbakia.Text = "Zenbakia 1";
            this.label1Zenbakia.Click += new System.EventHandler(this.label1Zenbakia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1Zenbakia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnirten);
            this.Controls.Add(this.btnGarbitu);
            this.Controls.Add(this.btnHurrengoa);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button btnHurrengoa;
        private Button btnGarbitu;
        private Button btnirten;
        private Button button1;
        private Label label1Zenbakia;
    }
}