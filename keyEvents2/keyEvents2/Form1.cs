namespace keyEvents2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = "TUÞA BASILIYOR!";
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Text = "TUÞA BASILMIYOR!";
        }
    }
}
