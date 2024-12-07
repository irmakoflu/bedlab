using System.Numerics;
using System.Media;

namespace PlaneApplication
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer(Resource1.isikacmakapamasesi);
        bool thrustOn;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ÖNEGÝTbutton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            thrustOn = true;
        }

        private void ARKAYAGÝTbutton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            thrustOn=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ýsýkpictureBox.Visible)
            {
                ýsýkpictureBox.Visible = false;
                button1.Text = "IÞIKLARI AÇ";
            }
            else
            {
                ýsýkpictureBox.Visible = true;
                button1.Text = "IÞIKLARI KAPAT";
            }
            player.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (thrustOn)
            {
                ucakpictureBox.Location = new Point(ucakpictureBox.Location.X, ucakpictureBox.Location.Y - 1);
                ýsýkpictureBox.Location = new Point(ýsýkpictureBox.Location.X, ýsýkpictureBox.Location.Y - 1);
            }
           else
            {
                ucakpictureBox.Location = new Point(ucakpictureBox.Location.X, ucakpictureBox.Location.Y + 1);
                ýsýkpictureBox.Location = new Point(ýsýkpictureBox.Location.X, ýsýkpictureBox.Location.Y + 1);
            }

        }
    }
}
