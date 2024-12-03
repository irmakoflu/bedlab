namespace Files2
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
            readbutton = new Button();
            filecontentrichtextbox = new RichTextBox();
            SuspendLayout();
            // 
            // readbutton
            // 
            readbutton.BackColor = Color.FromArgb(52, 52, 52);
            readbutton.FlatAppearance.BorderSize = 0;
            readbutton.FlatStyle = FlatStyle.Flat;
            readbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            readbutton.ForeColor = Color.White;
            readbutton.Location = new Point(12, 325);
            readbutton.Name = "readbutton";
            readbutton.Size = new Size(309, 36);
            readbutton.TabIndex = 0;
            readbutton.Text = "R E A D  F İ L E";
            readbutton.UseVisualStyleBackColor = false;
            readbutton.Click += readbutton_Click;
            // 
            // filecontentrichtextbox
            // 
            filecontentrichtextbox.BackColor = Color.White;
            filecontentrichtextbox.Location = new Point(14, 12);
            filecontentrichtextbox.Name = "filecontentrichtextbox";
            filecontentrichtextbox.Size = new Size(307, 302);
            filecontentrichtextbox.TabIndex = 1;
            filecontentrichtextbox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 373);
            Controls.Add(filecontentrichtextbox);
            Controls.Add(readbutton);
            Name = "Form1";
            Text = "FİLE READİNG";
            ResumeLayout(false);
        }

        #endregion

        private Button readbutton;
        private RichTextBox filecontentrichtextbox;
    }
}
