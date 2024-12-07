namespace PlaneApplication
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(3, 12);
            button1.Name = "button1";
            button1.Size = new Size(560, 52);
            button1.TabIndex = 0;
            button1.Text = "İNİŞ HAZIRLIKLARI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.NavajoWhite;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(3, 89);
            button2.Name = "button2";
            button2.Size = new Size(560, 52);
            button2.TabIndex = 1;
            button2.Text = "KEMERLER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.NavajoWhite;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(3, 159);
            button3.Name = "button3";
            button3.Size = new Size(560, 52);
            button3.TabIndex = 2;
            button3.Text = "TÜRBÜLANS";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(3, 240);
            button4.Name = "button4";
            button4.Size = new Size(560, 52);
            button4.TabIndex = 3;
            button4.Text = "TEŞEKKÜRLER";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.Location = new Point(3, 310);
            button5.Name = "button5";
            button5.Size = new Size(560, 52);
            button5.TabIndex = 4;
            button5.Text = "BEEP";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "UserControl1";
            Size = new Size(566, 383);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
