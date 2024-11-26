namespace Location
{
    public partial class Form1 : Form
    {
        Random randomX = new Random();
        Random randomY = new Random();
        int maxX = 720;
        int maxY = 420;

        Point buttonlocation;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonlocation=new Point(randomX.Next(0,maxX),randomY.Next(0,maxY));
            button1.Location = buttonlocation;
        }
    }
}
