namespace MouseLeaveEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("panel1'in üzerinden mouse ile çýkýldý.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("panel2'in üzerinden mouse ile çýkýldý.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("panel3'in üzerinden mouse ile çýkýldý.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
