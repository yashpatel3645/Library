using System;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void search(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void add(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.Show();
        }

        private void remove(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f = new Form7();
            f.Show();
        }
    }
}
