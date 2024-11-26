namespace box
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            number2maskedTextBox = new MaskedTextBox();
            number1maskedTextBox = new MaskedTextBox();
            groupBox2 = new GroupBox();
            pickedoperatorcomboBox = new ComboBox();
            groupBox3 = new GroupBox();
            resultslistBox = new ListBox();
            processbutton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(number2maskedTextBox);
            groupBox1.Controls.Add(number1maskedTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 110);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "sayılar";
            // 
            // number2maskedTextBox
            // 
            number2maskedTextBox.Location = new Point(6, 59);
            number2maskedTextBox.Mask = "00000000";
            number2maskedTextBox.Name = "number2maskedTextBox";
            number2maskedTextBox.Size = new Size(347, 27);
            number2maskedTextBox.TabIndex = 1;
            number2maskedTextBox.ValidatingType = typeof(int);
            // 
            // number1maskedTextBox
            // 
            number1maskedTextBox.Location = new Point(6, 26);
            number1maskedTextBox.Mask = "00000000";
            number1maskedTextBox.Name = "number1maskedTextBox";
            number1maskedTextBox.Size = new Size(347, 27);
            number1maskedTextBox.TabIndex = 0;
            number1maskedTextBox.ValidatingType = typeof(int);
            number1maskedTextBox.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pickedoperatorcomboBox);
            groupBox2.Location = new Point(12, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 71);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operatör";
            // 
            // pickedoperatorcomboBox
            // 
            pickedoperatorcomboBox.FormattingEnabled = true;
            pickedoperatorcomboBox.Items.AddRange(new object[] { "/", "*", "-", "+" });
            pickedoperatorcomboBox.Location = new Point(6, 26);
            pickedoperatorcomboBox.Name = "pickedoperatorcomboBox";
            pickedoperatorcomboBox.Size = new Size(347, 28);
            pickedoperatorcomboBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(resultslistBox);
            groupBox3.Location = new Point(12, 231);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(359, 124);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sonuçlar";
            // 
            // resultslistBox
            // 
            resultslistBox.FormattingEnabled = true;
            resultslistBox.Location = new Point(6, 26);
            resultslistBox.Name = "resultslistBox";
            resultslistBox.Size = new Size(341, 84);
            resultslistBox.TabIndex = 0;
            // 
            // processbutton
            // 
            processbutton.BackColor = Color.Lime;
            processbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            processbutton.Location = new Point(277, 205);
            processbutton.Name = "processbutton";
            processbutton.Size = new Size(94, 29);
            processbutton.TabIndex = 3;
            processbutton.Text = "işlemi yap";
            processbutton.UseVisualStyleBackColor = false;
            processbutton.Click += processbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(383, 364);
            Controls.Add(processbutton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private MaskedTextBox number2maskedTextBox;
        private MaskedTextBox number1maskedTextBox;
        private GroupBox groupBox2;
        private ComboBox pickedoperatorcomboBox;
        private GroupBox groupBox3;
        private ListBox resultslistBox;
        private Button processbutton;
    }
}
