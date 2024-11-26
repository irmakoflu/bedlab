namespace objeler
{
    public partial class Form1 : Form
    {
        Random rRandom=new Random();
        Random gRandom=new Random();
        Random bRandom=new Random();

        Random xlocation=new Random();
        Random ylocation=new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.BackColor=Color.FromArgb(rRandom.Next(0,255),gRandom.Next(0,255),bRandom.Next(0,255));
            panel.Size = new Size(50,50);

            panel.Location = new Point(xlocation.Next(0, 750), ylocation.Next(0, 350));
            this.Controls.Add(panel);

        }
    }
}
