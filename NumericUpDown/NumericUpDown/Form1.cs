namespace NumericUpDown
{
    public partial class Form1 : Form
    {
        int number1;
        int number2;    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number1=Convert.ToInt32(firstnumbernumericUpDown.Value);
            number2=Convert.ToInt32(secondnumbernumericUpDown.Value);

            int result=number1 + number2;

            MessageBox.Show(result.ToString(), " RESULT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
