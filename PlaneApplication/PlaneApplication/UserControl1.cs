using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PlaneApplication
{
    public partial class UserControl1 : UserControl
    {
        SoundPlayer player;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player=new SoundPlayer(Resource1.inishazirliklari);
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Resource1.kemerler);
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Resource1.turbulans);
            player.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Resource1.tesekkurler);
            player.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Resource1.beep);
            player.Play();
        }
    }
}
