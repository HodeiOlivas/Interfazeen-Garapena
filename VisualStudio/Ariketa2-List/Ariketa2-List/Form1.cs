using static Ariketa2_List.Lista;

namespace Ariketa2_List
{
    
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }
        public Lista list = new Lista();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnirten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            this.label1Zenbakia.Text = "Zenbakia 1";
            this.textBox1.Text = "";
            list.zenb = 0;
            list.zenb2 = 0;
            list.zenb3 = 0;
            list.zenb4 = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (this.label1Zenbakia.Text.ToLower())
            {
                case "zenbakia 1":
                    try
                    {
                        list.zenb = float.Parse(this.textBox1.Text);
                        this.label1Zenbakia.Text = "Zenbakia 2";
                        this.textBox1.Text = "";
                        this.textBox1.Focus();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("zenbaki bat sartu behar dozu. " + ex.Message); }

                    break;
                case "zenbakia 2":
                    try
                    {
                        list.zenb2 = float.Parse(this.textBox1.Text);
                        this.label1Zenbakia.Text = "Zenbakia 3";
                        this.textBox1.Text = "";
                        this.textBox1.Focus();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("zenbaki bat sartu behar dozu. " + ex.Message); }

                    break;
                case "zenbakia 3":
                    try
                    {
                        list.zenb3 = float.Parse(this.textBox1.Text);
                        this.label1Zenbakia.Text = "Zenbakia 4";
                        this.textBox1.Text = "";
                        this.textBox1.Focus();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("zenbaki bat sartu behar dozu. " + ex.Message); }

                    break;
                case "zenbakia 4":
                    try
                    {
                        list.zenb4 = float.Parse(this.textBox1.Text);
                        this.textBox1.Text = "";
                        this.label1Zenbakia.Text = "Eragiketa";
                        this.textBox1.Text = "(" + list.zenb + " + " + "(2 x " + list.zenb2 + ") +" + "(3 x " + list.zenb3 + ") + " + "(4 x " + list.zenb4 + ")) / 4 = " + list.eragiketa();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("zenbaki bat sartu behar dozu. " + ex.Message); }

                    break;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //Controlar que el usuario no pueda meter letras, solo números.
        {
            if (!Char.IsDigit(e.KeyChar) // ez bada zenbakia
                && e.KeyChar != Convert.ToChar(Keys.Back) // ez bada atzera
                && e.KeyChar != Convert.ToChar(Keys.Delete)// ez bada ezabatu
                && e.KeyChar != Convert.ToChar(",")) // ez bada koma
            {
                e.Handled = true; // ebentoa kontrolatu
                return; // bueltatu
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(",")) // koma bada
                {
                    if (textBox1.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (textBox1.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }
        }

        private void label1Zenbakia_Click(object sender, EventArgs e)
        {

        }
    }

}
