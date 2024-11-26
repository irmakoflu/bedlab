namespace KartUygulaması
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
            panel1 = new Panel();
            panel3 = new Panel();
            carddatelabel = new Label();
            cardnumberlabel = new Label();
            namelabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            datetextBox = new TextBox();
            nametextBox = new TextBox();
            idtextBox = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 284);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumPurple;
            panel3.Controls.Add(carddatelabel);
            panel3.Controls.Add(cardnumberlabel);
            panel3.Controls.Add(namelabel);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(12, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(364, 172);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // carddatelabel
            // 
            carddatelabel.AutoSize = true;
            carddatelabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            carddatelabel.ForeColor = Color.Lavender;
            carddatelabel.Location = new Point(262, 126);
            carddatelabel.Name = "carddatelabel";
            carddatelabel.Size = new Size(0, 23);
            carddatelabel.TabIndex = 2;
            // 
            // cardnumberlabel
            // 
            cardnumberlabel.AutoSize = true;
            cardnumberlabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cardnumberlabel.ForeColor = Color.Lavender;
            cardnumberlabel.Location = new Point(3, 56);
            cardnumberlabel.Name = "cardnumberlabel";
            cardnumberlabel.Size = new Size(0, 23);
            cardnumberlabel.TabIndex = 1;
            cardnumberlabel.Click += label1_Click;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            namelabel.ForeColor = Color.Lavender;
            namelabel.Location = new Point(3, 143);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(0, 23);
            namelabel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resource1.pngwing_com;
            pictureBox2.Location = new Point(3, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.kisspng_logo_brand_visa_font_visa_logo_5b5026e335bf43_9289059815319794912202;
            pictureBox1.Location = new Point(262, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(datetextBox);
            panel2.Controls.Add(nametextBox);
            panel2.Controls.Add(idtextBox);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(382, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 284);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(23, 238);
            button1.Name = "button1";
            button1.Size = new Size(155, 29);
            button1.TabIndex = 3;
            button1.Text = "ödemeyi yap";
            button1.UseVisualStyleBackColor = false;
            // 
            // datetextBox
            // 
            datetextBox.ForeColor = SystemColors.InactiveCaption;
            datetextBox.Location = new Point(12, 183);
            datetextBox.Name = "datetextBox";
            datetextBox.Size = new Size(375, 27);
            datetextBox.TabIndex = 2;
            datetextBox.Text = "  date:";
            datetextBox.Click += datetextBox_Click;
            datetextBox.TextChanged += datetextBox_TextChanged;
            // 
            // nametextBox
            // 
            nametextBox.ForeColor = SystemColors.InactiveCaption;
            nametextBox.Location = new Point(12, 113);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(375, 27);
            nametextBox.TabIndex = 1;
            nametextBox.Text = "  name:";
            nametextBox.Click += nametextBox_Click;
            nametextBox.TextChanged += nametextBox_TextChanged;
            // 
            // idtextBox
            // 
            idtextBox.ForeColor = SystemColors.InactiveCaption;
            idtextBox.Location = new Point(12, 42);
            idtextBox.Name = "idtextBox";
            idtextBox.Size = new Size(375, 27);
            idtextBox.TabIndex = 0;
            idtextBox.Text = "  id:";
            idtextBox.Click += idtextBox_Click;
            idtextBox.TextChanged += idtextBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 284);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label namelabel;
        private Label cardnumberlabel;
        private Label carddatelabel;
        private TextBox nametextBox;
        private TextBox idtextBox;
        private Button button1;
        private TextBox datetextBox;
    }
}
