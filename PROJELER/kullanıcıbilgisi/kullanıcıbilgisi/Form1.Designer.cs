namespace kullanıcıbilgisi
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
            bilgiler = new ListBox();
            adtextBox = new TextBox();
            soyadtextBox = new TextBox();
            yasmaskedTextBox = new MaskedTextBox();
            adlabel = new Label();
            soyadlabel = new Label();
            yaslabel = new Label();
            kaydetbutton = new Button();
            baslıklabel = new Label();
            SuspendLayout();
            // 
            // bilgiler
            // 
            bilgiler.FormattingEnabled = true;
            bilgiler.Location = new Point(40, 285);
            bilgiler.Name = "bilgiler";
            bilgiler.Size = new Size(338, 104);
            bilgiler.TabIndex = 0;
            // 
            // adtextBox
            // 
            adtextBox.Location = new Point(122, 100);
            adtextBox.Name = "adtextBox";
            adtextBox.Size = new Size(125, 27);
            adtextBox.TabIndex = 1;
            // 
            // soyadtextBox
            // 
            soyadtextBox.Location = new Point(122, 139);
            soyadtextBox.Name = "soyadtextBox";
            soyadtextBox.Size = new Size(125, 27);
            soyadtextBox.TabIndex = 2;
            // 
            // yasmaskedTextBox
            // 
            yasmaskedTextBox.Location = new Point(122, 181);
            yasmaskedTextBox.Mask = "000";
            yasmaskedTextBox.Name = "yasmaskedTextBox";
            yasmaskedTextBox.Size = new Size(125, 27);
            yasmaskedTextBox.TabIndex = 3;
            yasmaskedTextBox.ValidatingType = typeof(int);
            // 
            // adlabel
            // 
            adlabel.AutoSize = true;
            adlabel.Font = new Font("Stencil", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            adlabel.Location = new Point(40, 103);
            adlabel.Name = "adlabel";
            adlabel.Size = new Size(39, 21);
            adlabel.TabIndex = 4;
            adlabel.Text = "ad:";
            // 
            // soyadlabel
            // 
            soyadlabel.AutoSize = true;
            soyadlabel.Font = new Font("Stencil", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            soyadlabel.Location = new Point(40, 145);
            soyadlabel.Name = "soyadlabel";
            soyadlabel.Size = new Size(71, 21);
            soyadlabel.TabIndex = 5;
            soyadlabel.Text = "soyad:";
            // 
            // yaslabel
            // 
            yaslabel.AutoSize = true;
            yaslabel.Font = new Font("Stencil", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            yaslabel.Location = new Point(40, 184);
            yaslabel.Name = "yaslabel";
            yaslabel.Size = new Size(46, 21);
            yaslabel.TabIndex = 6;
            yaslabel.Text = "yaş:";
            yaslabel.Click += label3_Click;
            // 
            // kaydetbutton
            // 
            kaydetbutton.BackColor = Color.Pink;
            kaydetbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kaydetbutton.Location = new Point(40, 239);
            kaydetbutton.Name = "kaydetbutton";
            kaydetbutton.Size = new Size(338, 29);
            kaydetbutton.TabIndex = 7;
            kaydetbutton.Text = "kaydet";
            kaydetbutton.UseVisualStyleBackColor = false;
            kaydetbutton.Click += kaydetbutton_Click;
            // 
            // baslıklabel
            // 
            baslıklabel.AutoSize = true;
            baslıklabel.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            baslıklabel.Location = new Point(79, 23);
            baslıklabel.Name = "baslıklabel";
            baslıklabel.Size = new Size(229, 29);
            baslıklabel.TabIndex = 8;
            baslıklabel.Text = "kullanıcı bilgisi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(395, 450);
            Controls.Add(baslıklabel);
            Controls.Add(kaydetbutton);
            Controls.Add(yaslabel);
            Controls.Add(soyadlabel);
            Controls.Add(adlabel);
            Controls.Add(yasmaskedTextBox);
            Controls.Add(soyadtextBox);
            Controls.Add(adtextBox);
            Controls.Add(bilgiler);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox bilgiler;
        private TextBox adtextBox;
        private TextBox soyadtextBox;
        private MaskedTextBox yasmaskedTextBox;
        private Label adlabel;
        private Label soyadlabel;
        private Label yaslabel;
        private Button kaydetbutton;
        private Label baslıklabel;
    }
}
