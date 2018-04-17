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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
            SqlDataAdapter dd = new SqlDataAdapter("Select * from studentdetail", con);
            DataTable dg = new DataTable();
            dd.Fill(dg);
            dataGridView1.DataSource = dg;
            returnby.SelectedIndex = 0;
        }
        static int b;
        static int c;
        private void button2_Click(object sender, EventArgs e)
        {
            if (bookid.Text == "")
            {
                MessageBox.Show("Please Enter Book ID.");
            }
            else
            {
                if (returnby.SelectedItem.ToString() == "Student")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                        con.Open();
                        SqlCommand da = new SqlCommand("Delete from studentdetail where bookid='" + bookid.Text + "'", con);
                        da.ExecuteNonQuery();
                        MessageBox.Show("Return Successfully.");
                    }
                    catch (Exception ep)
                    {
                        MessageBox.Show(ep.Message);
                    }
                }
                if (returnby.SelectedItem.ToString() == "Faculty")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                        con.Open();
                        SqlCommand da = new SqlCommand("Delete from facultydetails where book_id='" + bookid.Text + "'", con);
                        da.ExecuteNonQuery();
                        MessageBox.Show("Return Successfully.");
                    }
                    catch (Exception ep)
                    {
                        MessageBox.Show(ep.Message);
                    }
                }
            }
            }

        private void open3(object sender, DataGridViewCellEventArgs e)
        {
            bookid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (returnby.SelectedItem.ToString() == "Student")
            {
                label3.Visible = true;
                Penalty.Visible = true;
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                SqlDataAdapter dd = new SqlDataAdapter("Select * from studentdetail", con);
                DataTable dg = new DataTable();
                dd.Fill(dg);
                dataGridView1.DataSource = dg;
            }
            if(returnby.SelectedItem.ToString() == "Faculty")
            {
                label3.Visible = false;
                Penalty.Visible = false;
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                SqlDataAdapter dd = new SqlDataAdapter("Select * from facultydetails", con);
                DataTable dg = new DataTable();
                dd.Fill(dg);
                dataGridView1.DataSource = dg;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (returnby.SelectedItem.ToString() == "Student")
            {
                if (bookid.Text == "")
                {
                    Penalty.Text = "0";
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                        con.Open();
                        SqlDataAdapter sc = new SqlDataAdapter("select * from studentdetail", con);
                        DataTable dt = new DataTable();
                        sc.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ep)
                    {
                        MessageBox.Show(ep.Message);
                    }
                }
                else
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                        con.Open();
                        SqlCommand sc = new SqlCommand("Select * from studentdetail where bookid = '" + bookid.Text + "'", con);
                        SqlDataAdapter da = new SqlDataAdapter(sc);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        SqlDataReader dr = sc.ExecuteReader();
                        while (dr.Read())
                        {
                            subdate.Value = Convert.ToDateTime(dr["subdate"].ToString());
                        }

                        TimeSpan diff = today.Value.Date - subdate.Value.Date;
                        var a = diff.TotalDays;
                        if (a > 0)
                            Penalty.Text = Convert.ToString(a * 2);
                        else
                            Penalty.Text = "0";
                    }
                    catch (Exception ep)
                    {
                        MessageBox.Show(ep.Message);
                    }
                }
            }
            if (returnby.SelectedItem.ToString() == "Faculty")
            {
                if (bookid.Text == "")
                {
                    Penalty.Text = "0";
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                        con.Open();
                        SqlDataAdapter sc = new SqlDataAdapter("select * from facultydetails", con);
                        DataTable dt = new DataTable();
                        sc.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ep)
                    {
                        MessageBox.Show(ep.Message);
                    }
                }
                else
                {
                    try
                    {

                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                        con.Open();
                        SqlCommand sc = new SqlCommand("Select * from facultydetails where bookid = '" + bookid.Text + "'", con);
                        SqlDataAdapter da = new SqlDataAdapter(sc);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ep)
                    {
                        MessageBox.Show(ep.Message);
                    }
                }
            }
        }
    }
}