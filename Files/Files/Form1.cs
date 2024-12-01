namespace Files
{
    public partial class Form1 : Form
    {
        string fileName,fileExtension,path;
        public Form1()
        {
            InitializeComponent();
        }

        private void fileCreatorbutton_Click(object sender, EventArgs e)
        {
          fileName= fileNameTextBox.Text;
            fileExtension= fileExtensionTextBox.Text;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Yer seçiniz:";
            saveFileDialog.ShowDialog();

            /*path*/
            path=saveFileDialog.FileName;

            /*create file*/
            File.Create(path+ fileName + fileExtension);
        }
    }
}
