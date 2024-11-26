namespace loadform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "kullanýcý adý: irmakoflu";
            label2.Text = "kullanýcý maili: iroflu2004@gmail.com";
            label3.Text = "kullanýcý lokasyonu : Kocaeli";

            MessageBox.Show("Merhaba,form yüklendi.\n Sisteme hoþgeldiniz.Formun yüklenmesi için OK butonuna týklayýnýz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
