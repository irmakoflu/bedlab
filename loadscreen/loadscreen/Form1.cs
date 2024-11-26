namespace loadscreen
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i != 100)
            {
                i++;
            }
            else
            {
                Form2 form2 = new Form2();

                form2.Show();

                this.Hide();
                timer1.Stop();
            }
        }
    }
}
