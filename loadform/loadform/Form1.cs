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
            label1.Text = "kullan�c� ad�: irmakoflu";
            label2.Text = "kullan�c� maili: iroflu2004@gmail.com";
            label3.Text = "kullan�c� lokasyonu : Kocaeli";

            MessageBox.Show("Merhaba,form y�klendi.\n Sisteme ho�geldiniz.Formun y�klenmesi i�in OK butonuna t�klay�n�z.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
