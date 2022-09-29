using esaldia;

namespace EsaldiakLotu
{
    public partial class Form1 : Form
    {
        Esaldia esaldia = new Esaldia();

        public Form1()
        {
            InitializeComponent();
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = false;

        }


        private void Hasieratu()
        {
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEsaldi1_Click(object sender, EventArgs e)
        {


            btnEsaldi2.Enabled = true;
            esaldia.Zatia = textBox1.Text;
            if (textBox1.TextLength < 1)
            {
                btnEsaldi2.Enabled = false;
                btnEsaldi3.Enabled = false;
                btnEsaldi4.Enabled = false;
                btnEsaldi5.Enabled = false;
                MessageBox.Show("Idatzi zeozer!");
            }
            else { btnEsaldi2.Enabled = true;
                btnEsaldi1.Enabled = false;
                btnEsaldi5.Enabled = false;
            }
            esaldia.Batu();
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void btnEsaldi2_Click(object sender, EventArgs e)
        {


            btnEsaldi3.Enabled = true;
            esaldia.Zatia = textBox1.Text;
            if (textBox1.TextLength < 1)
            {

                btnEsaldi3.Enabled = false;
                btnEsaldi4.Enabled = false;
                btnEsaldi5.Enabled = false;
                MessageBox.Show("Idatzi zeozer!");
            }
            else
            {
                btnEsaldi3.Enabled = true;
                btnEsaldi2.Enabled = false;
            }
            esaldia.Batu();
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void btnEsaldi3_Click(object sender, EventArgs e)
        {
            btnEsaldi4.Enabled = true;
            esaldia.Zatia = textBox1.Text;
            if (textBox1.TextLength < 1)
            {


                btnEsaldi4.Enabled = false;
                btnEsaldi5.Enabled = false;
                MessageBox.Show("Idatzi zeozer!");
            }
            else
            {
                btnEsaldi4.Enabled = true;
                btnEsaldi3.Enabled = false;
            }
            esaldia.Batu();
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void btnEsaldi4_Click(object sender, EventArgs e)
        {
            btnEsaldi4.Enabled = true;
            esaldia.Zatia = textBox1.Text;
            if (textBox1.TextLength < 1)
            {



                btnEsaldi5.Enabled = false;
                MessageBox.Show("Idatzi zeozer!");
            }
            else
            {
                btnEsaldi5.Enabled = true;
                btnEsaldi4.Enabled = false;
            }
            esaldia.Batu();
            textBox1.Text = "";
            textBox1.Focus();
        }

    

        private void btnEsaldi5_Click(object sender, EventArgs e)
        {
            btnEsaldi5.Enabled = true;
            esaldia.Zatia = textBox1.Text;
            if (textBox1.TextLength < 1)
            {

               
                MessageBox.Show("Idatzi zeozer!");
            }
            else
            {
                btnEsaldi1.Enabled = true;
                btnEsaldi4.Enabled = false;
                btnEsaldi5.Enabled = false;
            }
            esaldia.Batu();
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void btnLotu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(esaldia.EsaldiaBatuta);
        }

        private void btnEzabatu_Click(object sender, EventArgs e)
        {
            Hasieratu();

        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 

        }
    }
}