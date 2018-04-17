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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookdataDataSet1.bookdata' table. You can move, or remove it, as needed.
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =c:\users\yashp\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf; Integrated Security = True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from bookdata", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            comboBox1.SelectedIndex = 1;
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (bookid.Text == "")
            {
                MessageBox.Show("Please Enter Book ID.");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =c:\users\yashp\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf; Integrated Security = True");
                    con.Open();
                    if (comboBox1.SelectedItem == "Book ID")
                    {
                        SqlCommand da = new SqlCommand("Delete from bookdata where Book_ID='" + bookid.Text + "'", con);
                        da.ExecuteNonQuery();
                        MessageBox.Show("Deleted");
                    }
                    if (comboBox1.SelectedItem == "Book Name")
                    {
                        SqlCommand da = new SqlCommand("Delete from bookdata where Book_name='" + bookid.Text + "'", con);
                        da.ExecuteNonQuery();
                        MessageBox.Show("Deleted");
                    }
                    if (comboBox1.SelectedItem == "Auther")
                    {
                        SqlCommand da = new SqlCommand("Delete from bookdata where Auther='" + bookid.Text + "'", con);
                        da.ExecuteNonQuery();
                        MessageBox.Show("Deleted");
                    }
                    if (comboBox1.SelectedItem == "Publication")
                    {
                        SqlCommand da = new SqlCommand("Delete from bookdata where pname='" + bookid.Text + "'", con);
                        da.ExecuteNonQuery();
                        MessageBox.Show("Deleted");
                    }
                    if (comboBox1.SelectedItem == "Semester")
                    {
                        SqlCommand da = new SqlCommand("Delete from bookdata where Semester='" + bookid.Text + "'", con);
                        da.ExecuteNonQuery();
                        MessageBox.Show("Deleted");
                    }
                    if (comboBox1.SelectedItem == "Branch")
                    {
                        SqlCommand da = new SqlCommand("Delete from bookdata where branch='" + bookid.Text + "'", con);
                        da.ExecuteNonQuery();
                        MessageBox.Show("Deleted");
                    }
                }
                catch (Exception ep)
                {
                    MessageBox.Show(ep.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void open3(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox1.SelectedItem == "Book ID")
            {
                bookid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            if (comboBox1.SelectedItem == "Book Name")
            {
                bookid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            if (comboBox1.SelectedItem == "Auther")
            {
                bookid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            if (comboBox1.SelectedItem == "Publication")
            {
                bookid.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            if (comboBox1.SelectedItem == "Semester")
            {
                bookid.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            if (comboBox1.SelectedItem == "Branch")
            {
                bookid.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookid.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =c:\users\yashp\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf; Integrated Security = True");
                con.Open();
                if (comboBox1.SelectedItem == "Book ID")
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from bookdata where Book_ID like '" + bookid.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                if (comboBox1.SelectedItem == "Book Name")
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from bookdata where Book_name like '" + bookid.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                if (comboBox1.SelectedItem == "Auther")
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from bookdata where Auther like '" + bookid.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                if (comboBox1.SelectedItem == "Publication")
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from bookdata where pname like '" + bookid.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                if (comboBox1.SelectedItem == "Semester")
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from bookdata where Semester like '" + bookid.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                if (comboBox1.SelectedItem == "Branch")
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from bookdata where branch like '" + bookid.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }
    }
}
