namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Koe koe = new Koe(90, "boe", "C:\\Users\\delap\\Downloads\\cow-moo2.wav");
                koe.Geluid.Play();
                MessageBox.Show(koe.Zegt());
            }

            if (checkBox2.Checked == true)
            {
                Varken varken = new Varken(50, "groink", "C:\\Users\\delap\\Downloads\\PIG.wav");
                varken.Geluid.Play();
                MessageBox.Show(varken.Zegt());
            }

            if (checkBox3.Checked == true)
            {
                Slang slang = new Slang(10, "ssj", "C:\\Users\\delap\\Downloads\\Snake Strike 01.wav");
                slang.Geluid.Play();
                MessageBox.Show(slang.Zegt());
            }

        } 
    }
}