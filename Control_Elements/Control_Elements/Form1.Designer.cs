namespace Control_Elements
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
            teknolojichecktbox = new CheckBox();
            sporcheckbox = new CheckBox();
            müzikcheckbox = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            kaydetbutton = new Button();
            SuspendLayout();
            // 
            // teknolojichecktbox
            // 
            teknolojichecktbox.AutoSize = true;
            teknolojichecktbox.Location = new Point(12, 202);
            teknolojichecktbox.Name = "teknolojichecktbox";
            teknolojichecktbox.Size = new Size(104, 24);
            teknolojichecktbox.TabIndex = 0;
            teknolojichecktbox.Text = "TEKNOLOJİ";
            teknolojichecktbox.UseVisualStyleBackColor = true;
            // 
            // sporcheckbox
            // 
            sporcheckbox.AutoSize = true;
            sporcheckbox.Location = new Point(175, 202);
            sporcheckbox.Name = "sporcheckbox";
            sporcheckbox.Size = new Size(67, 24);
            sporcheckbox.TabIndex = 1;
            sporcheckbox.Text = "SPOR";
            sporcheckbox.UseVisualStyleBackColor = true;
            // 
            // müzikcheckbox
            // 
            müzikcheckbox.AutoSize = true;
            müzikcheckbox.Location = new Point(321, 202);
            müzikcheckbox.Name = "müzikcheckbox";
            müzikcheckbox.Size = new Size(76, 24);
            müzikcheckbox.TabIndex = 2;
            müzikcheckbox.Text = "MÜZİK";
            müzikcheckbox.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(66, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "kadın";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 52);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "erkek";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 95);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(65, 24);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "diğer";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // kaydetbutton
            // 
            kaydetbutton.Location = new Point(35, 247);
            kaydetbutton.Name = "kaydetbutton";
            kaydetbutton.Size = new Size(362, 48);
            kaydetbutton.TabIndex = 6;
            kaydetbutton.Text = "KAYDET";
            kaydetbutton.UseVisualStyleBackColor = true;
            kaydetbutton.Click += kaydetbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(449, 338);
            Controls.Add(kaydetbutton);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(müzikcheckbox);
            Controls.Add(sporcheckbox);
            Controls.Add(teknolojichecktbox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox teknolojichecktbox;
        private CheckBox sporcheckbox;
        private CheckBox müzikcheckbox;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button kaydetbutton;
    }
}
