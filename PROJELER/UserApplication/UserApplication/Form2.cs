using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserApplication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            kullaniciekleformu form1 = new kullaniciekleformu();

            form1.Show();
            this.Hide();
        }

        private void testbutton_Click(object sender, EventArgs e)
        {
            int kullaniciindex = 0;
            int parolaindex = 0;

            bool kullanicivarmi = false;
            bool paroladogrumu = false;

            string kullanıcıad=kullaniciaditextBox.Text;
            string parola=parolatextBox.Text;

            for (int i = 0; i < kullaniciekleformu.userindex; i++)
            {
                if (kullanıcıad == kullaniciekleformu.kullanicilar[i])
                {
                    kullanicivarmi = true;
                    kullaniciindex = i;
                }
            }
            for (int i = 0; i < kullaniciekleformu.userindex; i++)
            {
                if (parola == kullaniciekleformu.parolalar[i])
                {
                    paroladogrumu = true;
                    parolaindex = i;
                }
            }

            if (kullanicivarmi && paroladogrumu)
            {
                if (kullaniciindex == parolaindex)
                {
                    richTextBox1.Text = "Kullanıcı sistemde tanımlıdır.";
                    MessageBox.Show("kullanıcı sistemde tanımlıdır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    richTextBox1.Text = "Kullanıcı sistemde tanımlı değildir.";
                    MessageBox.Show("kullanıcı sistemde tanımlı değildir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                richTextBox1.Text = "Kullanıcı sistemde tanımlı değildir.";
                MessageBox.Show("kullanıcı sistemde tanımlı değildir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            



        }
    }
}
