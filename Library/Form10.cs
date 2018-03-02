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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\King_Heart\documents\visual studio 2015\Projects\Library\Library\Studentdetail.mdf;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from student1 where bookid like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentdetailDataSet1.student1' table. You can move, or remove it, as needed.
            this.student1TableAdapter.Fill(this.studentdetailDataSet1.student1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f = new Form9();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\King_Heart\documents\visual studio 2015\Projects\Library\Library\Studentdetail.mdf;Integrated Security=True");
                con.Open();
                SqlCommand da = new SqlCommand("Delete from student1 where bookid='" + textBox1.Text + "'", con);
                da.ExecuteNonQuery();
                MessageBox.Show("Deleted");
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }
    }
}
