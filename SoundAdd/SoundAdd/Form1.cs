using System.Media;

namespace SoundAdd
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer(Resources);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "Resources", "buttonsound.wav");
            //buttonsound.sound=FromFile(filePath);
            player.Play();
        }
    }
}
