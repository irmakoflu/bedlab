namespace KartUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idtextBox_Click(object sender, EventArgs e)
        {
            if (idtextBox.Text == "  id:")
            {
                idtextBox.ForeColor = Color.Black;
                idtextBox.Clear();
            }
        }

        private void nametextBox_Click(object sender, EventArgs e)
        {
            if (nametextBox.Text == "  name:")
            {
                nametextBox.ForeColor = Color.Black;
                nametextBox.Clear();
            }
        }

        private void datetextBox_Click(object sender, EventArgs e)
        {
            if (datetextBox.Text == "  date:")
            {
                datetextBox.ForeColor = Color.Black;
                datetextBox.Clear();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void idtextBox_TextChanged(object sender, EventArgs e)
        {
            cardnumberlabel.Text= idtextBox.Text;
        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {
            namelabel.Text= nametextBox.Text;
        }

        private void datetextBox_TextChanged(object sender, EventArgs e)
        {
            carddatelabel.Text= datetextBox.Text;
        }
    }
}
