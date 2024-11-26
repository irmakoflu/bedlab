namespace NotifyIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "yeni mesaj!";
            notifyIcon1.BalloonTipText = "...kiþiden mesajýnýz var.";
            notifyIcon1.BalloonTipIcon=ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(3000);
        }
    }
}
