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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sname.Text == "")
            {
                MessageBox.Show("Please Enter Student Name Properly.");
            }
            else if (eno.Text == "" || eno.TextLength < 12)
            {
                MessageBox.Show("Please Enter Enrollment Number Properly.");
            }
            else if (contect.Text == "" || contect.TextLength < 10)
            {
                MessageBox.Show("Please Enter Contect Number Properly.");
            }
            else if (email.Text == "")
            {
                MessageBox.Show("Please Enter Email.");
            }
            else if (classs.Text == "")
            {
                MessageBox.Show("Please Enter Class Number");
            }
            else if (branch.SelectedItem == null)
            {
                MessageBox.Show("Please Select Branch.");
            }
            else if (semester.SelectedItem == null)
            {
                MessageBox.Show("Please select Semester.");
            }
            else if (college.SelectedItem == null)
            {
                MessageBox.Show("Please Select College");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand sc = new SqlCommand("insert into studentregi(Name,Enrollment,Branch,Semester,class,college,Contect,email) values('" + sname.Text + "','" + eno.Text + "','" + branch.SelectedItem.ToString() + "','" + semester.SelectedItem.ToString() + "','" + classs.Text + "','" + college.SelectedItem.ToString() + "','" + contect.Text + "','" + email.Text + "')", con);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Saved", "saved", MessageBoxButtons.OK);
                    SqlCommand com = new SqlCommand("select * from studentregi where enrollment='" + eno.Text + "'", con);
                    SqlDataReader read = com.ExecuteReader();
                    while (read.Read())
                    {
                        sid.Text = read["sid"].ToString();
                    }
                }
                catch (Exception ep)
                {
                    MessageBox.Show("Student is already registred.");
                }
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            classs.Text = "";
            sid.Text = "";
            eno.Text = "";
            sname.Text = "";
            branch.SelectedIndex = 0;
            semester.SelectedIndex = 0;
            college.SelectedIndex = 0;
            contect.Text = "";
            email.Text = "";
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            branch.SelectedIndex = 0;
            semester.SelectedIndex = 0;
            college.SelectedIndex = 0;
        }
    }
}
