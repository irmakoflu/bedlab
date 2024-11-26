namespace NumericUpDown
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
            firstnumbernumericUpDown = new System.Windows.Forms.NumericUpDown();
            secondnumbernumericUpDown = new System.Windows.Forms.NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)firstnumbernumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondnumbernumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // firstnumbernumericUpDown
            // 
            firstnumbernumericUpDown.Location = new Point(12, 45);
            firstnumbernumericUpDown.Name = "firstnumbernumericUpDown";
            firstnumbernumericUpDown.Size = new Size(243, 27);
            firstnumbernumericUpDown.TabIndex = 0;
            // 
            // secondnumbernumericUpDown
            // 
            secondnumbernumericUpDown.Location = new Point(12, 124);
            secondnumbernumericUpDown.Name = "secondnumbernumericUpDown";
            secondnumbernumericUpDown.Size = new Size(243, 27);
            secondnumbernumericUpDown.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 17);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 2;
            label1.Text = "first number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 3;
            label2.Text = "second number:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 168);
            button1.Name = "button1";
            button1.Size = new Size(243, 42);
            button1.TabIndex = 4;
            button1.Text = "topla ve yazdır";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 233);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(secondnumbernumericUpDown);
            Controls.Add(firstnumbernumericUpDown);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)firstnumbernumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondnumbernumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown firstnumbernumericUpDown;
        private System.Windows.Forms.NumericUpDown secondnumbernumericUpDown;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
