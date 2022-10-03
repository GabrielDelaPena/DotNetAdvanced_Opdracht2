namespace Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    double dollar = Double.Parse(textBox1.Text) * 1.11;
                    textBox6.Text = String.Format("{0:0.00}", dollar);

                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                catch
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Not a number.");
                    }
                }

            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    double dollar = Double.Parse(textBox2.Text) * 0.98;
                    textBox6.Text = String.Format("{0:0.00}", dollar);

                    textBox1.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                catch
                {
                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("Not a number.");
                    }
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    double dollar = Double.Parse(textBox3.Text) * 0.0069;
                    textBox6.Text = String.Format("{0:0.00}", dollar);

                    textBox2.Text = "";
                    textBox1.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                catch
                {
                    if (textBox3.Text == "")
                    {
                        MessageBox.Show("Not a number.");
                    }
                }
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    double dollar = Double.Parse(textBox4.Text) * 0.012;
                    textBox6.Text = String.Format("{0:0.00}", dollar);

                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox1.Text = "";
                    textBox5.Text = "";
                }
                catch
                {
                    if (textBox4.Text == "")
                    {
                        MessageBox.Show("Not a number.");
                    }
                }
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    double dollar = Double.Parse(textBox5.Text) * 1.02;
                    textBox6.Text = String.Format("{0:0.00}", dollar);

                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox1.Text = "";
                }
                catch
                {
                    if (textBox5.Text == "")
                    {
                        MessageBox.Show("Not a number.");
                    }
                }
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    double pond = Double.Parse(textBox6.Text) * 0.90;
                    double euro = Double.Parse(textBox6.Text) * 1.02;
                    double yen = Double.Parse(textBox6.Text) * 144.50;
                    double rupees = Double.Parse(textBox6.Text) * 81.53;
                    double franken = Double.Parse(textBox6.Text) * 0.98;

                    textBox1.Text = String.Format("{0:0.00}", pond);
                    textBox2.Text = String.Format("{0:0.00}", euro);
                    textBox3.Text = String.Format("{0:0.00}", yen);
                    textBox4.Text = String.Format("{0:0.00}", rupees);
                    textBox5.Text = String.Format("{0:0.00}", franken);
                }
                catch
                {
                    if (textBox6.Text == "")
                    {
                        MessageBox.Show("Not a number.");
                    }
                }
            }
        }
    }
}