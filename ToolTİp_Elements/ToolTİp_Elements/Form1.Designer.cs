namespace ToolTİp_Elements
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            textboxtoolTip = new ToolTip(components);
            buttontoolTip = new ToolTip(components);
            listboxtoolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 62);
            button1.Name = "button1";
            button1.Size = new Size(376, 62);
            button1.TabIndex = 0;
            button1.Text = "button1";
            buttontoolTip.SetToolTip(button1, "bu bir button.");
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 27);
            textBox1.TabIndex = 2;
            textboxtoolTip.SetToolTip(textBox1, "bu bir textbox.");
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 145);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(376, 284);
            listBox1.TabIndex = 3;
            listboxtoolTip.SetToolTip(listBox1, "bu bir listbox");
            // 
            // textboxtoolTip
            // 
            textboxtoolTip.ToolTipTitle = "textbox:)";
            // 
            // buttontoolTip
            // 
            buttontoolTip.ToolTipTitle = "button:)";
            buttontoolTip.Popup += toolTip2_Popup;
            // 
            // listboxtoolTip
            // 
            listboxtoolTip.ToolTipTitle = "listbox:)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 450);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private ListBox listBox1;
        private ToolTip textboxtoolTip;
        private ToolTip buttontoolTip;
        private ToolTip listboxtoolTip;
    }
}
