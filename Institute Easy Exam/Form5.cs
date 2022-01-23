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
    public partial class Form5 : Form
    {
        int branchid;

        
        public Form5()
        {
            InitializeComponent();
            refereshbranch();
            
        }
       
        private void refereshbranch()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=dropdown;Integrated Security=True ");
            con.Open();
            SqlCommand cmdss = new SqlCommand("select * from TeacherBranch", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmdss);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            comboBox1.DisplayMember = "branchname";
            comboBox1.ValueMember = "branchid";
            comboBox1.DataSource = dt;

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
                msg.To.Add(bunifuMaterialTextbox1.Text);
                msg.From = new MailAddress("fk7045980460@gmail.com");
                msg.Subject = "Teacher Login!";
                msg.Body = "Hello from visual studio, You're Successfully Registered as a Teacher, Your password is"+"\n"+bunifuMaterialTextbox2.Text;
                client.Send(msg);
                
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (bunifuMaterialTextbox1.Text != string.Empty || bunifuMaterialTextbox4.Text != string.Empty || bunifuMaterialTextbox2.Text!=string.Empty)
            {
                MessageBox.Show("Registered Successfully","Registered",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Please fill all Fields..!","Fill",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=teacher signup;Integrated Security=True ");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[teacher]
            ([teacheremailid] 
            ,[qualification]
            ,[password])
         VALUES
             ('" + bunifuMaterialTextbox1.Text + "','" + bunifuMaterialTextbox4.Text + "','"+bunifuMaterialTextbox2.Text+ "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            this.Hide();
            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox4.Text = "";
            bunifuMaterialTextbox2.Text = "";

            Form9 f9 = new Form9();
            f9.Show();
            this.Close();
          


        }

        private void Form5_Load(object sender, EventArgs e)
        {
           

            




        }


        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != null)
            {
                branchid = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                refereshsubject(branchid);



            }
        }

        private void refereshsubject(int branchid)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=dropdown;Integrated Security=True ");
            con.Open();
            SqlCommand cmdss = new SqlCommand("select * from TeacherSubject where branchid=@branchid", con);
            cmdss.Parameters.AddWithValue("branchid", branchid);
            SqlDataAdapter sda = new SqlDataAdapter(cmdss);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            comboBox2.DisplayMember = "subjectname";
            comboBox2.ValueMember = "id";
            comboBox2.DataSource = dt;
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            int minLength = 4;
            int maxLength = 6;
            
            string charAvailable = "0123456789";
            
            
            StringBuilder password = new StringBuilder();
            Random rdm = new Random(); 
            rdm.ToString();

            int passwordLength = rdm.Next(minLength, maxLength + 1);

            while (passwordLength-- > 0)
            {
                password.Append(charAvailable[rdm.Next(charAvailable.Length)]);
                bunifuMaterialTextbox2.Text = password.ToString();


            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "Teacher's email id")
            {
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "Teacher's email id";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }

            
        }

        private void bunifuMaterialTextbox4_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox4.Text== "Teacher's Qualification")
            {
                bunifuMaterialTextbox4.Text = "";
                bunifuMaterialTextbox4.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox4_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.Text == "")
            {
                bunifuMaterialTextbox4.Text = "Teacher's Qualification";
                bunifuMaterialTextbox4.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox2.Text== "Password")
            {
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox2.ForeColor = Color.Black;
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
 }   



