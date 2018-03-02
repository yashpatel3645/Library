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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            // TODO: This line of code loads data into the 'bookdataDataSet.bookdata' table. You can move, or remove it, as needed.
            this.bookdataTableAdapter.Fill(this.bookdataDataSet.bookdata);
            comboBox1.SelectedIndex = 1;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =c:\users\king_heart\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf; Integrated Security = True");
                con.Open();
                if (comboBox1.SelectedItem == "Book Name")
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from bookdata where Book_name like '" + textBox1.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                if (comboBox1.SelectedItem == "Book ID")
                {
                    SqlDataAdapter db = new SqlDataAdapter("Select * from bookdata where Book_ID like '" + textBox1.Text + "%'", con);
                    DataTable de = new DataTable();
                    db.Fill(de);
                    dataGridView1.DataSource = de;
                }
                if (comboBox1.SelectedItem == "Semester")
                {
                    SqlDataAdapter dc = new SqlDataAdapter("Select * from bookdata where Semester like '" + textBox1.Text + "%'", con);
                    DataTable df = new DataTable();
                    dc.Fill(df);
                    dataGridView1.DataSource = df;
                }
                if (comboBox1.SelectedItem == "Auther")
                {
                    SqlDataAdapter dd = new SqlDataAdapter("Select * from bookdata where Auther like '" + textBox1.Text + "%'", con);
                    DataTable dg = new DataTable();
                    dd.Fill(dg);
                    dataGridView1.DataSource = dg;
                } 
            }
            catch(Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f = new Form8();
            f.Show();
        }
    }
}
