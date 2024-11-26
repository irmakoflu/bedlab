namespace kullanıcıbilgisi
{
    public partial class Form1 : Form
    {
        string totalstring=string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void kaydetbutton_Click(object sender, EventArgs e)
        {

            string ad = adtextBox.Text;
            totalstring += ad;
            string soyad=soyadtextBox.Text;
            totalstring += soyad;
            int yas=Convert.ToInt32(yasmaskedTextBox.Text);

            
            yas.ToString();
            totalstring += yas;

            bilgiler.Items.Add(totalstring.ToString());
            bilgiler.Items.Add("--bilgileriniz--");
        }
    }
}
