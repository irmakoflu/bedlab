namespace BringToFront
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }
    }
}
