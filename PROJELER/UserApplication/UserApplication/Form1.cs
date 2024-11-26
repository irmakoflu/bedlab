namespace UserApplication
{
    public partial class kullaniciekleformu : Form
    {
        public static string[] kullanicilar = new string[128];
        public static string[] parolalar = new string[128];
        public static int userindex = 0;
        public kullaniciekleformu()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string kullaniciadi = kullaniciaditextBox.Text;
            string parola = parolatextBox.Text;

            dataGridView1.Rows.Add(kullaniciadi, parola, DateTime.Now);

            kullanicilar[userindex] = kullaniciadi;
            parolalar[userindex] = parola;
            userindex++;


            MessageBox.Show("kullanýcý eklendi.Kullanýcý no:" + userindex.ToString(), "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void testbutton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
        }
    }
}
