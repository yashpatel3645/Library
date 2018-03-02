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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f = new Form9();
            f.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (bookid.Text == "")
            {
                MessageBox.Show("Please Enter Book ID Properly.");
            }
            else if (sname.Text == "")
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
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\King_Heart\documents\visual studio 2015\Projects\Library\Library\Studentdetail.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand sc = new SqlCommand("INSERT INTO student1(bookid,sname,enrollment,branch,semester,contect,issuedate,subdate) VALUES('" + bookid.Text + "','" + sname.Text + "','" + eno.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + comboBox2.SelectedItem.ToString() + "','" + contect.Text + "','" + dateTimePicker1.Value.Date + "','" + dateTimePicker2.Value.Date + "')", con);
                    sc.ExecuteNonQuery();

                    MessageBox.Show("Book Issued.");
                }
                catch (Exception ep)
                {
                    MessageBox.Show("Book is already issue by another person.");
                }
            }
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
    }
}
