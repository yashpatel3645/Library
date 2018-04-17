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
            if(userid.Text == "")
            {
                MessageBox.Show("Please Enter Udername.");
            }
            else if (pass.Text == "")
            {
                MessageBox.Show("Please Enter Password.");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                    con.Open();
                    String Userid = userid.Text;
                    String password = pass.Text;
                    SqlDataAdapter sq = new SqlDataAdapter("SELECT * FROM LOGIN WHERE USERID='" + userid.Text + "' AND PASSWORD='" + this.pass.Text + "'", con);
                    DataTable dt = new DataTable();
                    sq.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        //   this.Hide();
                        //  Form7 ep = new Form7();
                        //  ep.Show();
                        this.Hide();
                        MDIParent1 f = new MDIParent1();
                        f.Show();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect User ID OR Password");
                    }

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userid.Text = "yash";
            pass.Text = "1234";
        }

        private void reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 f = new Form12();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 f = new Form15();
            f.Show();
        }
    }
}
