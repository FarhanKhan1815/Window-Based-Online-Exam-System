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
using Bunifu.Framework.UI;
using System.Configuration;







namespace Institute_Easy_Exam
{
    public partial class Form16 : Form
    {
        
        bool _monitoring;
        Capture _capture;
        Form8 f;
        Form18 f18;

       



        string correctanswer;
        string correctanswer1;
        string correctanswer2;
        string correctanswer3;
        string correctanswer4;
        string correctanswer5;
        string correctanswer6;
        string correctanswer7;
        string correctanswer8;
        string correctanswer9;
        int score;
        int percentage;





        public Form16(Form18 frm18)
        {
            InitializeComponent();
            this.f18 = frm18;
        }


        public Form16(Form8 frm)
        {
            InitializeComponent();



            this.f = frm;
            




        }


        returnclass rc = new returnclass();









        private void radioButton1_Click(object sender, EventArgs e)
        {





        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
            SqlCommand cm = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo."+"\n"+label2.Text+"\n"+" where ID=1");
            cm.Connection = con;
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                correctanswer = dr.GetValue(4).ToString();

            }
            dr.Close();
            con.Close();
            SqlCommand cm1 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo."+"\n"+label2.Text+"\n"+ "where ID=2");
            cm1.Connection = con;
            con.Open();
            SqlDataReader dr1 = cm1.ExecuteReader();
            if (dr1.Read())
            {
                correctanswer1 = dr1.GetValue(4).ToString();

            }
            dr1.Close();
            con.Close();
            SqlCommand cm2 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo." +"\n"+label2.Text+"\n"+" where ID=3");
            cm2.Connection = con;
            con.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            if (dr2.Read())
            {
                correctanswer2 = dr2.GetValue(4).ToString();

            }
            dr2.Close();
            con.Close();
            SqlCommand cm3 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo."+"\n"+label2.Text+" where ID=4");
            cm3.Connection = con;
            con.Open();
            SqlDataReader dr3 = cm3.ExecuteReader();
            if (dr3.Read())
            {
                correctanswer3 = dr3.GetValue(4).ToString();

            }
            dr3.Close();
            con.Close();
            SqlCommand cm4 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo." +"\n"+ label2.Text+"\n"+ "where ID=5");
            cm4.Connection = con;
            con.Open();
            SqlDataReader dr4 = cm4.ExecuteReader();
            if (dr4.Read())
            {
                correctanswer4 = dr4.GetValue(4).ToString();

            }
            dr1.Close();
            con.Close();
            SqlCommand cm5 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo." + "\n" + label2.Text + "\n" + "where ID=6");
            cm5.Connection = con;
            con.Open();
            SqlDataReader dr5 = cm5.ExecuteReader();
            if (dr5.Read())
            {
                correctanswer5 = dr5.GetValue(4).ToString();

            }
            dr5.Close();
            con.Close();
            SqlCommand cm6 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM  dbo." + "\n" + label2.Text + "\n" + "where ID=7");
            cm6.Connection = con;
            con.Open();
            SqlDataReader dr6 = cm6.ExecuteReader();
            if (dr6.Read())
            {
                correctanswer6 = dr6.GetValue(4).ToString();

            }
            dr6.Close();
            con.Close();
            SqlCommand cm7 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo." + "\n" + label2.Text + "\n" + "where ID=8");
            cm7.Connection = con;
            con.Open();
            SqlDataReader dr7 = cm7.ExecuteReader();
            if (dr7.Read())
            {
                correctanswer7 = dr7.GetValue(4).ToString();

            }
            dr7.Close();
            con.Close();
            SqlCommand cm8 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM  dbo." + "\n" + label2.Text + "\n" + "where ID=9");
            cm8.Connection = con;
            con.Open();
            SqlDataReader dr8 = cm8.ExecuteReader();
            if (dr8.Read())
            {
                correctanswer8 = dr8.GetValue(4).ToString();

            }
            dr8.Close();
            con.Close();
            SqlCommand cm9 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo." + "\n" + label2.Text + "\n" + "where ID=10");
            cm9.Connection = con;
            con.Open();
            SqlDataReader dr9 = cm9.ExecuteReader();
            if (dr9.Read())
            {
                correctanswer9 = dr9.GetValue(4).ToString();

            }
            dr9.Close();
            con.Close();

            if (radioButton1.Checked == true)
            {
                if (radioButton1.Text == correctanswer)
                {
                    score++;
                }
            }
            if (radioButton3.Checked == true)
            {
                if (radioButton3.Text == correctanswer1)
                {
                    score++;
                }
            }
            if (radioButton2.Checked == true)
            {
                if (radioButton2.Text == correctanswer2)
                {
                    score++;
                }
            }
            if (radioButton3.Checked == true)
            {
                if (radioButton3.Text == correctanswer3)
                {
                    score++;
                }
            }
            if (radioButton4.Checked == true)
            {
                if (radioButton4.Text == correctanswer4)
                {
                    score++;
                }
            }
            if (radioButton2.Checked == true)
            {
                if (radioButton2.Text == correctanswer5)
                {
                    score++;
                }
            }
            if (radioButton2.Checked == true)
            {
                if (radioButton2.Text == correctanswer6)
                {
                    score++;
                }
            }
            if (radioButton3.Checked == true)
            {
                if (radioButton3.Text == correctanswer7)
                {
                    score++;
                }
            }
            if (radioButton1.Checked == true)
            {
                if (radioButton1.Text == correctanswer8)
                {
                    score++;
                }
            }
            if (radioButton3.Checked == true)
            {
                if (radioButton3.Text == correctanswer9)
                {
                    score++;
                }
            }


            MessageBox.Show("Answer Submitted");





        }



        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
          



        }
      
        private void Form16_Load(object sender, EventArgs e)
        {
           
           

            label2.Text = f.bunifuMaterialTextbox3.Text;
            timer1.Start();

            _monitoring = false;
            _capture = new Capture(0);
            bunifuMaterialTextbox3.Text = f.bunifuMaterialTextbox2.Text;
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

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Close();

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
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

        private void radioButton6_TextChanged(object sender, EventArgs e)
        {



        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {


        }
        private void askqQuestion(int qnum)
        {

        }


        private void Form16_Click(object sender, EventArgs e)
        {


           
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {



            if (radioButton5.Checked == true)
            {

                radioButton1.ForeColor = Color.Blue;
                radioButton2.ForeColor = Color.DarkGreen;
                radioButton3.ForeColor = Color.Purple;
                radioButton4.ForeColor = Color.Aqua;
                radioButton5.Checked = false;


            }
               
            try
            {


                radioButton5.Enabled = false;
                
                pictureBox2.Image = pictureBox1.Image;
                SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
                con1.Open();
                if (radioButton5.Text != "")
                {
                    SqlCommand cm1 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo." + "\n" + label2.Text + "\n" + "where ID=1");
                    cm1.Connection = con1;

                    SqlDataReader dr = cm1.ExecuteReader();
                    while (dr.Read())
                    {
                        label4.Text = dr.GetValue(0).ToString();

                        radioButton1.Text = dr.GetValue(4).ToString();
                        radioButton2.Text = dr.GetValue(2).ToString();
                        radioButton3.Text = dr.GetValue(3).ToString();
                        radioButton4.Text = dr.GetValue(1).ToString();





                    }
                    dr.Close();
                    cm1.ExecuteNonQuery();
                    con1.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                radioButton12.Enabled = false;
              
                pictureBox2.Image = pictureBox1.Image;
                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
                con2.Open();
                if (radioButton12.Text != "")
                {
                    SqlCommand cm2 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo." + "\n" + label2.Text + "\n" + "where ID=2");
                    cm2.Connection = con2;

                    SqlDataReader dr = cm2.ExecuteReader();
                    while (dr.Read())
                    {
                        label4.Text = dr.GetValue(0).ToString();
                        radioButton1.Text = dr.GetValue(1).ToString();
                        radioButton2.Text = dr.GetValue(2).ToString();
                        radioButton3.Text = dr.GetValue(4).ToString();
                        radioButton4.Text = dr.GetValue(3).ToString();

                    }
                    dr.Close();
                    cm2.ExecuteNonQuery();
                    con2.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                radioButton10.Enabled = false;
               
                pictureBox2.Image = pictureBox1.Image;
                SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
                con3.Open();
                if (radioButton10.Text != "")
                {
                    SqlCommand cm3= new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo." + "\n" + label2.Text + "\n" + "where ID=3");
                    cm3.Connection = con3;

                    SqlDataReader dr = cm3.ExecuteReader();
                    while (dr.Read())
                    {
                        label4.Text = dr.GetValue(0).ToString();
                        radioButton1.Text = dr.GetValue(1).ToString();
                        radioButton2.Text = dr.GetValue(4).ToString();
                        radioButton3.Text = dr.GetValue(3).ToString();
                        radioButton4.Text = dr.GetValue(2).ToString();



                    }
                    dr.Close();
                    cm3.ExecuteNonQuery();
                    con3.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                radioButton11.Enabled = false;
              
                pictureBox2.Image = pictureBox1.Image;
                SqlConnection con4 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
                con4.Open();
                if (radioButton11.Text != "")
                {
                    SqlCommand cm4 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo." + "\n" + label2.Text + "\n" + "where ID=4");
                    cm4.Connection = con4;

                    SqlDataReader dr = cm4.ExecuteReader();
                    while (dr.Read())
                    {

                        label4.Text = dr.GetValue(0).ToString();
                        radioButton1.Text = dr.GetValue(3).ToString();
                        radioButton2.Text = dr.GetValue(2).ToString();
                        radioButton3.Text = dr.GetValue(4).ToString();
                        radioButton4.Text = dr.GetValue(1).ToString();



                    }
                    dr.Close();
                    cm4.ExecuteNonQuery();
                    con4.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
           
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                radioButton9.Enabled = false;
               
                pictureBox2.Image = pictureBox1.Image;
                SqlConnection con5 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
                con5.Open();
                if (radioButton9.Text != "")
                {
                    SqlCommand cm5 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo." + "\n" + label2.Text + "\n" + "where  ID=5");
                    cm5.Connection = con5;

                    SqlDataReader dr = cm5.ExecuteReader();
                    while (dr.Read())
                    {

                        label4.Text = dr.GetValue(0).ToString();
                        radioButton1.Text = dr.GetValue(3).ToString();
                        radioButton2.Text = dr.GetValue(1).ToString();
                        radioButton3.Text = dr.GetValue(2).ToString();
                        radioButton4.Text = dr.GetValue(4).ToString();

                    }
                    dr.Close();
                    cm5.ExecuteNonQuery();
                    con5.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                radioButton8.Enabled = false;
               

                pictureBox2.Image = pictureBox1.Image;
                SqlConnection con6 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
                con6.Open();
                if (radioButton8.Text != "")
                {
                    SqlCommand cm6 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo." + "\n" + label2.Text + "\n" + " where ID=6");
                    cm6.Connection = con6;

                    SqlDataReader dr = cm6.ExecuteReader();
                    while (dr.Read())
                    {

                        label4.Text = dr.GetValue(0).ToString();
                        radioButton1.Text = dr.GetValue(1).ToString();
                        radioButton2.Text = dr.GetValue(4).ToString();
                        radioButton3.Text = dr.GetValue(3).ToString();
                        radioButton4.Text = dr.GetValue(2).ToString();





                    }
                    dr.Close();
                    cm6.ExecuteNonQuery();
                    con6.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                radioButton7.Enabled = false;
              
                pictureBox2.Image = pictureBox1.Image;
                SqlConnection con7 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
                con7.Open();
                if (radioButton7.Text != "")
                {
                    SqlCommand cm7 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo." + "\n" + label2.Text + "\n" + "where ID=7");
                    cm7.Connection = con7;

                    SqlDataReader dr = cm7.ExecuteReader();
                    while (dr.Read())
                    {

                        label4.Text = dr.GetValue(0).ToString();
                        radioButton1.Text = dr.GetValue(1).ToString();
                        radioButton2.Text = dr.GetValue(4).ToString();
                        radioButton3.Text = dr.GetValue(3).ToString();
                        radioButton4.Text = dr.GetValue(2).ToString();



                    }
                    dr.Close();
                    cm7.ExecuteNonQuery();
                    con7.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                radioButton6.Enabled = false;
               
                pictureBox2.Image = pictureBox1.Image;
                SqlConnection con8 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
                con8.Open();
                if (radioButton6.Text != "")
                {
                    SqlCommand cm8 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo." + "\n" + label2.Text + "\n" + "where ID=8");
                    cm8.Connection = con8;

                    SqlDataReader dr = cm8.ExecuteReader();
                    while (dr.Read())
                    {

                        label4.Text = dr.GetValue(0).ToString();
                        radioButton1.Text = dr.GetValue(2).ToString();
                        radioButton2.Text = dr.GetValue(1).ToString();
                        radioButton3.Text = dr.GetValue(4).ToString();
                        radioButton4.Text = dr.GetValue(3).ToString();


                    }
                    dr.Close();
                    cm8.ExecuteNonQuery();
                    con8.Close();

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
          
        }

        private void Form16_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                radioButton13.Enabled = false;
              
                pictureBox2.Image = pictureBox1.Image;
                SqlConnection con9 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
                con9.Open();
                if (radioButton5.Text != "")
                {
                    SqlCommand cm9= new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo." + "\n" + label2.Text + "\n" + "where ID=9");
                    cm9.Connection = con9;

                    SqlDataReader dr = cm9.ExecuteReader();
                    while (dr.Read())
                    {
                        label4.Text = dr.GetValue(0).ToString();

                        radioButton1.Text = dr.GetValue(4).ToString();
                        radioButton2.Text = dr.GetValue(2).ToString();
                        radioButton3.Text = dr.GetValue(3).ToString();
                        radioButton4.Text = dr.GetValue(1).ToString();





                    }
                    dr.Close();
                    cm9.ExecuteNonQuery();
                    con9.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                radioButton14.Enabled = false;
                
                pictureBox2.Image = pictureBox1.Image;
                SqlConnection con10 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
                con10.Open();
                if (radioButton5.Text != "")
                {
                    SqlCommand cm10 = new SqlCommand("SELECT questions,option1,option2,option3,option4 FROM dbo." + "\n" + label2.Text + "\n" + "where ID=10");
                    cm10.Connection = con10;

                    SqlDataReader dr = cm10.ExecuteReader();
                    while (dr.Read())
                    {
                        label4.Text = dr.GetValue(0).ToString();

                        radioButton1.Text = dr.GetValue(1).ToString();
                        radioButton2.Text = dr.GetValue(2).ToString();
                        radioButton3.Text = dr.GetValue(4).ToString();
                        radioButton4.Text = dr.GetValue(3).ToString();





                    }
                    dr.Close();
                    cm10.ExecuteNonQuery();
                    con10.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
         
            DialogResult dr = MessageBox.Show("End Exam", "Are You Sure You Wants To End Exam", MessageBoxButtons.YesNo);
            percentage = (int)Math.Round((double)(score * 100) / 10);
           
            if (dr == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[cplusscoreboard]
            ([Enroll]
           ,[score]
           ,[percentage])
         VALUES
            ('" + bunifuMaterialTextbox3.Text + "','" + score + "','" + percentage + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
              
                MessageBox.Show(
               "Exam Ended!" + "\n" +
               "Your score and Percentage is " + score+"\n"+ "and"+"\n"+ percentage);
               
                Form1 f1=new Form1();
                f1.Show();
                this.Hide();
            }
            else if (dr == DialogResult.No)
            {

            }
            
        }
       
        
       
        private void label5_Click(object sender, EventArgs e)
        {
           
        }
        int timer=1800;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
          

            if (timer > 0)
            {
              
                timer = timer - 1;
                MyTimer.Text =timer + "Seconds";

            }
            else
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("Time End", "You Ran Out Of Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();
                }
                    
                
            }
           
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
           

           
            
            
           
            
        }

        private void radioButton5_Enter(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                radioButton5.Checked = false;
            }
        }
    }
}