﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userControl
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yeşil");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("gri");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mavi");
        }
    }
}
