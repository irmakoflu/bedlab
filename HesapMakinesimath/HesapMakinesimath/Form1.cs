namespace HesapMakinesimath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text == "first number:")
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "second number:")
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "first number:")
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "second number:")
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fn=Convert.ToInt32(textBox1.Text);
            int sn=Convert.ToInt32(textBox2.Text);
            string operation = comboBox1.Text;
            int result=0;
            Double powresult=0;

            if (operation == "+")
            {
                result = fn + sn;
            }
            else if (operation == "-")
            {
                result = fn - sn;
            }
            else if (operation == "*")
            {
                result = fn * sn;
            }
            else if (operation == "/")
            {
                if (sn != 0)
                {
                    result = fn / sn;
                }
                MessageBox.Show("sayý sýfýra bölünemez!!");
            }
            else if (operation == "MAX")
            {
                result = Math.Max(fn, sn);
            }
            else if (operation == "MÝN")
            {
                result = Math.Min(fn, sn);
            }
            else if (operation == "POW")
            {
                powresult = Math.Pow(fn, sn);
                MessageBox.Show(powresult.ToString());
            }
            else
            {
                MessageBox.Show("ýnvalid operation data!");
            }
            if (powresult == 0)
            {
                MessageBox.Show(result.ToString());
            }
        }
    }
}
