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
using System.IO;

namespace Institute_Easy_Exam
{
    public partial class Form3 : Form
    {
        Form10 f10;
        SqlCommand cmd;
       
        public Form3(Form10 frm10)
        {
            InitializeComponent();
            this.f10 = frm10;
        }

       

      

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {
            bunifuMaterialTextbox3.Text = f10.bunifuMaterialTextbox1.Text;
            label7.Text = f10.bunifuMaterialTextbox1.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=PDashboard;Integrated Security=True");
            try
            {
                string query = "SELECT CollegeID,Logo,filepath from saveimage where CollegeID='" + f10.bunifuMaterialTextbox1.Text + "'";
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    byte[] img = (byte[])(dr[1]);
                    if (img == null)
                    {
                        pictureBox2.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox2.Image = Image.FromStream(ms);
                    }
                }
              
                con.Close();
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
           


           
            
            

            

        }

      

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

      

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
        }
       
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=PDashboard;Integrated Security=True"))
            using (var command = con.CreateCommand())
            {

                con.Open();
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = ms.ToArray();
                command.Parameters.AddWithValue("@pic", pic);
                command.CommandText = @"INSERT INTO[dbo].[saveimage]
            
                       ([CollegeID] 
                       ,[Logo]
                       ,[filepath])
                        VALUES
                           ('" + bunifuMaterialTextbox3.Text + "',@pic,'" + bunifuMaterialTextbox2.Text + "')";
                command.ExecuteNonQuery();
               
                
            } 
            MessageBox.Show("ImageSaved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*) | *.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    bunifuMaterialTextbox2.Text = imageLocation;
                    pictureBox1.ImageLocation = pictureBox2.ImageLocation = imageLocation;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            f.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
