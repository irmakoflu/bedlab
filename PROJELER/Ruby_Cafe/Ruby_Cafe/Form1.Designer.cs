namespace Ruby_Cafe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            moneyLabel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            paybutton = new Button();
            cartlistbox = new ListBox();
            label2 = new Label();
            panel3 = new Panel();
            cupcakepictureBox = new PictureBox();
            croissantpictureBox = new PictureBox();
            sandwichpictureBox = new PictureBox();
            milkpictureBox = new PictureBox();
            teapictureBox = new PictureBox();
            cafepictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cupcakepictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)croissantpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sandwichpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)milkpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teapictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cafepictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(moneyLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 284);
            panel1.TabIndex = 0;
            // 
            // moneyLabel
            // 
            moneyLabel.Dock = DockStyle.Bottom;
            moneyLabel.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moneyLabel.Location = new Point(0, 259);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new Size(142, 25);
            moneyLabel.TabIndex = 0;
            moneyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Tempus Sans ITC", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 50);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 0;
            label1.Text = "Ruby Cafe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Cafe_Building;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(paybutton);
            panel2.Controls.Add(cartlistbox);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(510, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(142, 284);
            panel2.TabIndex = 1;
            // 
            // paybutton
            // 
            paybutton.BackColor = Color.MediumSeaGreen;
            paybutton.Dock = DockStyle.Bottom;
            paybutton.FlatAppearance.BorderSize = 0;
            paybutton.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paybutton.Location = new Point(0, 255);
            paybutton.Name = "paybutton";
            paybutton.Size = new Size(142, 29);
            paybutton.TabIndex = 2;
            paybutton.Text = "pay";
            paybutton.UseVisualStyleBackColor = false;
            paybutton.Click += paybutton_Click;
            // 
            // cartlistbox
            // 
            cartlistbox.BackColor = SystemColors.MenuBar;
            cartlistbox.BorderStyle = BorderStyle.None;
            cartlistbox.Dock = DockStyle.Top;
            cartlistbox.FormattingEnabled = true;
            cartlistbox.Location = new Point(0, 20);
            cartlistbox.Name = "cartlistbox";
            cartlistbox.Size = new Size(142, 240);
            cartlistbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 0;
            label2.Text = "CART";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(cupcakepictureBox);
            panel3.Controls.Add(croissantpictureBox);
            panel3.Controls.Add(sandwichpictureBox);
            panel3.Controls.Add(milkpictureBox);
            panel3.Controls.Add(teapictureBox);
            panel3.Controls.Add(cafepictureBox);
            panel3.Cursor = Cursors.Hand;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(142, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(368, 284);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // cupcakepictureBox
            // 
            cupcakepictureBox.Image = Properties.Resources.Confectionery;
            cupcakepictureBox.Location = new Point(0, 141);
            cupcakepictureBox.Name = "cupcakepictureBox";
            cupcakepictureBox.Size = new Size(120, 143);
            cupcakepictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            cupcakepictureBox.TabIndex = 5;
            cupcakepictureBox.TabStop = false;
            cupcakepictureBox.Click += cupcakepictureBox_Click;
            // 
            // croissantpictureBox
            // 
            croissantpictureBox.Image = Properties.Resources.Croissant;
            croissantpictureBox.Location = new Point(122, 141);
            croissantpictureBox.Name = "croissantpictureBox";
            croissantpictureBox.Size = new Size(120, 143);
            croissantpictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            croissantpictureBox.TabIndex = 4;
            croissantpictureBox.TabStop = false;
            croissantpictureBox.Click += croissantpictureBox_Click;
            // 
            // sandwichpictureBox
            // 
            sandwichpictureBox.Image = Properties.Resources.Sandwich;
            sandwichpictureBox.Location = new Point(245, 141);
            sandwichpictureBox.Name = "sandwichpictureBox";
            sandwichpictureBox.Size = new Size(120, 143);
            sandwichpictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            sandwichpictureBox.TabIndex = 3;
            sandwichpictureBox.TabStop = false;
            sandwichpictureBox.Click += sandwichpictureBox_Click;
            // 
            // milkpictureBox
            // 
            milkpictureBox.Image = Properties.Resources.Milk;
            milkpictureBox.Location = new Point(245, 0);
            milkpictureBox.Name = "milkpictureBox";
            milkpictureBox.Size = new Size(120, 143);
            milkpictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            milkpictureBox.TabIndex = 2;
            milkpictureBox.TabStop = false;
            milkpictureBox.Click += milkpictureBox_Click;
            // 
            // teapictureBox
            // 
            teapictureBox.Image = Properties.Resources.Tea;
            teapictureBox.Location = new Point(122, 0);
            teapictureBox.Name = "teapictureBox";
            teapictureBox.Size = new Size(120, 143);
            teapictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            teapictureBox.TabIndex = 1;
            teapictureBox.TabStop = false;
            teapictureBox.Click += teapictureBox_Click;
            // 
            // cafepictureBox
            // 
            cafepictureBox.Image = Properties.Resources.Cafe;
            cafepictureBox.Location = new Point(2, 0);
            cafepictureBox.Name = "cafepictureBox";
            cafepictureBox.Size = new Size(118, 143);
            cafepictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            cafepictureBox.TabIndex = 0;
            cafepictureBox.TabStop = false;
            cafepictureBox.Click += cafepictureBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(652, 284);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Ruby Cafe";
            Load += pictureBox1_Click;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cupcakepictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)croissantpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)sandwichpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)milkpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)teapictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cafepictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label moneyLabel;
        private Label label2;
        private ListBox cartlistbox;
        private PictureBox cafepictureBox;
        private PictureBox cupcakepictureBox;
        private PictureBox croissantpictureBox;
        private PictureBox sandwichpictureBox;
        private PictureBox milkpictureBox;
        private PictureBox teapictureBox;
        private Button paybutton;
    }
}
