namespace MouseLeaveEvent
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
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Salmon;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 125);
            panel1.TabIndex = 0;
            panel1.MouseLeave += panel1_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.Location = new Point(12, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(308, 125);
            panel2.TabIndex = 1;
            panel2.MouseLeave += panel2_MouseLeave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSalmon;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(12, 274);
            panel3.Name = "panel3";
            panel3.Size = new Size(308, 125);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            panel3.MouseLeave += panel3_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 425);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
