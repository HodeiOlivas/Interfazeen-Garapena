namespace KaixoMundua
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
            this.buttonKaixo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKaixo
            // 
            this.buttonKaixo.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonKaixo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKaixo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonKaixo.Location = new System.Drawing.Point(188, 94);
            this.buttonKaixo.Name = "buttonKaixo";
            this.buttonKaixo.Size = new System.Drawing.Size(110, 40);
            this.buttonKaixo.TabIndex = 0;
            this.buttonKaixo.Text = "KAIXO";
            this.buttonKaixo.UseVisualStyleBackColor = false;
            this.buttonKaixo.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(451, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "ITXI";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonKaixo);
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonKaixo;
        private Button button2;
    }
}