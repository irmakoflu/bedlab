namespace Ruby_Cafe
{
    public partial class Form1 : Form
    {
        /*MONEY*/
        int money = 1000;

        /*FOOD PR�CES*/
        int cafe = 115;
        int tea = 80;
        int milk = 95;
        int cupcake = 100;
        int croissant = 120;
        int sandwich = 110;

        /*TOTAL PR�CE*/
        int totalprice = 0;
        public Form1()
        {
            InitializeComponent();
        }
         Dictionary<string, int> cartItems = new Dictionary<string, int>();  
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            moneyLabel.Text = money.ToString() + "TL";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sandwichpictureBox_Click(object sender, EventArgs e)
        {
         
            AddItemToCart("Sandwich", sandwich);
        }

        private void croissantpictureBox_Click(object sender, EventArgs e)
        {
            AddItemToCart("Croissant", croissant);
        }

        private void cupcakepictureBox_Click(object sender, EventArgs e)
        {
            AddItemToCart("Cupcake", cupcake);
        }

        private void cafepictureBox_Click(object sender, EventArgs e)
        {
            AddItemToCart("Cafe", cafe);
        }

        private void milkpictureBox_Click(object sender, EventArgs e)
        {
            AddItemToCart("Milk", milk);
        }

        private void teapictureBox_Click(object sender, EventArgs e)
        {
            AddItemToCart("Tea", tea);
        }
        private void AddItemToCart(string itemName, int itemPrice)
        {
            totalprice += itemPrice;

            // E�er yiyecek zaten sepette varsa miktar�n� art�r  
            if (cartItems.ContainsKey(itemName))
            {
                cartItems[itemName]++;
            }
            else
            {
                cartItems[itemName] = 1; // Yeni yiyecek ekleniyor  
            }

            UpdateCartListBox(); // Sepeti g�ncelle  
        }
        private void UpdateCartListBox()
        {
            cartlistbox.Items.Clear(); // Mevcut listeyi temizle  
            foreach (var item in cartItems)
            {
                cartlistbox.Items.Add($"{item.Key} - {item.Value} adet"); // Yiyecek ve miktar�n� ekle  
            }
        }

        private void paybutton_Click(object sender, EventArgs e)
        {
            if (totalprice <= money)
            {
                money = money - totalprice;

                moneyLabel.Text = money.ToString() + "TL";
                MessageBox.Show("toplam tutar:"+totalprice+"TL\n" +"Al��veri� yapt���n�z i�in te�ekk�r ederiz.\n"+"AF�YET OLSUN :)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                totalprice = 0;
                cartItems.Clear();
                UpdateCartListBox();
            }
            else
            {
                MessageBox.Show("Paran�z yetmemektedir!\n"+"mevcut bakiyeniz:"+money+"TL", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
