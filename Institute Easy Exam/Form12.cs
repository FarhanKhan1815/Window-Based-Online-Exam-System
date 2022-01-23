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
using System.Net.Mime;

namespace Institute_Easy_Exam
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = student signup; Integrated Security = True");

        public void enrollmentnumber()
        {
            string enrollmentnumber;
            string query = "select enrollmentnumber from student order by enrollmentnumber Desc";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                enrollmentnumber = id.ToString("0000000000");
            }
            else if (Convert.IsDBNull(dr))
            {
                enrollmentnumber = ("0000000000");
            }
            else
            {
                enrollmentnumber = ("0000000000");
            }
            con.Close();
            bunifuMaterialTextbox2.Text = enrollmentnumber.ToString();
        }

       private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("fk7045980460@gmail.com", "G@ng$ter7866666");
                MailMessage msg = new MailMessage();
                msg.To.Add(bunifuMaterialTextbox3.Text);
                msg.From = new MailAddress("fk7045980460@gmail.com");
                msg.Subject = "Student Login!";
                msg.Body = "Hello from visual studio, You're Successfully Registered as a Student,youre Enrollment no is"+bunifuMaterialTextbox2.Text;
                client.Send(msg);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (bunifuMaterialTextbox1.Text != string.Empty || bunifuMaterialTextbox2.Text != string.Empty || bunifuMaterialTextbox3.Text!=string.Empty)

            {
                MessageBox.Show("Registered Successfully","Registered",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Please fill All Fields..!","Fill",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=student signup;Integrated Security=True ");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[student]
            ([name] 
            ,[enrollmentnumber]
            ,[studentEmailID] )
          VALUES
               ('" + bunifuMaterialTextbox1.Text + "','" + bunifuMaterialTextbox2.Text +"','"+ bunifuMaterialTextbox3.Text+ "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            enrollmentnumber();
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox1.Text== "Enter your name")
            {
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "Enter your name";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox2.Text== "enter your enrollment number")
            {
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox2.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "")
            {
                bunifuMaterialTextbox2.Text = "enter your enrollment numbe";
                bunifuMaterialTextbox2.ForeColor = Color.Black;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void bunifuMaterialTextbox3_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox3.Text== " studentEmailID")
            {
                bunifuMaterialTextbox3.ForeColor = Color.Black;
                bunifuMaterialTextbox3.Text = "";
            }
        }

        private void bunifuMaterialTextbox3_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox3.Text == "")
            {
                bunifuMaterialTextbox3.ForeColor = Color.Black;
                bunifuMaterialTextbox3.Text = " studentEmailID";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
