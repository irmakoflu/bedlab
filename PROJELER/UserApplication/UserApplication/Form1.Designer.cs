namespace UserApplication
{
    partial class kullaniciekleformu
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
            dataGridView1 = new DataGridView();
            kullanıcıadi = new DataGridViewTextBoxColumn();
            parola = new DataGridViewTextBoxColumn();
            kayittarihi = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            kullaniciaditextBox = new TextBox();
            parolatextBox = new TextBox();
            button = new Button();
            testbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kullanıcıadi, parola, kayittarihi });
            dataGridView1.Location = new Point(3, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(665, 188);
            dataGridView1.TabIndex = 0;
            // 
            // kullanıcıadi
            // 
            kullanıcıadi.HeaderText = "kullanıcı adı";
            kullanıcıadi.MinimumWidth = 6;
            kullanıcıadi.Name = "kullanıcıadi";
            kullanıcıadi.Width = 200;
            // 
            // parola
            // 
            parola.HeaderText = "parola";
            parola.MinimumWidth = 6;
            parola.Name = "parola";
            parola.Width = 200;
            // 
            // kayittarihi
            // 
            kayittarihi.HeaderText = "kayıt olduğu tarih";
            kayittarihi.MinimumWidth = 6;
            kayittarihi.Name = "kayittarihi";
            kayittarihi.Width = 210;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 204);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 1;
            label1.Text = "KULLANICI ADI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 271);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "PAROLA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 305);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // kullaniciaditextBox
            // 
            kullaniciaditextBox.Location = new Point(3, 227);
            kullaniciaditextBox.Name = "kullaniciaditextBox";
            kullaniciaditextBox.Size = new Size(657, 27);
            kullaniciaditextBox.TabIndex = 4;
            // 
            // parolatextBox
            // 
            parolatextBox.Location = new Point(3, 294);
            parolatextBox.Name = "parolatextBox";
            parolatextBox.Size = new Size(657, 27);
            parolatextBox.TabIndex = 5;
            // 
            // button
            // 
            button.BackColor = Color.GreenYellow;
            button.Location = new Point(3, 338);
            button.Name = "button";
            button.Size = new Size(168, 29);
            button.TabIndex = 6;
            button.Text = "kullanıcı ekle";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // testbutton
            // 
            testbutton.BackColor = Color.Yellow;
            testbutton.Location = new Point(3, 373);
            testbutton.Name = "testbutton";
            testbutton.Size = new Size(168, 29);
            testbutton.TabIndex = 7;
            testbutton.Text = "kullanıcıyı test et";
            testbutton.UseVisualStyleBackColor = false;
            testbutton.Click += testbutton_Click;
            // 
            // kullaniciekleformu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 413);
            Controls.Add(testbutton);
            Controls.Add(button);
            Controls.Add(parolatextBox);
            Controls.Add(kullaniciaditextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "kullaniciekleformu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kullanıcı ekle";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn kullanıcıadi;
        private DataGridViewTextBoxColumn parola;
        private DataGridViewTextBoxColumn kayittarihi;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox kullaniciaditextBox;
        private TextBox parolatextBox;
        private Button button;
        private Button testbutton;
    }
}
