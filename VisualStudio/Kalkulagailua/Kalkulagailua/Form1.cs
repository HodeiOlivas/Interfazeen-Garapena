namespace Kalkulagailua
{
    public partial class Form1 : Form
    {
        Kalkulagailua kalkulagailua = new Kalkulagailua();


        public Form1()
        {
            InitializeComponent();
        }


        private void balioak() {

            
            
            try
            {
                kalkulagailua.Zenbaki1 = float.Parse(textzenbakia1.Text);
                kalkulagailua.Zenbaki2 = float.Parse(textzenbakia2.Text);
            }
            catch (Exception ex) { 
            MessageBox.Show("Errorea gertatu da. " + ex.Message +"!");
               
            }
            
        }
        private void Hasieratu() {

            textzenbakia1.Text = "";
            textzenbakia2.Text = "";
            textzenbakia1.Focus();

        }
        private void button1_Click(object sender, EventArgs e)
        {

            balioak();
            MessageBox.Show(kalkulagailua.Gehiketa().ToString("0.00"));
            /*  Kalkulagailua kalkulagailua = new Kalkulagailua(float.Parse(textzenbakia1.Text), float.Parse(textzenbakia2.Text));
              MessageBox.Show(kalkulagailua.Gehiketa().ToString("0.00")); */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            balioak();
            MessageBox.Show(kalkulagailua.Kenketa().ToString("0.00"));
            /*  Kalkulagailua kalkulagailua = new Kalkulagailua(float.Parse(textzenbakia1.Text), float.Parse(textzenbakia2.Text));
              MessageBox.Show(kalkulagailua.Kenketa().ToString("0.00")); */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            balioak();
            MessageBox.Show(kalkulagailua.Zatiketa().ToString("0.00"));
            /*  Kalkulagailua kalkulagailua = new Kalkulagailua(float.Parse(textzenbakia1.Text), float.Parse(textzenbakia2.Text));
              MessageBox.Show(kalkulagailua.Zatiketa().ToString("0.00")); */
        }

        private void textzenbakia1_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void btnBiderketa_Click(object sender, EventArgs e)
        {
            balioak();
            MessageBox.Show(kalkulagailua.Biderketa().ToString("0.00"));
            /* Kalkulagailua kalkulagailua = new Kalkulagailua(float.Parse(textzenbakia1.Text), float.Parse(textzenbakia2.Text));
             MessageBox.Show(kalkulagailua.Biderketa().ToString("0.00")); */
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Hasieratu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textzenbakia1_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (textzenbakia1.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (textzenbakia1.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }
        }

        private void textzenbakia2_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (textzenbakia2.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (textzenbakia2.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }
        }
    }
}
