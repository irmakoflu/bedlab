namespace mathematicsProjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           int a = 10;
           int b = 2;
           double powresult;

            int max,min;
            max=Math.Max(a, b);
            min= Math.Min(a, b);
            powresult=Math.Pow(a, b);

            MessageBox.Show($"max value==> { max.ToString()}");
            MessageBox.Show($"min value==> { min.ToString()}");

          label1.Text=powresult.ToString();

        }
    }
}
