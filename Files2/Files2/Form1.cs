namespace Files2
{
    public partial class Form1 : Form
    {
        string path=string.Empty;
        string content=string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void readbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt) |*.txt";
            ofd.ShowDialog();


            path =ofd.FileName;

            content = File.ReadAllText(path);

            filecontentrichtextbox.Text = content;

        }
    }
}
