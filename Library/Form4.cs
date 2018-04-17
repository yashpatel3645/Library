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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (bname.Text == "")
            {
                MessageBox.Show("Please Enter Book Name.");
            }
            else if (bauthor.Text == "")
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
            else if (bsemester.SelectedIndex == null)
            {
                MessageBox.Show("Please Select Semester.");
            }
            else if (bbranch.SelectedIndex == null)
            {
                MessageBox.Show("Please Select Branch.");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =c:\users\yashp\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf; Integrated Security = True");
                    con.Open();
                    SqlCommand sc = new SqlCommand("INSERT INTO bookdata(Book_name,Auther,Semester,branch,pname,pdate,price,isbn) VALUES ('" + bname.Text + "','" + bauthor.Text + "','" + bsemester.SelectedItem.ToString() + "','" + bbranch.SelectedItem.ToString() + "','" + pname.Text + "','" + date.Text + "','" + price.Text + "','" + isbn.Text + "')", con);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Saved");
                    pname.Text = "";
                    bname.Text = "";
                    bauthor.Text = "";
                    price.Text = "";
                    isbn.Text = "";
                    bbranch.SelectedIndex = 0;
                    bsemester.SelectedIndex = 0;
                    date.Value = DateTime.Now;
                }
                catch (Exception ep)
                {
                    MessageBox.Show("Book ID is Already In Use." + ep.ToString());
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            bbranch.SelectedIndex = 0;
            bsemester.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Book")
            {
                panel1.Visible = true;
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
    }
}
