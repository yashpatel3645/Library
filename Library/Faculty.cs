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
    public partial class Faculty : Form
    {
        public Faculty()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fname.Text == "")
            {
                MessageBox.Show("Please Enter Name.");
            }
            else if (contect.Text == "")
            {
                MessageBox.Show("Please Enter Contect Number.");
            }
            else if (email.Text == "")
            {
                MessageBox.Show("Please Enter Email.");
            }
            else if (Department.SelectedIndex == null)
            {
                MessageBox.Show("Please Select Department.");
            }
            else if (college.SelectedIndex == null)
            {
                MessageBox.Show("Please Select College.");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand sc = new SqlCommand("INSERT INTO FACULTYREGI(NAME,DEPARTMENT,CONTECT,EMAIL,COLLEGE) VALUES('" + fname.Text + "','" + Department.SelectedItem.ToString() + "','" + contect.Text + "','" + email.Text + "','" + college.SelectedItem.ToString() + "')", con);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Registeration Succesfully.");
                    SqlCommand scm = new SqlCommand("SELECT FID FROM FACULTYREGI WHERE CONTECT = '" + contect.Text + "'", con);
                    SqlDataReader dr = scm.ExecuteReader();
                    while (dr.Read())
                    {
                        fid.Text = dr["FID"].ToString();
                    }
                }
                catch (Exception ep)
                {
                    MessageBox.Show("Already Registerd.");
                }
            }
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            Department.SelectedIndex = 0;
            college.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}