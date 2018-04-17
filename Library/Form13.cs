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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Book")
            {
                panel1.Visible = true;
                branch.SelectedIndex = 0;
                semester.SelectedIndex = 0;
            }
            if (comboBox1.SelectedItem == "Theses")
            {
                panel1.Visible = false;
            }
            if (comboBox1.SelectedItem == "Magazine")
            {
                panel1.Visible = false;
            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            searchby.SelectedIndex = 0;
        }
        
        private void searchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookname.Text = "";
            price.Text = "";
            pname.Text = "";
            isbn.Text = "";
            author.Text = "";
            search.Text = "";
            date.Value = DateTime.Now.Date;
            semester.SelectedIndex = 0;
            branch.SelectedIndex = 0;
            bookid.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bookname.Text = "";
            price.Text = "";
            pname.Text = "";
            isbn.Text = "";
            author.Text = "";
            search.Text = "";
            date.Value = DateTime.Now.Date;
            semester.SelectedIndex = 0;
            branch.SelectedIndex = 0;
            searchby.SelectedIndex = 0;
            bookid.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bookname.Text == "")
            {
                MessageBox.Show("Please Enter Book Name.");
            }
            else if (branch.SelectedIndex == null)
            {
                MessageBox.Show("Please Select Branch.");
            }
            else if (semester.SelectedIndex == null)
            {
                MessageBox.Show("Please Select Semester.");
            }
            else if (author.Text == "")
            {
                MessageBox.Show("Please Enter Author Name.");
            }
            else if (pname.Text == "")
            {
                MessageBox.Show("Please Enter Publication Name.");
            }
            else if (price.Text == "")
            {
                MessageBox.Show("Please Enter Price.");
            }
            else if (isbn.Text == "")
            {
                MessageBox.Show("Please Enter ISBN Number.");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand sc = new SqlCommand("update bookdata set Book_name='" + bookname.Text + "',Auther='" + author.Text + "',Semester='" + semester.SelectedItem.ToString() + "',branch='" + branch.SelectedItem.ToString() + "',pname='" + pname.Text + "',pdate='" + date.Text + "',price='" + price.Text + "',isbn='" + isbn.Text + "' Where Book_ID='" + bookid.Text + "' ", con);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                }
                catch (Exception ep)
                {
                    MessageBox.Show(ep.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
            con.Open();
            if (search.Text == "")
            {
                MessageBox.Show("Please ENter Book ID.");
            }
            else
            {
                if (searchby.SelectedItem == "Book Name")
                {
                    SqlCommand sc = new SqlCommand("select * from bookdata where Book_name='" + search.Text + "'", con);
                    SqlDataReader dr = sc.ExecuteReader();
                    while (dr.Read())
                    {
                        bookname.Text = dr["Book_name"].ToString();
                        author.Text = dr["Auther"].ToString();
                        pname.Text = dr["pname"].ToString();
                        price.Text = dr["price"].ToString();
                        isbn.Text = dr["isbn"].ToString();
                        date.Text = dr["pdate"].ToString();
                        semester.SelectedItem = dr["Semester"].ToString();
                        branch.SelectedItem = dr["branch"].ToString();
                        bookid.Text = dr["Book_ID"].ToString();
                    }
                }
                if (searchby.SelectedItem == "Book ID")
                {
                    SqlCommand sc = new SqlCommand("select * from bookdata where Book_ID='" + search.Text + "'", con);
                    SqlDataReader dr = sc.ExecuteReader();
                    while (dr.Read())
                    {
                        bookname.Text = dr["Book_name"].ToString();
                        author.Text = dr["Auther"].ToString();
                        pname.Text = dr["pname"].ToString();
                        price.Text = dr["price"].ToString();
                        isbn.Text = dr["isbn"].ToString();
                        date.Text = dr["pdate"].ToString();
                        semester.SelectedItem = dr["Semester"].ToString();
                        branch.SelectedItem = dr["branch"].ToString();
                        bookid.Text = dr["Book_ID"].ToString();
                    }
                }
                if (searchby.SelectedItem == "Book Auther")
                {
                    SqlCommand sc = new SqlCommand("select * from bookdata where Auther='" + search.Text + "'", con);
                    SqlDataReader dr = sc.ExecuteReader();
                    while (dr.Read())
                    {
                        bookname.Text = dr["Book_name"].ToString();
                        author.Text = dr["Auther"].ToString();
                        pname.Text = dr["pname"].ToString();
                        price.Text = dr["price"].ToString();
                        isbn.Text = dr["isbn"].ToString();
                        date.Text = dr["pdate"].ToString();
                        semester.SelectedItem = dr["Semester"].ToString();
                        branch.SelectedItem = dr["branch"].ToString();
                        bookid.Text = dr["Book_ID"].ToString();
                    }
                }
                if (searchby.SelectedItem == "Publication Name")
                {
                    SqlCommand sc = new SqlCommand("select * from bookdata where pname='" + search.Text + "'", con);
                    SqlDataReader dr = sc.ExecuteReader();
                    while (dr.Read())
                    {
                        bookname.Text = dr["Book_name"].ToString();
                        author.Text = dr["Auther"].ToString();
                        pname.Text = dr["pname"].ToString();
                        price.Text = dr["price"].ToString();
                        isbn.Text = dr["isbn"].ToString();
                        date.Text = dr["pdate"].ToString();
                        semester.SelectedItem = dr["Semester"].ToString();
                        branch.SelectedItem = dr["branch"].ToString();
                        bookid.Text = dr["Book_ID"].ToString();
                    }
                }
                if (searchby.SelectedItem == "Semester")
                {
                    SqlCommand sc = new SqlCommand("select * from bookdata where Semester='" + search.Text + "'", con);
                    SqlDataReader dr = sc.ExecuteReader();
                    while (dr.Read())
                    {
                        bookname.Text = dr["Book_name"].ToString();
                        author.Text = dr["Auther"].ToString();
                        pname.Text = dr["pname"].ToString();
                        price.Text = dr["price"].ToString();
                        isbn.Text = dr["isbn"].ToString();
                        date.Text = dr["pdate"].ToString();
                        semester.SelectedItem = dr["Semester"].ToString();
                        branch.SelectedItem = dr["branch"].ToString();
                        bookid.Text = dr["Book_ID"].ToString();
                    }
                }
                if (searchby.SelectedItem == "Branch")
                {
                    SqlCommand sc = new SqlCommand("select * from bookdata where branch='" + search.Text + "'", con);
                    SqlDataReader dr = sc.ExecuteReader();
                    while (dr.Read())
                    {
                        bookname.Text = dr["Book_name"].ToString();
                        author.Text = dr["Auther"].ToString();
                        pname.Text = dr["pname"].ToString();
                        price.Text = dr["price"].ToString();
                        isbn.Text = dr["isbn"].ToString();
                        date.Text = dr["pdate"].ToString();
                        semester.SelectedItem = dr["Semester"].ToString();
                        branch.SelectedItem = dr["branch"].ToString();
                        bookid.Text = dr["Book_ID"].ToString();
                    }
                }
            }
        }
    }
}
