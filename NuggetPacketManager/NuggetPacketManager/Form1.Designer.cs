namespace NuggetPacketManager
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
            gotoURLbutton = new Button();
            URLtextBox = new TextBox();
            SuspendLayout();
            // 
            // gotoURLbutton
            // 
            gotoURLbutton.Location = new Point(109, 55);
            gotoURLbutton.Name = "gotoURLbutton";
            gotoURLbutton.Size = new Size(262, 29);
            gotoURLbutton.TabIndex = 0;
            gotoURLbutton.Text = "Go To URL";
            gotoURLbutton.UseVisualStyleBackColor = true;
            gotoURLbutton.Click += button1_Click;
            // 
            // URLtextBox
            // 
            URLtextBox.ForeColor = SystemColors.InactiveCaption;
            URLtextBox.Location = new Point(12, 22);
            URLtextBox.Name = "URLtextBox";
            URLtextBox.Size = new Size(359, 27);
            URLtextBox.TabIndex = 1;
            URLtextBox.Text = "URL-->";
            URLtextBox.Click += URLtextBox_Click;
            URLtextBox.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 92);
            Controls.Add(URLtextBox);
            Controls.Add(gotoURLbutton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button gotoURLbutton;
        private TextBox URLtextBox;
    }
}
