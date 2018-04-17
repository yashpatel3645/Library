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
        private void Form6_Load(object sender, EventArgs e)
        {
            branch.SelectedIndex = 0;
            semester.SelectedIndex = 0;
            college.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            dateTimePicker2.Value = DateTime.Today.AddDays(+10);
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker2.Enabled = false;
        }
        
        private void submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
            con.Open();
            
            if (comboBox1.SelectedItem == "Student")
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
                                SqlCommand sc = new SqlCommand("INSERT INTO studentdetail(bookid,sname,enrollment,branch,semester,contect,issuedate,subdate,class,college,email) VALUES('" + bookid.Text + "','" + sname.Text + "','" + eno.Text + "','" + branch.SelectedItem.ToString() + "','" + semester.SelectedItem.ToString() + "','" + contect.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + classs.Text + "','" + college.SelectedItem.ToString() + "','" + email.Text + "')", con);
                                sc.ExecuteNonQuery();
                                MessageBox.Show("Book Issued.");
                                sname.Text = "";
                                eno.Text = "";
                                classs.Text = "";
                                textBox2.Text = "";
                                contect.Text = "";
                                bookid.Text = "";
                                branch.SelectedIndex = 0;
                                semester.SelectedIndex = 0;
                                college.SelectedIndex = 0;
                            }
                            catch (Exception ep)
                            {
                                MessageBox.Show(ep.ToString());
                            }
                        }
                  }
            if (comboBox1.SelectedItem == "Faculty")
            {
                if (fname.Text == "")
                {
                    MessageBox.Show("Please Enter Faculty Name.");
                }
                else if (fcontect.Text == "")
                {
                    MessageBox.Show("Please Enter Contect Number.");
                }
                else if (femail.Text == "")
                {
                    MessageBox.Show("Please Enter Email.");
                }
                else if (fdepartment.SelectedIndex == null)
                {
                    MessageBox.Show("Please Select Department.");
                }
                else if (fcollege.SelectedIndex == null)
                {
                    MessageBox.Show("Please Select College.");
                }
                else if (fbookid.Text == "")
                {
                    MessageBox.Show("Please Enter Book ID.");
                }
                else
                {
                            try
                            {
                                SqlCommand sc = new SqlCommand("INSERT INTO FACULTYDETAILS(Name,ID,Department,Email,Contect,college,Book_id,issue_date) values ('" + fname.Text + "','" + fid.Text + "','" + fdepartment.SelectedItem.ToString() + "','" + femail.Text + "','" + fcontect.Text + "','" + fcollege.SelectedItem.ToString() + "','" + fbookid.Text + "','" + fissue.Text + "')", con);
                                sc.ExecuteNonQuery();
                                MessageBox.Show("Book Issued.");
                                fid.Text = "";
                                femail.Text = "";
                                fcontect.Text = "";
                                fbookid.Text = "";
                                fdepartment.SelectedIndex = 0;
                                fcollege.SelectedIndex = 0;
                                fname.Text = "";
                            }
                            catch (Exception ep)
                            {
                                MessageBox.Show(ep.ToString());
                            }
                        }
                    
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox4.SelectedItem == "Book")
            {
                panel1.Visible = true;
            }
            if(comboBox4.SelectedItem == "Theses")
            {
                panel1.Visible = false;
            }
            if(comboBox4.SelectedItem == "Magazine")
            {
                panel1.Visible = false;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                con.Open();
                SqlCommand sc = new SqlCommand("Select * from studentregi where sid='" + textBox2.Text + "'", con);
                SqlDataReader dr = sc.ExecuteReader();
                while (dr.Read())
                {
                    
                    sname.Text = dr["Name"].ToString();
                    eno.Text = dr["Enrollment"].ToString();
                    branch.SelectedItem = dr["Branch"].ToString();
                    semester.SelectedItem = dr["Semester"].ToString();
                    college.SelectedItem = dr["college"].ToString();
                    classs.Text = dr["class"].ToString();
                    contect.Text = dr["contect"].ToString();
                    email.Text = dr["email"].ToString();
                }
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == "Student")
            {
                panel1.Visible = true;
                panel2.Visible = false;
                reset1();
            }
            if(comboBox1.SelectedItem == "Faculty")
            {
                panel1.Visible = false;
                panel2.Visible = true;
                reset1();
            }
        }

        void reset1()
        {
            sname.Text = "";
            eno.Text = "";
            classs.Text = "";
            textBox2.Text = "";
            contect.Text = "";
            bookid.Text = "";
            branch.SelectedIndex = 0;
            semester.SelectedIndex = 0;
            college.SelectedIndex = 0;
           
            fid.Text = "";
            fname.Text = "";
            fcontect.Text = "";
            femail.Text = "";
            fbookid.Text = "";
            fdepartment.SelectedIndex = 0;
            fcollege.SelectedIndex = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                con.Open();
                SqlCommand sc = new SqlCommand("select * from facultyregi where fid='"+fid.Text+"'",con);
                SqlDataReader dr = sc.ExecuteReader();
                while(dr.Read())
                {
                    fname.Text = dr["Name"].ToString();
                    fdepartment.SelectedItem = dr["department"].ToString();
                    femail.Text = dr["email"].ToString();
                    fcontect.Text = dr["contect"].ToString();
                    fcollege.SelectedItem = dr["college"].ToString();
                }

                
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.ToString());
            }
        }

        private void button2_Click(object sender, MouseEventArgs e)
        {

        }
    }
}
