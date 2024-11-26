namespace DataGridView
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            başlık = new DataGridViewTextBoxColumn();
            konu = new DataGridViewTextBoxColumn();
            içerik = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            basliktextBox = new TextBox();
            konutextBox = new TextBox();
            icerikrichTextBox = new RichTextBox();
            verieklebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { başlık, konu, içerik });
            dataGridView1.Location = new Point(1, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(797, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // başlık
            // 
            başlık.HeaderText = "başlık";
            başlık.MinimumWidth = 6;
            başlık.Name = "başlık";
            başlık.Width = 130;
            // 
            // konu
            // 
            konu.HeaderText = "konu";
            konu.MinimumWidth = 6;
            konu.Name = "konu";
            konu.Width = 130;
            // 
            // içerik
            // 
            içerik.HeaderText = "içerik";
            içerik.MinimumWidth = 6;
            içerik.Name = "içerik";
            içerik.Width = 500;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 206);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 2;
            label2.Text = "BAŞLIK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 266);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "KONU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 325);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 4;
            label4.Text = "İÇERİK";
            // 
            // basliktextBox
            // 
            basliktextBox.Location = new Point(9, 229);
            basliktextBox.Name = "basliktextBox";
            basliktextBox.Size = new Size(779, 27);
            basliktextBox.TabIndex = 5;
            // 
            // konutextBox
            // 
            konutextBox.Location = new Point(9, 289);
            konutextBox.Name = "konutextBox";
            konutextBox.Size = new Size(779, 27);
            konutextBox.TabIndex = 6;
            // 
            // icerikrichTextBox
            // 
            icerikrichTextBox.BorderStyle = BorderStyle.FixedSingle;
            icerikrichTextBox.Location = new Point(9, 348);
            icerikrichTextBox.Name = "icerikrichTextBox";
            icerikrichTextBox.Size = new Size(779, 107);
            icerikrichTextBox.TabIndex = 7;
            icerikrichTextBox.Text = "";
            // 
            // verieklebutton
            // 
            verieklebutton.Location = new Point(9, 461);
            verieklebutton.Name = "verieklebutton";
            verieklebutton.Size = new Size(136, 29);
            verieklebutton.TabIndex = 8;
            verieklebutton.Text = "veriyi ekle";
            verieklebutton.UseVisualStyleBackColor = true;
            verieklebutton.Click += verieklebutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 525);
            Controls.Add(verieklebutton);
            Controls.Add(icerikrichTextBox);
            Controls.Add(konutextBox);
            Controls.Add(basliktextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewTextBoxColumn başlık;
        private DataGridViewTextBoxColumn konu;
        private DataGridViewTextBoxColumn içerik;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox basliktextBox;
        private TextBox konutextBox;
        private RichTextBox icerikrichTextBox;
        private Button verieklebutton;
    }
}
