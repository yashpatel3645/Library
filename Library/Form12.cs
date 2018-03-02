using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\King_Heart\documents\visual studio 2015\Projects\Library\Library\Login.mdf;Integrated Security=True");
                con.Open();
                SqlCommand sc = new SqlCommand("insert into Login(Userid,password) values('" + textBox1.Text + "','" + textBox2.Text + "')", con);
                sc.ExecuteNonQuery();
                MessageBox.Show("Registration Successfully.");
            }
            catch(Exception ep)
            {
                MessageBox.Show(ep.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
