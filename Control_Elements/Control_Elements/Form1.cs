namespace Control_Elements
{
    public partial class Form1 : Form
    {
        string Totalstring = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void kaydetbutton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Totalstring += "Cinsiyet: kad�n \n";
            }
            else if (radioButton2.Checked)
            {
                Totalstring += "Cinsiyet: erkek \n";
            }
            else {
                Totalstring += "Cinsiyet: di�er \n";
            }
            if (teknolojichecktbox.Checked) {
                Totalstring += "-Teknoloji \n";
            }
            if (m�zikcheckbox.Checked) {
                Totalstring += "-M�zik \n";
            }
            if (sporcheckbox.Checked) {
                Totalstring += "-Spor \n";
            }
            MessageBox.Show(Totalstring, "--Genel Bilgilendirme--");
        }

    }
}
