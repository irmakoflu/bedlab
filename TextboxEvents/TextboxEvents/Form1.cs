namespace TextboxEvents
{
    public partial class Form1 : Form
    {
        Random rRandom=new Random();
        Random gRandom=new Random();
        Random bRandom=new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            panel1.BackColor=Color.FromArgb(rRandom.Next(0,255),gRandom.Next(0,255),bRandom.Next(0,255));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(rRandom.Next(0, 255), gRandom.Next(0, 255), bRandom.Next(0, 255));
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "  password:")
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "  username:")
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.Black;
            }
        }
    }
}
