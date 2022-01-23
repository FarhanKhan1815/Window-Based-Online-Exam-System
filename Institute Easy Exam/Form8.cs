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
using System.Configuration;
using System.IO;

namespace Institute_Easy_Exam
{
    public partial class Form8 : Form
    {
        Form29 f29;
        Form6 f6;
        public Form8(Form29 frm29)
        {
            InitializeComponent();
            this.f29 = frm29;


        }
        public Form8(Form6 frm6)
        {
            InitializeComponent();
            this.f6 = frm6;
        }







       
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = mcqset1; Integrated Security = True");


            if (bunifuMaterialTextbox1.Text != string.Empty || bunifuMaterialTextbox2.Text != string.Empty || bunifuMaterialTextbox3.Text != string.Empty)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=student signup;Integrated Security=True ");
                    SqlDataAdapter adapter = new SqlDataAdapter("Select COUNT (*) from student where name='" + bunifuMaterialTextbox1.Text + "' and enrollmentnumber='" + bunifuMaterialTextbox2.Text + "'", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    string tblnm = bunifuMaterialTextbox3.Text;
                    string str = @"IF EXISTS(
                    SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
                    WHERE TABLE_NAME = @table) 
                    SELECT 1 ELSE SELECT 0";
                    SqlCommand c = new SqlCommand(str, con);
                    con.Open();
                    c.Parameters.Add("@table", SqlDbType.NVarChar).Value = tblnm;
                    int exists = (int)c.ExecuteScalar();
                    if (dt.Rows[0][0].ToString() == "1" && exists == 1 && bunifuMaterialTextbox4.Text!=string.Empty )
                    {
                        MessageBox.Show("Welcome!" + Environment.NewLine + bunifuMaterialTextbox1.Text + Environment.NewLine + "Start Your Exam");
                        Form16 form16 = new Form16(this);
                        form16.Show();
                        this.Close();
                    }
                    else if (bunifuMaterialTextbox4.Text == string.Empty)
                    {
                        MessageBox.Show("Please Upload Your Picture First","Upload",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Your Data Properly", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                    }
                    c.ExecuteNonQuery(); 
                 conn.Close();


                }
                
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please fill all fields","Fill",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            
           

             
                

         
               
            
            




            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox2.Text = "";
            bunifuMaterialTextbox3.Text = "";










        }



        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox1.Text== "Enter Your Name")
            {
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "Enter Your Name";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox2.Text== "Enter your Enrollment Number")
            {
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox2.ForeColor = Color.Black;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = mcqset2; Integrated Security = True"))
            using (var command = con.CreateCommand())
            {

                con.Open();
                MemoryStream ms = new MemoryStream();
                pictureBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = ms.ToArray();
                command.Parameters.AddWithValue("@pic", pic);
                command.CommandText = @"INSERT INTO[dbo].[java_percentage]
            
                       ([Enroll]
                       ,[filepath]
                       ,[images])
                        VALUES
                           ('" + bunifuMaterialTextbox2.Text + "','" + bunifuMaterialTextbox4.Text + "',@pic)";
                command.ExecuteNonQuery();


            }
            MessageBox.Show("ImageSaved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*) | *.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    bunifuMaterialTextbox4.Text = imageLocation;
                    pictureBox2.ImageLocation = pictureBox1.ImageLocation = imageLocation;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();

        }
    }
}
