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
            if (uid.Text == "")
            {
                MessageBox.Show("Please Enter Username.");
            }
            else if (pass.Text == "")
            {
                MessageBox.Show("Please Enter Password.");
            }
            else if (a1.Text == "")
            {
                MessageBox.Show("Please Enter Answer Of First Question.");
            }
            else if (pass.Text == "")
            {
                MessageBox.Show("Please Enter Answer Of Second Question.");
            }
            else if (sq1.SelectedIndex == null)
            {
                MessageBox.Show("Please Select Security Question 1");
            }
            else if (sq2.SelectedIndex == null)
            {
                MessageBox.Show("Please Select Security Question 2");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand sc = new SqlCommand("insert into Login(Userid,password,q1,a1,q2,a2) values('" + uid.Text + "','" + pass.Text + "','" + sq1.SelectedItem.ToString() + "','" + a1.Text + "','" + sq2.SelectedItem.ToString() + "','" + a2.Text + "')", con);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Registration Successfully.");
                    uid.Text = "";
                    pass.Text = "";
                    a1.Text = "";
                    a2.Text = "";
                    sq1.SelectedIndex = 0;
                    sq2.SelectedIndex = 0;
                }
                catch (Exception ep)
                {
                    MessageBox.Show(ep.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            sq1.SelectedIndex = 0;
            sq2.SelectedIndex = 0;

        }
    }
}
