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
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =c:\users\king_heart\documents\visual studio 2015\Projects\Library\Library\bookdata.mdf; Integrated Security = True");
                con.Open();
                SqlCommand sc = new SqlCommand("INSERT INTO bookdata(Book_ID,Book_name,Auther,Semester) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
                sc.ExecuteNonQuery();
                MessageBox.Show("Saved");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch(Exception ep)
            {
                MessageBox.Show("Book ID is Already In Use."+ep.ToString());
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
