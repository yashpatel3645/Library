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
            // TODO: This line of code loads data into the 'studentdetailDataSet.student1' table. You can move, or remove it, as needed.
            this.student1TableAdapter.Fill(this.studentdetailDataSet.student1);
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\King_Heart\documents\visual studio 2015\Projects\Library\Library\Studentdetail.mdf;Integrated Security=True");
                con.Open();
                if (comboBox1.SelectedItem == "Semester")
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from student1 where semester like '" + textBox1.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                if (comboBox1.SelectedItem == "Book ID")
                {
                    SqlDataAdapter db = new SqlDataAdapter("Select * from student1 where bookid like '" + textBox1.Text + "%'", con);
                    DataTable de = new DataTable();
                    db.Fill(de);
                    dataGridView1.DataSource = de;
                }
                if (comboBox1.SelectedItem == "Enrollment No.")
                {
                    SqlDataAdapter dc = new SqlDataAdapter("Select * from student1 where enrollment like '" + textBox1.Text + "%'", con);
                    DataTable df = new DataTable();
                    dc.Fill(df);
                    dataGridView1.DataSource = df;
                }
                if (comboBox1.SelectedItem == "Issue Date")
                {
                    SqlDataAdapter dd = new SqlDataAdapter("Select * from student1 where issuedate like '" + textBox1.Text + "%'", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f = new Form8();
            f.Show();
        }
    }
}
