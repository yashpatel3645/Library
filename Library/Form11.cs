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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
            SqlDataAdapter dd = new SqlDataAdapter("Select * from studentdetail", con);
            DataTable dg = new DataTable();
            dd.Fill(dg);
            dataGridView1.DataSource = dg;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Student")
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                    con.Open();
                    if (comboBox1.SelectedItem == "Semester")
                    {
                        SqlDataAdapter da = new SqlDataAdapter("Select * from studentdetail where semester like '" + textBox1.Text + "%'", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    if (comboBox1.SelectedItem == "Book ID")
                    {
                        SqlDataAdapter db = new SqlDataAdapter("Select * from studentdetail where bookid like '" + textBox1.Text + "%'", con);
                        DataTable de = new DataTable();
                        db.Fill(de);
                        dataGridView1.DataSource = de;
                    }
                    if (comboBox1.SelectedItem == "Enrollment No.")
                    {
                        SqlDataAdapter dc = new SqlDataAdapter("Select * from studentdetail where enrollment like '" + textBox1.Text + "%'", con);
                        DataTable df = new DataTable();
                        dc.Fill(df);
                        dataGridView1.DataSource = df;
                    }
                    if (comboBox1.SelectedItem == "Issue Date")
                    {
                        SqlDataAdapter dd = new SqlDataAdapter("Select * from studentdetail where issuedate like '" + textBox1.Text + "%'", con);
                        DataTable dg = new DataTable();
                        dd.Fill(dg);
                        dataGridView1.DataSource = dg;
                    }
                    if (comboBox1.SelectedItem == "Submission Date")
                    {

                        SqlDataAdapter dd = new SqlDataAdapter("Select * from studentdetail where subdate like '" + textBox1.Text + "%'", con);
                        DataTable dg = new DataTable();
                        dd.Fill(dg);
                        dataGridView1.DataSource = dg;
                    }
                    if (comboBox1.SelectedItem == "Class")
                    {
                        SqlDataAdapter dd = new SqlDataAdapter("Select * from studentdetail where class like '" + textBox1.Text + "%'", con);
                        DataTable dg = new DataTable();
                        dd.Fill(dg);
                        dataGridView1.DataSource = dg;
                    }
                    if (comboBox1.SelectedItem == "College")
                    {
                        SqlDataAdapter dd = new SqlDataAdapter("Select * from studentdetail where college like '" + textBox1.Text + "%'", con);
                        DataTable dg = new DataTable();
                        dd.Fill(dg);
                        dataGridView1.DataSource = dg;
                    }
                    if (comboBox1.SelectedItem == "Branch")
                    {
                        SqlDataAdapter dd = new SqlDataAdapter("Select * from studentdetail where branch like '" + textBox1.Text + "%'", con);
                        DataTable dg = new DataTable();
                        dd.Fill(dg);
                        dataGridView1.DataSource = dg;
                    }
                    if (comboBox1.SelectedItem == "Student Name")
                    {
                        SqlDataAdapter dd = new SqlDataAdapter("Select * from studentdetail where sname like '" + textBox1.Text + "%'", con);
                        DataTable dg = new DataTable();
                        dd.Fill(dg);
                        dataGridView1.DataSource = dg;
                    }

                }
                catch (Exception ep)
                {
                    MessageBox.Show(ep.Message);
                }
            }
            if (comboBox2.SelectedItem == "Faculty")
            {
                comboBox1.SelectedIndex = 2;
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                SqlDataAdapter dd = new SqlDataAdapter("Select * from facultydetails", con);
                DataTable dg = new DataTable();
                dd.Fill(dg);
                dataGridView1.DataSource = dg;
            }
        }

        private void open3(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedItem == "Student")
            {
                label3.Visible = true;
                comboBox1.Visible = true;
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                SqlDataAdapter dd = new SqlDataAdapter("Select * from studentdetail", con);
                DataTable dg = new DataTable();
                dd.Fill(dg);
                dataGridView1.DataSource = dg;
            }
            if(comboBox2.SelectedItem == "Faculty")
            {
                label3.Visible = false;
                comboBox1.Visible = false;
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                SqlDataAdapter dd = new SqlDataAdapter("Select * from facultydetails", con);
                DataTable dg = new DataTable();
                dd.Fill(dg);
                dataGridView1.DataSource = dg;
            }
        }
    }
}
