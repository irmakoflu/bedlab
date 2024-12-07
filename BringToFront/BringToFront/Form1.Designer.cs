namespace BringToFront
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
            button1 = new Button();
            button2 = new Button();
            userControl21 = new UserControl2();
            userControl11 = new UserControl1();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(userControl11);
            panel1.Controls.Add(userControl21);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(157, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 365);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(157, 185);
            button1.TabIndex = 0;
            button1.Text = "First UC";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(0, 185);
            button2.Name = "button2";
            button2.Size = new Size(157, 192);
            button2.TabIndex = 1;
            button2.Text = "Second UC";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // userControl21
            // 
            userControl21.Location = new Point(0, 0);
            userControl21.Name = "userControl21";
            userControl21.Size = new Size(520, 365);
            userControl21.TabIndex = 0;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(0, 0);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(520, 365);
            userControl11.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 365);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
    }
}
