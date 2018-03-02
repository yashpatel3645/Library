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
            this.bookdataTableAdapter.Fill(this.bookdataDataSet1.bookdata);

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =c:\users\king_heart\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf; Integrated Security = True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from bookdata where Book_ID like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =c:\users\king_heart\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf; Integrated Security = True");
                con.Open();
                SqlCommand da = new SqlCommand("Delete from bookdata where Book_ID='"+textBox1.Text+"'",con);
                da.ExecuteNonQuery();
                MessageBox.Show("Deleted");
            }
            catch(Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f = new Form8();
            f.Show();
        }
    }
}
