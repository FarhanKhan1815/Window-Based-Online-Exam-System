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
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO;

namespace Institute_Easy_Exam
{
    public partial class Form11 : Form
    {
        bool _monitoring;
        Capture _capture;
        Form8 f11;
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Form11(Form8 frm)
        {
            InitializeComponent();
           
            this.f11 = frm;
           totalQuestions = 10;
          
        }
       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            _monitoring = false;
            _capture = new Capture(0);
            bunifuMaterialTextbox3.Text = f11.bunifuMaterialTextbox2.Text;
            
            if (!_monitoring)
            {
                Application.Idle += monitoring;

            }
            else
            {

                Application.Idle -= monitoring;

            }
            _monitoring = !_monitoring;
        }
        private void monitoring(object sender, System.EventArgs e)
        {

            var img = _capture.QueryFrame().ToImage<Bgr, Byte>();
            var bmp = img.Bitmap;
            pictureBox1.Image = bmp;
        }
        private void radioButton1_Click(object sender, EventArgs e)
        {
            var senderObject = (RadioButton)sender;
            int radiobuttonTag = Convert.ToInt32(senderObject.Tag);
            if (radiobuttonTag == correctAnswer)
            {
                score++;


            }

        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset2;Integrated Security=True");
            con.Open();
            string query = "SELECT questions,option1,option2,option3,option4 FROM java_questions";
            SqlCommand cmd = new SqlCommand(query, con);
           
            SqlDataReader dr = cmd.ExecuteReader();
           
             while(dr.Read())
             {
                bunifuMaterialTextbox1.Text = (dr["questions"].ToString());
                radioButton1.Text = (dr["option1"].ToString());
                radioButton2.Text = (dr["option2"].ToString());
                radioButton3.Text = (dr["option3"].ToString());
                radioButton4.Text = (dr["option4"].ToString());
             }
            dr.Close();
            con.Close();
            
           
               

            
            questionNumber++;
           
        }
        

        private void bunifuMaterialTextbox3_Click(object sender, EventArgs e)
        {

        }

       

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset2;Integrated Security=True ");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[java_percentage]
            ([percentage]
            ,[Enroll]
            )
         VALUES
            ('" + percentage + "','" + bunifuMaterialTextbox3.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your Percentage is" + percentage);
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "Image";

            s.Filter = "Image(.jpg)|*.jpg";
            if (s.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(s.FileName);
            }
        }
    }
}
