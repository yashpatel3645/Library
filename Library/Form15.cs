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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select * from Login where Userid='"+textBox1.Text+"'",con);
            SqlDataReader dr = sc.ExecuteReader();
            
            while(dr.Read())
            {
                
                if(dr["Userid"].ToString() == textBox1.Text)
                {
                    if(dr["a1"].ToString() == textBox3.Text)
                        {
                         if(dr["a2"].ToString() == textBox5.Text)
                             {
                                    panel2.Visible = true;
                                    button1.Visible = false;
                             }
                        }    
                }
                else
                {
                    MessageBox.Show("Detail Wrong!!!");
                }
            }
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
            con.Open();
            if (pass.Text == repass.Text)
            {
                SqlCommand sc = new SqlCommand("update Login set password = '"+pass.Text+"' where Userid='"+textBox1.Text+"'", con);
                sc.ExecuteNonQuery();
                MessageBox.Show("Password Updated...");
                panel2.Visible = false;
                textBox1.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
            }
        }
    }
}
