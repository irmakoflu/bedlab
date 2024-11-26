namespace box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void processbutton_Click(object sender, EventArgs e)
        {
            int result = 0;
            bool isValid = true;

              
            if (!int.TryParse(number1maskedTextBox.Text, out int number1))
            {
                MessageBox.Show("Lütfen geçerli bir birinci sayý girin.");
                isValid = false;
            }

            if (!int.TryParse(number2maskedTextBox.Text, out int number2))
            {
                MessageBox.Show("Lütfen geçerli bir ikinci sayý girin.");
                isValid = false;
            }

             
            char pickedoperator=' ';
            if (string.IsNullOrWhiteSpace(pickedoperatorcomboBox.Text) || !char.TryParse(pickedoperatorcomboBox.Text, out pickedoperator))
            {
                MessageBox.Show("Lütfen bir operatör seçiniz.");
                isValid = false;
            }

            
            if (!isValid) return;

            
            switch (pickedoperator)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    if (number2 == 0)
                    {
                        MessageBox.Show("Sayý sýfýra bölünemez.");
                        return; 
                    }
                    result = number1 / number2;
                    break;
                default:
                    MessageBox.Show("Geçersiz operatör. Lütfen +, -, * veya / seçiniz.");
                    return;  
            }

             
            resultslistBox.Items.Add(result.ToString());
        }
    }
}
