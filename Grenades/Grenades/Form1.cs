namespace Grenades
{
    public partial class Form1 : Form
    {
        Random xrandom=new Random();

        PictureBox grenade;
        public Form1()
        {
            InitializeComponent();
        }

        private void generatingtimer_Tick(object sender, EventArgs e)
        {
          
            string filePath = Path.Combine(Application.StartupPath, "Resources", "grenade.png");

            grenade = new PictureBox();
            grenade.Size = new Size(58, 56);
            grenade.Image = Image.FromFile(filePath);
            grenade.Location = new Point(50, 20);
            grenade.SizeMode = PictureBoxSizeMode.CenterImage;
            this.Controls.Add(grenade);
        }
    }
}
