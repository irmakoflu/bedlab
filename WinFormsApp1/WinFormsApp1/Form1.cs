namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void giriþbutonu_Click(object sender, EventArgs e)
        {
            string istenilenmail = "iroflu2004@gmail.com";
            string mail = mailtextbox.Text;
            sonuclabeli.AutoSize = false;
            sonuclabeli.TextAlign = ContentAlignment.MiddleCenter;
            sonuclabeli.Size = new Size(200, 50);
            sonuclabeli.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top| AnchorStyles.Bottom;

            if (mail == istenilenmail)
            {
                sonuclabeli.Text = "GÝRÝS BASARÝLÝ.";


            }
            else
            {
                sonuclabeli.Text = "GÝRÝS BASARÝSÝZ.Lütfen tekrar deneyiniz.";

            }


        }

        
    }
}