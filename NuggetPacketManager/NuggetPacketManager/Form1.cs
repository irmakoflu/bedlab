using OpenQA.Selenium.Firefox;

namespace NuggetPacketManager
{
    public partial class Form1 : Form
    {/*firefox driver*/
        FirefoxDriver ffdriver;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (URLtextBox.Text == "URL-->")
            {
                URLtextBox.Clear();
                URLtextBox.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           ffdriver= new FirefoxDriver();

            string url=URLtextBox.Text;
            ffdriver.Navigate().GoToUrl(url);
        }

        private void URLtextBox_Click(object sender, EventArgs e)
        {
            if (URLtextBox.Text == "URL-->")
            {
                URLtextBox.Clear();
                URLtextBox.ForeColor = Color.Black;
            }
        }
    }
}
