namespace ArrayenAriketa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2Zenbakia.Visible = false;
            textBoxEmaitza.Visible = false;
        }






        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1Zenbakia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2Zenbakia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmaitza_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHurrengoa_Click(object sender, EventArgs e)
        {

            textBox1Zenbakia.Visible = false;
            if (textBox1Zenbakia.Visible = false)
            {

                textBox2Zenbakia.Visible = true;

            }
           
            if (textBox2Zenbakia.Visible = true)
            {


            }
            else {
                textBox2Zenbakia.Visible = false;
                textBoxEmaitza.Visible = true;
             
            }

        }

    

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void btnirten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnhurrengoa2_Click(object sender, EventArgs e)
        {

        }
    }
}