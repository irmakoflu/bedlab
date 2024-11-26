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
                MessageBox.Show("L�tfen ge�erli bir birinci say� girin.");
                isValid = false;
            }

            if (!int.TryParse(number2maskedTextBox.Text, out int number2))
            {
                MessageBox.Show("L�tfen ge�erli bir ikinci say� girin.");
                isValid = false;
            }

             
            char pickedoperator=' ';
            if (string.IsNullOrWhiteSpace(pickedoperatorcomboBox.Text) || !char.TryParse(pickedoperatorcomboBox.Text, out pickedoperator))
            {
                MessageBox.Show("L�tfen bir operat�r se�iniz.");
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
                        MessageBox.Show("Say� s�f�ra b�l�nemez.");
                        return; 
                    }
                    result = number1 / number2;
                    break;
                default:
                    MessageBox.Show("Ge�ersiz operat�r. L�tfen +, -, * veya / se�iniz.");
                    return;  
            }

             
            resultslistBox.Items.Add(result.ToString());
        }
    }
}
