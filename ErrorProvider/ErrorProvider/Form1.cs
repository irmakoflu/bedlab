namespace ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "kullan�c� ad�n�z� giriniz!");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (textBox2.Text == string.Empty)
            {
                errorProvider2.SetError(textBox2, "kullan�c� parolan�z� giriniz!");
            }
            else
            {
                errorProvider1.Clear();
            }

        }
    }
}
