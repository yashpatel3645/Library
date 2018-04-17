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
    public partial class Faculty_Details : Form
    {
        public Faculty_Details()
        {
            InitializeComponent();
        }

        private void Faculty_Details_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter dd = new SqlDataAdapter("Select * from facultyregi", con);
            DataTable dg = new DataTable();
            dd.Fill(dg);
            dataGridView1.DataSource = dg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                MessageBox.Show("Please Write In Searchbox. ");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yashp\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                con.Open();
                if (comboBox1.SelectedItem == "Name")
                {
                    SqlDataAdapter sc = new SqlDataAdapter("select * from facultyregi where name like '" + search.Text + "%'", con);
                    DataTable dg = new DataTable();
                    sc.Fill(dg);
                    dataGridView1.DataSource = dg;
                }
                if (comboBox1.SelectedItem == "Contect")
                {
                    SqlDataAdapter sc = new SqlDataAdapter("select * from facultyregi where contect like '" + search.Text + "%'", con);
                    DataTable dg = new DataTable();
                    sc.Fill(dg);
                    dataGridView1.DataSource = dg;
                }
                if (comboBox1.SelectedItem == "Department")
                {
                    SqlDataAdapter sc = new SqlDataAdapter("select * from facultyregi where Department like '" + search.Text + "%'", con);
                    DataTable dg = new DataTable();
                    sc.Fill(dg);
                    dataGridView1.DataSource = dg;
                }
            }
        }
    }
}
