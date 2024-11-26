namespace UserApplication
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            testbutton = new Button();
            kullanicitestbutton = new Button();
            parolatextBox = new TextBox();
            kullaniciaditextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // testbutton
            // 
            testbutton.BackColor = Color.Yellow;
            testbutton.Location = new Point(12, 361);
            testbutton.Name = "testbutton";
            testbutton.Size = new Size(168, 29);
            testbutton.TabIndex = 12;
            testbutton.Text = "kullanıcıyı test et";
            testbutton.UseVisualStyleBackColor = false;
            testbutton.Click += testbutton_Click;
            // 
            // kullanicitestbutton
            // 
            kullanicitestbutton.BackColor = Color.GreenYellow;
            kullanicitestbutton.Location = new Point(12, 396);
            kullanicitestbutton.Name = "kullanicitestbutton";
            kullanicitestbutton.Size = new Size(216, 29);
            kullanicitestbutton.TabIndex = 11;
            kullanicitestbutton.Text = "kullanıcı ekle formuna git";
            kullanicitestbutton.UseVisualStyleBackColor = false;
            kullanicitestbutton.Click += button_Click;
            // 
            // parolatextBox
            // 
            parolatextBox.Location = new Point(10, 307);
            parolatextBox.Name = "parolatextBox";
            parolatextBox.Size = new Size(657, 27);
            parolatextBox.TabIndex = 10;
            // 
            // kullaniciaditextBox
            // 
            kullaniciaditextBox.Location = new Point(10, 229);
            kullaniciaditextBox.Name = "kullaniciaditextBox";
            kullaniciaditextBox.Size = new Size(657, 27);
            kullaniciaditextBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 206);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 13;
            label1.Text = "KULLANICI ADI:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 284);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 14;
            label2.Text = "PAROLA:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(10, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(657, 181);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 450);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(testbutton);
            Controls.Add(kullanicitestbutton);
            Controls.Add(parolatextBox);
            Controls.Add(kullaniciaditextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kullanıcı testi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button testbutton;
        private Button button;
        private TextBox parolatextBox;
        private TextBox kullaniciaditextBox;
        private Label label1;
        private Label label2;
        private Button kullanicitestbutton;
        private RichTextBox richTextBox1;
    }
}