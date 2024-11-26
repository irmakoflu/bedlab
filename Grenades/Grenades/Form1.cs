using System.Media;

namespace Grenades
{
    public partial class Form1 : Form
    {

        SoundPlayer player=new SoundPlayer(Resource1.explosion);
        PictureBox grenade;
        PictureBox grenade2;
        Random xRandom = new Random();/*0-750*/
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 7, pictureBox1.Location.Y);
                pictureBox1.Image = Resource1.runner_left;
            }
            if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 7, pictureBox1.Location.Y);
                pictureBox1.Image = Resource1.runner_right;
            }

        }
        private void generationtimer_Tick(object sender, EventArgs e)
        {
            /*grenade1*/
            grenade = new PictureBox();
            grenade.Image = Resource1.grenade;
            grenade.Size = new Size(50, 50);
            grenade.Location = new Point(xRandom.Next(0, 750), 20);
            grenade.SizeMode = PictureBoxSizeMode.CenterImage;

            this.Controls.Add(grenade);
            /*grenade2*/
            grenade2 = new PictureBox();
            grenade2.Image = Resource1.grenade;
            grenade2.Size = new Size(50, 50);
            grenade2.Location = new Point(xRandom.Next(0, 750), 20);
            grenade2.SizeMode = PictureBoxSizeMode.CenterImage;

            this.Controls.Add(grenade2);


        }

        private void movementtimer_Tick(object sender, EventArgs e)
        {
            if (grenade != null && grenade2 != null)
            {
                grenade.Location = new Point(grenade.Location.X, grenade.Location.Y + 7);
                grenade2.Location = new Point(grenade2.Location.X, grenade2.Location.Y + 7);

                if (grenade.Bounds.IntersectsWith(pictureBox1.Bounds) || grenade2.Bounds.IntersectsWith(pictureBox1.Bounds))
                {
                    grenade.Dispose();
                    grenade2.Dispose();

                    generationtimer.Stop();
                    movementtimer.Stop();

                    player.Play();

                    MessageBox.Show("oyun bitti kaybettiniz!","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Error);   
                    this.Dispose();
                }
            }


        }
    }
    } 