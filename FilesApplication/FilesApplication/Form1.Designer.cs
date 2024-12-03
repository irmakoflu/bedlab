namespace FilesApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            listfilesbutton = new Button();
            panel3 = new Panel();
            addfilebutton = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            removefilebutton = new Button();
            phpbutton = new Button();
            panel6 = new Panel();
            cssbutton = new Button();
            panel7 = new Panel();
            htmlbutton = new Button();
            panel8 = new Panel();
            jsbutton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 77);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(161, 187, 215);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(86, 140, 238);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(393, 77);
            label1.TabIndex = 0;
            label1.Text = "P A P E R M A N";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(125, 148, 238);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(393, 2);
            panel2.TabIndex = 1;
            // 
            // listfilesbutton
            // 
            listfilesbutton.BackColor = Color.FromArgb(161, 187, 215);
            listfilesbutton.Dock = DockStyle.Top;
            listfilesbutton.FlatAppearance.BorderSize = 0;
            listfilesbutton.FlatStyle = FlatStyle.Flat;
            listfilesbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listfilesbutton.ForeColor = Color.BlueViolet;
            listfilesbutton.Image = Resource1.File;
            listfilesbutton.ImageAlign = ContentAlignment.MiddleRight;
            listfilesbutton.Location = new Point(0, 79);
            listfilesbutton.Name = "listfilesbutton";
            listfilesbutton.Padding = new Padding(15, 0, 15, 0);
            listfilesbutton.Size = new Size(393, 63);
            listfilesbutton.TabIndex = 1;
            listfilesbutton.Text = "List Files";
            listfilesbutton.TextAlign = ContentAlignment.MiddleLeft;
            listfilesbutton.UseVisualStyleBackColor = false;
            listfilesbutton.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(125, 148, 238);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(393, 2);
            panel3.TabIndex = 2;
            // 
            // addfilebutton
            // 
            addfilebutton.BackColor = Color.FromArgb(161, 187, 215);
            addfilebutton.Dock = DockStyle.Top;
            addfilebutton.FlatAppearance.BorderSize = 0;
            addfilebutton.FlatStyle = FlatStyle.Flat;
            addfilebutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            addfilebutton.ForeColor = Color.BlueViolet;
            addfilebutton.Image = Resource1.Insert_Page;
            addfilebutton.ImageAlign = ContentAlignment.MiddleRight;
            addfilebutton.Location = new Point(0, 144);
            addfilebutton.Name = "addfilebutton";
            addfilebutton.Padding = new Padding(15, 0, 15, 0);
            addfilebutton.Size = new Size(393, 61);
            addfilebutton.TabIndex = 3;
            addfilebutton.Text = "Add File";
            addfilebutton.TextAlign = ContentAlignment.MiddleLeft;
            addfilebutton.UseVisualStyleBackColor = false;
            addfilebutton.Click += addfilebutton_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(125, 148, 238);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 205);
            panel4.Name = "panel4";
            panel4.Size = new Size(393, 2);
            panel4.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(125, 148, 238);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 268);
            panel5.Name = "panel5";
            panel5.Size = new Size(393, 22);
            panel5.TabIndex = 6;
            // 
            // removefilebutton
            // 
            removefilebutton.BackColor = Color.FromArgb(161, 187, 215);
            removefilebutton.Dock = DockStyle.Top;
            removefilebutton.FlatAppearance.BorderSize = 0;
            removefilebutton.FlatStyle = FlatStyle.Flat;
            removefilebutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            removefilebutton.ForeColor = Color.BlueViolet;
            removefilebutton.Image = Resource1.Delete_File;
            removefilebutton.ImageAlign = ContentAlignment.MiddleRight;
            removefilebutton.Location = new Point(0, 207);
            removefilebutton.Name = "removefilebutton";
            removefilebutton.Padding = new Padding(15, 0, 15, 0);
            removefilebutton.Size = new Size(393, 61);
            removefilebutton.TabIndex = 5;
            removefilebutton.Text = "Remove File";
            removefilebutton.TextAlign = ContentAlignment.MiddleLeft;
            removefilebutton.UseVisualStyleBackColor = false;
            removefilebutton.Click += button3_Click_1;
            // 
            // phpbutton
            // 
            phpbutton.BackColor = Color.FromArgb(161, 187, 215);
            phpbutton.Dock = DockStyle.Top;
            phpbutton.FlatAppearance.BorderSize = 0;
            phpbutton.FlatStyle = FlatStyle.Flat;
            phpbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            phpbutton.ForeColor = Color.BlueViolet;
            phpbutton.Image = Resource1.PHP;
            phpbutton.ImageAlign = ContentAlignment.MiddleRight;
            phpbutton.Location = new Point(0, 418);
            phpbutton.Name = "phpbutton";
            phpbutton.Padding = new Padding(15, 0, 15, 0);
            phpbutton.Size = new Size(393, 61);
            phpbutton.TabIndex = 11;
            phpbutton.Text = "PHP File";
            phpbutton.TextAlign = ContentAlignment.MiddleLeft;
            phpbutton.UseVisualStyleBackColor = false;
            phpbutton.Click += phpbutton_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(125, 148, 238);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 416);
            panel6.Name = "panel6";
            panel6.Size = new Size(393, 2);
            panel6.TabIndex = 10;
            // 
            // cssbutton
            // 
            cssbutton.BackColor = Color.FromArgb(161, 187, 215);
            cssbutton.Dock = DockStyle.Top;
            cssbutton.FlatAppearance.BorderSize = 0;
            cssbutton.FlatStyle = FlatStyle.Flat;
            cssbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cssbutton.ForeColor = Color.BlueViolet;
            cssbutton.Image = Resource1.CSS;
            cssbutton.ImageAlign = ContentAlignment.MiddleRight;
            cssbutton.Location = new Point(0, 355);
            cssbutton.Name = "cssbutton";
            cssbutton.Padding = new Padding(15, 0, 15, 0);
            cssbutton.Size = new Size(393, 61);
            cssbutton.TabIndex = 9;
            cssbutton.Text = "CSS File";
            cssbutton.TextAlign = ContentAlignment.MiddleLeft;
            cssbutton.UseVisualStyleBackColor = false;
            cssbutton.Click += cssbutton_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(125, 148, 238);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 353);
            panel7.Name = "panel7";
            panel7.Size = new Size(393, 2);
            panel7.TabIndex = 8;
            // 
            // htmlbutton
            // 
            htmlbutton.BackColor = Color.FromArgb(161, 187, 215);
            htmlbutton.Dock = DockStyle.Top;
            htmlbutton.FlatAppearance.BorderSize = 0;
            htmlbutton.FlatStyle = FlatStyle.Flat;
            htmlbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            htmlbutton.ForeColor = Color.BlueViolet;
            htmlbutton.Image = Resource1.HTML;
            htmlbutton.ImageAlign = ContentAlignment.MiddleRight;
            htmlbutton.Location = new Point(0, 290);
            htmlbutton.Name = "htmlbutton";
            htmlbutton.Padding = new Padding(15, 0, 15, 0);
            htmlbutton.Size = new Size(393, 63);
            htmlbutton.TabIndex = 7;
            htmlbutton.Text = "HTML File";
            htmlbutton.TextAlign = ContentAlignment.MiddleLeft;
            htmlbutton.UseVisualStyleBackColor = false;
            htmlbutton.Click += htmlbutton_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(125, 148, 238);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 479);
            panel8.Name = "panel8";
            panel8.Size = new Size(393, 2);
            panel8.TabIndex = 12;
            // 
            // jsbutton
            // 
            jsbutton.BackColor = Color.FromArgb(161, 187, 215);
            jsbutton.Dock = DockStyle.Top;
            jsbutton.FlatAppearance.BorderSize = 0;
            jsbutton.FlatStyle = FlatStyle.Flat;
            jsbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            jsbutton.ForeColor = Color.BlueViolet;
            jsbutton.Image = Resource1.JS;
            jsbutton.ImageAlign = ContentAlignment.MiddleRight;
            jsbutton.Location = new Point(0, 481);
            jsbutton.Name = "jsbutton";
            jsbutton.Padding = new Padding(15, 0, 15, 0);
            jsbutton.Size = new Size(393, 61);
            jsbutton.TabIndex = 13;
            jsbutton.Text = "JS File";
            jsbutton.TextAlign = ContentAlignment.MiddleLeft;
            jsbutton.UseVisualStyleBackColor = false;
            jsbutton.Click += jsbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(393, 541);
            Controls.Add(jsbutton);
            Controls.Add(panel8);
            Controls.Add(phpbutton);
            Controls.Add(panel6);
            Controls.Add(cssbutton);
            Controls.Add(panel7);
            Controls.Add(htmlbutton);
            Controls.Add(panel5);
            Controls.Add(removefilebutton);
            Controls.Add(panel4);
            Controls.Add(addfilebutton);
            Controls.Add(panel3);
            Controls.Add(listfilesbutton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paperman";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button listfilesbutton;
        private Panel panel3;
        private Button addfilebutton;
        private Panel panel4;
        private Panel panel5;
        private Button removefilebutton;
        private Button phpbutton;
        private Panel panel6;
        private Button cssbutton;
        private Panel panel7;
        private Button htmlbutton;
        private Panel panel8;
        private Button jsbutton;
    }
}
