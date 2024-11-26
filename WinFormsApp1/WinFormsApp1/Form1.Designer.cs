namespace WinFormsApp1
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
            mailtextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            girişbutonu = new Button();
            girişkontrolpaneli = new Panel();
            sonuclabeli = new Label();
            girişkontrolpaneli.SuspendLayout();
            SuspendLayout();
            // 
            // mailtextbox
            // 
            mailtextbox.BackColor = SystemColors.Info;
            mailtextbox.Location = new Point(139, 105);
            mailtextbox.Name = "mailtextbox";
            mailtextbox.Size = new Size(371, 27);
            mailtextbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 51);
            label1.Name = "label1";
            label1.Size = new Size(85, 27);
            label1.TabIndex = 1;
            label1.Text = "GİRİŞ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(62, 105);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 2;
            label2.Text = "mail:";
            // 
            // girişbutonu
            // 
            girişbutonu.Location = new Point(139, 138);
            girişbutonu.Name = "girişbutonu";
            girişbutonu.Size = new Size(371, 29);
            girişbutonu.TabIndex = 3;
            girişbutonu.Text = "giriş";
            girişbutonu.UseVisualStyleBackColor = true;
            girişbutonu.Click += girişbutonu_Click;
            // 
            // girişkontrolpaneli
            // 
            girişkontrolpaneli.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            girişkontrolpaneli.BackColor = Color.LightCoral;
            girişkontrolpaneli.Controls.Add(sonuclabeli);
            girişkontrolpaneli.Location = new Point(160, 185);
            girişkontrolpaneli.Name = "girişkontrolpaneli";
            girişkontrolpaneli.Size = new Size(329, 70);
            girişkontrolpaneli.TabIndex = 4;
            // 
            // sonuclabeli
            // 
            sonuclabeli.AutoSize = true;
            sonuclabeli.Location = new Point(130, 23);
            sonuclabeli.Name = "sonuclabeli";
            sonuclabeli.Size = new Size(0, 20);
            sonuclabeli.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(541, 450);
            Controls.Add(girişkontrolpaneli);
            Controls.Add(girişbutonu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mailtextbox);
            Name = "Form1";
            Text = "Form1";
            girişkontrolpaneli.ResumeLayout(false);
            girişkontrolpaneli.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox mailtextbox;
        private Label label1;
        private Label label2;
        private Button girişbutonu;
        private Panel girişkontrolpaneli;
        private Label sonuclabeli;
    }
}
