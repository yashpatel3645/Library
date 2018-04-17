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
using System.Net;
using System.Net.Mail;

namespace Library
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf; Integrated Security = True");
            con.Open();
            // SqlCommand sc = new SqlCommand("select * from studentdetail",con);

            SqlDataAdapter da = new SqlDataAdapter("select * from studentdetail where subdate <'" + dateTimePicker1.Text + "'", con);
            DataTable db = new DataTable();
            da.Fill(db);
            dataGridView1.DataSource = db;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string hello = DateTime.Now.Date.ToString();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\yashp\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf; Integrated Security = True");
                con.Open();
                SqlCommand sc = new SqlCommand("Select email from studentdetail where subdate < '" + hello + "'", con);
                SqlDataReader dr = sc.ExecuteReader();
                while (dr.Read())
                {
                    var fromAddress = new MailAddress("librarymanagement007@gmail.com", "From Library");
                    var toAddress = new MailAddress(dr["email"].ToString(), "To Student");
                    const string fromPassword = "Yash9924091719";
                    const string subject = "Submit Book";
                    const string body = "Please Submit Your Book Fast As Possible.";

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                        Timeout = 20000
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                }
                MessageBox.Show("Email Sent Successfully.");
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }
    }
}


