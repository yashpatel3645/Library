using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =c:\users\king_heart\documents\visual studio 2015\Projects\Library\Library\Login.mdf; Integrated Security = True");
                con.Open();
                String Userid = textBox1.Text;
                String password = textBox2.Text;
                SqlDataAdapter sq = new SqlDataAdapter("SELECT * FROM LOGIN WHERE USERID='" + textBox1.Text + "' AND PASSWORD='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sq.Fill(dt);
                if (dt.Rows.Count >0)
                {
                    this.Hide();
                    Form7 ep = new Form7();
                    ep.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect User ID OR Password");
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "yash";
            textBox2.Text = "1234";
        }

        private void reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 f = new Form12();
            f.Show();
        }
    }
}
