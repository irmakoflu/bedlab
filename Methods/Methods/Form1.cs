namespace Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // SetLabelUI();
           setonelabelUI(label1,Color.Red,Color.Yellow);
           setonelabelUI(label2,Color.Wheat,Color.DarkGoldenrod);
           setonelabelUI(label3,Color.Fuchsia,Color.Pink);
           setonelabelUI(label4,Color.LightGoldenrodYellow,Color.Blue);
           setonelabelUI(label5,Color.Plum,Color.LightCyan);
        }
        /*parametresiz metod*/
        void SetLabelUI()
        {
            label1.BackColor = Color.Wheat;
            label1.ForeColor = Color.Red;

            label2.BackColor = Color.Orange;
            label2.ForeColor = Color.Plum;

            label3.BackColor = Color.Yellow;
            label3.ForeColor = Color.Green;

            label4.BackColor = Color.Magenta;
            label4.ForeColor = Color.Pink;

            label5.BackColor = Color.Turquoise;
            label5.ForeColor = Color.DarkGoldenrod;

        }
        /*PARAMETRELÝ METOD*/
        void setonelabelUI(Label label1, Color foreColor, Color backColor)
        {
            label1.BackColor = backColor;
            label1.ForeColor = foreColor;
        }
    }
}

