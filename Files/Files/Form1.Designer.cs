namespace Files
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
            fileNameTextBox = new RichTextBox();
            fileExtensionTextBox = new RichTextBox();
            fileCreatorbutton = new Button();
            SuspendLayout();
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.BackColor = Color.FromArgb(42, 42, 42);
            fileNameTextBox.BorderStyle = BorderStyle.None;
            fileNameTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            fileNameTextBox.ForeColor = Color.FromArgb(244, 244, 244);
            fileNameTextBox.Location = new Point(12, 12);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.Size = new Size(402, 87);
            fileNameTextBox.TabIndex = 0;
            fileNameTextBox.Text = "Dosya Adı:";
            // 
            // fileExtensionTextBox
            // 
            fileExtensionTextBox.BackColor = Color.FromArgb(42, 42, 42);
            fileExtensionTextBox.BorderStyle = BorderStyle.None;
            fileExtensionTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            fileExtensionTextBox.ForeColor = Color.FromArgb(244, 244, 244);
            fileExtensionTextBox.Location = new Point(12, 105);
            fileExtensionTextBox.Name = "fileExtensionTextBox";
            fileExtensionTextBox.Size = new Size(402, 87);
            fileExtensionTextBox.TabIndex = 1;
            fileExtensionTextBox.Text = "Dosya Uzantısı:";
            // 
            // fileCreatorbutton
            // 
            fileCreatorbutton.BackColor = Color.FromArgb(42, 42, 42);
            fileCreatorbutton.FlatAppearance.BorderSize = 0;
            fileCreatorbutton.FlatStyle = FlatStyle.Flat;
            fileCreatorbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            fileCreatorbutton.ForeColor = Color.FromArgb(244, 244, 244);
            fileCreatorbutton.Location = new Point(12, 198);
            fileCreatorbutton.Name = "fileCreatorbutton";
            fileCreatorbutton.Size = new Size(402, 39);
            fileCreatorbutton.TabIndex = 2;
            fileCreatorbutton.Text = "O L U Ş T U R";
            fileCreatorbutton.UseVisualStyleBackColor = false;
            fileCreatorbutton.Click += fileCreatorbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 249);
            Controls.Add(fileCreatorbutton);
            Controls.Add(fileExtensionTextBox);
            Controls.Add(fileNameTextBox);
            Name = "Form1";
            Text = "File Creator";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox fileNameTextBox;
        private RichTextBox fileExtensionTextBox;
        private Button fileCreatorbutton;
    }
}
