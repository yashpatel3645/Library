﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void open(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form8 f = new Form8();
            f.Show();
        }

        private void open2(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form9 f = new Form9();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
