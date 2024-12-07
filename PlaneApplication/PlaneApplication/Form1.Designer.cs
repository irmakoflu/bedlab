namespace PlaneApplication
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            ısıkpictureBox = new PictureBox();
            ucakpictureBox = new PictureBox();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel6 = new Panel();
            userControl11 = new UserControl1();
            panel7 = new Panel();
            ARKAYAGİTbutton = new Button();
            ÖNEGİTbutton = new Button();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ısıkpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucakpictureBox).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(ısıkpictureBox);
            panel1.Controls.Add(ucakpictureBox);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 564);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // ısıkpictureBox
            // 
            ısıkpictureBox.Image = Resource1.isik;
            ısıkpictureBox.Location = new Point(44, 385);
            ısıkpictureBox.Name = "ısıkpictureBox";
            ısıkpictureBox.Size = new Size(39, 38);
            ısıkpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ısıkpictureBox.TabIndex = 1;
            ısıkpictureBox.TabStop = false;
            // 
            // ucakpictureBox
            // 
            ucakpictureBox.Image = Resource1.ucak;
            ucakpictureBox.Location = new Point(12, 429);
            ucakpictureBox.Name = "ucakpictureBox";
            ucakpictureBox.Size = new Size(103, 123);
            ucakpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ucakpictureBox.TabIndex = 1;
            ucakpictureBox.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(117, 526);
            panel5.Name = "panel5";
            panel5.Size = new Size(16, 130);
            panel5.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(117, 358);
            panel4.Name = "panel4";
            panel4.Size = new Size(16, 130);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(117, 183);
            panel3.Name = "panel3";
            panel3.Size = new Size(16, 130);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(117, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(16, 130);
            panel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(userControl11);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(161, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(566, 383);
            panel6.TabIndex = 1;
            // 
            // userControl11
            // 
            userControl11.BackColor = SystemColors.ControlLight;
            userControl11.Location = new Point(3, 3);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(563, 380);
            userControl11.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(ARKAYAGİTbutton);
            panel7.Controls.Add(ÖNEGİTbutton);
            panel7.Controls.Add(button1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(161, 383);
            panel7.Name = "panel7";
            panel7.Size = new Size(566, 181);
            panel7.TabIndex = 2;
            // 
            // ARKAYAGİTbutton
            // 
            ARKAYAGİTbutton.BackColor = SystemColors.GradientActiveCaption;
            ARKAYAGİTbutton.Dock = DockStyle.Fill;
            ARKAYAGİTbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ARKAYAGİTbutton.Location = new Point(287, 0);
            ARKAYAGİTbutton.Name = "ARKAYAGİTbutton";
            ARKAYAGİTbutton.Size = new Size(279, 129);
            ARKAYAGİTbutton.TabIndex = 2;
            ARKAYAGİTbutton.Text = "ARKAYA GİT";
            ARKAYAGİTbutton.UseVisualStyleBackColor = false;
            ARKAYAGİTbutton.Click += ARKAYAGİTbutton_Click;
            // 
            // ÖNEGİTbutton
            // 
            ÖNEGİTbutton.BackColor = SystemColors.GradientActiveCaption;
            ÖNEGİTbutton.Dock = DockStyle.Left;
            ÖNEGİTbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ÖNEGİTbutton.Location = new Point(0, 0);
            ÖNEGİTbutton.Name = "ÖNEGİTbutton";
            ÖNEGİTbutton.Size = new Size(287, 129);
            ÖNEGİTbutton.TabIndex = 1;
            ÖNEGİTbutton.Text = "ÖNE GİT";
            ÖNEGİTbutton.UseVisualStyleBackColor = false;
            ÖNEGİTbutton.Click += ÖNEGİTbutton_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(0, 129);
            button1.Name = "button1";
            button1.Size = new Size(566, 52);
            button1.TabIndex = 0;
            button1.Text = "IŞIKLARI AÇ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 564);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ısıkpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucakpictureBox).EndInit();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox ucakpictureBox;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private PictureBox ısıkpictureBox;
        private Panel panel6;
        private Panel panel7;
        private Button ARKAYAGİTbutton;
        private Button ÖNEGİTbutton;
        private Button button1;
        private UserControl1 userControl11;
        private System.Windows.Forms.Timer timer1;
    }
}
