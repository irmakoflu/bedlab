namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void verieklebutton_Click(object sender, EventArgs e)
        {
            string baslik=basliktextBox.Text;
            string konu=konutextBox.Text;
            string icerik=icerikrichTextBox.Text;

            dataGridView1.Rows.Add(baslik,konu,icerik);

            MessageBox.Show("veri eklendi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
