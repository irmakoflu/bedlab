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

        private void �NEG�Tbutton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            thrustOn = true;
        }

        private void ARKAYAG�Tbutton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            thrustOn=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (�s�kpictureBox.Visible)
            {
                �s�kpictureBox.Visible = false;
                button1.Text = "I�IKLARI A�";
            }
            else
            {
                �s�kpictureBox.Visible = true;
                button1.Text = "I�IKLARI KAPAT";
            }
            player.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (thrustOn)
            {
                ucakpictureBox.Location = new Point(ucakpictureBox.Location.X, ucakpictureBox.Location.Y - 1);
                �s�kpictureBox.Location = new Point(�s�kpictureBox.Location.X, �s�kpictureBox.Location.Y - 1);
            }
           else
            {
                ucakpictureBox.Location = new Point(ucakpictureBox.Location.X, ucakpictureBox.Location.Y + 1);
                �s�kpictureBox.Location = new Point(�s�kpictureBox.Location.X, �s�kpictureBox.Location.Y + 1);
            }

        }
    }
}
