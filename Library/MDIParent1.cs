using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Library
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form4();
            childForm.MdiParent = this;
            childForm.MaximizeBox = true;
            childForm.Show();
         //   Form4 f = new Form4();
         //   f.MdiParent = this.MdiParent;
           // f.Show(); 
        }

        private void OpenFile(object sender, EventArgs e)
        {
            Form childForm = new Form13();
            childForm.MdiParent = this;
            childForm.MaximizeBox = true;
            childForm.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Form5();
            childForm.MdiParent = this;
            childForm.MaximizeBox = true;
            childForm.Show();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form childForm = new Form14();
            childForm.MdiParent = this;
            childForm.MaximizeBox = true;
            childForm.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
           /* string hello = DateTime.Now.Date.ToString();
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
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
            try
            {
                string s = DateTime.Now.Date.ToString();
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\King_Heart\Documents\Visual Studio 2015\Projects\Library\Library\bookdata.mdf;Integrated Security=True");
                con.Open();
                SqlCommand sc = new SqlCommand("Select * from studentdetail where subdate < '" + s + "'", con);
                SqlDataReader dr = sc.ExecuteReader();
                while (dr.Read())
                {
                    string sa = dr["email"].ToString();
                    if (sa == s)
                    {
                        SqlCommand scm = new SqlCommand("insert into studentdetail(penalty) values ('2')", con);
                        scm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception epz)
            {
                MessageBox.Show(epz.Message);
            }*/
        }

        private void faToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Faculty();
            childForm.MdiParent = this;
            childForm.MaximizeBox = true;
            childForm.Show();
        }

        private void close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Form3();
            childForm.MdiParent = this;
            childForm.MaximizeBox = true;
            childForm.Show();
        }

        private void facultyDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Form11();
            childForm.MdiParent = this;
            childForm.MaximizeBox = true;
            childForm.Show();
        }

        private void issueNweBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Form6();
            childForm.MdiParent = this;
            childForm.MaximizeBox = true;
            childForm.Show();
        }

        private void returnBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form childForm = new Form10();
            childForm.MdiParent = this;
            childForm.MaximizeBox = true;
            childForm.Show();
        }

        private void studentDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form childForm = new StudentDetails();
            childForm.MdiParent = this;
            childForm.MaximizeBox = true;
            childForm.Show();
        }

        private void facultyDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form childForm = new Faculty_Details();
            childForm.MdiParent = this;
            childForm.MaximizeBox = true;
            childForm.Show();
        }

        private void outOfSubmissionDateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form childForm = new Form2();
            childForm.MdiParent = this;
            childForm.MaximizeBox = true;
            childForm.Show();
        }
    }
}
