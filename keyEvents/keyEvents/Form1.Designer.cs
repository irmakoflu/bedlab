namespace keyEvents
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
            label1 = new Label();
            progressBar1 = new ProgressBar();
            arttırbutton = new Button();
            azaltbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(328, 216);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(22, 32);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(766, 29);
            progressBar1.Step = 0;
            progressBar1.TabIndex = 1;
            progressBar1.Value = 10;
            // 
            // arttırbutton
            // 
            arttırbutton.Location = new Point(95, 67);
            arttırbutton.Name = "arttırbutton";
            arttırbutton.Size = new Size(94, 29);
            arttırbutton.TabIndex = 2;
            arttırbutton.Text = "+";
            arttırbutton.UseVisualStyleBackColor = true;
            arttırbutton.Click += arttırbutton_Click;
            // 
            // azaltbutton
            // 
            azaltbutton.Location = new Point(613, 67);
            azaltbutton.Name = "azaltbutton";
            azaltbutton.Size = new Size(94, 29);
            azaltbutton.TabIndex = 3;
            azaltbutton.Text = "-";
            azaltbutton.UseVisualStyleBackColor = true;
            azaltbutton.Click += azaltbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(azaltbutton);
            Controls.Add(arttırbutton);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private Button arttırbutton;
        private Button azaltbutton;
    }
}
