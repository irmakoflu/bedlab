namespace keyEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text += e.KeyChar;
        }

        private void azaltbutton_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value!= 0)
            {
                progressBar1.Value -= 10;
                MessageBox.Show("-AZALT {" + progressBar1.Value + "} -" + DateTime.Now);
            }
            else
            {
                MessageBox.Show("daha fazla azaltýlamaz.", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void arttýrbutton_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value!=100)
            {
                progressBar1.Value += 10;
                MessageBox.Show("-ARTTIR {" + progressBar1.Value + "} -" + DateTime.Now);
            }
            else
            {
                MessageBox.Show("daha fazla arttýrýlamaz.", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
