namespace MouseEnter
{
    public partial class Form1 : Form
    {
        Random rRandom = new Random();
        Random gRandom = new Random();
        Random bRandom = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(rRandom.Next(0, 255), gRandom.Next(0, 255), bRandom.Next(0, 255));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text= trackBar1.Value.ToString();    
        }
    }
}
