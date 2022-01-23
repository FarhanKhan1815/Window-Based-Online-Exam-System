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
using System.Drawing.Imaging;






namespace Institute_Easy_Exam
{
    public partial class Form7 : Form
    {
        Form8 f8;
        bool _monitoring;
        Capture _capture;
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestion;
        string submittedanswer;
        List<int> questionnumber = new List<int> { 1, 2, 3 };
        int i;
        int count;
        public Form7(Form8 frm8)
        {

            InitializeComponent();
            askqQuestion(questionNumber);
            totalQuestion = 8;
            this.f8 = frm8;
           


        }

       

        private void checkAnswerEvent(object sender, EventArgs e)
        {


        }
        private void askqQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    bunifuMaterialTextbox2.Text = "Which of the following converts the expression to Byte data ";
                    radioButton1.Text = "CBool(expression)";
                    radioButton2.Text = "CByte(expression)";
                    radioButton3.Text = "CChar(expression)";
                    radioButton4.Text = "CDate(expression)";

                    correctAnswer = 2;
                    break;

                case 2:
                    bunifuMaterialTextbox2.Text = "Which of the following converts the expression to String data";
                    radioButton1.Text = "CStr(expression)";
                    radioButton2.Text = "CSByte(expression)";
                    radioButton3.Text = "CShort(expression)";
                    radioButton4.Text = "CSng(expression)";

                    correctAnswer = 1;
                    break;

                case 3:
                    bunifuMaterialTextbox2.Text = "Which of the following accesss modifier specifies that a function or Get accessor is an iterator? ";
                    radioButton1.Text = "In";
                    radioButton2.Text = "Iterator";
                    radioButton3.Text = "Key";
                    radioButton4.Text = "Module";

                    correctAnswer = 2;
                    break;

                




            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {



            



            _monitoring = false;
            _capture = new Capture(0);
            bunifuMaterialTextbox1.Text = f8.bunifuMaterialTextbox2.Text;
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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = mcqset2; Integrated Security = True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[java_percentage]
            ([percentage]
            ,[Enroll]
            
            )
         VALUES
            ('" + percentage + "','" + bunifuMaterialTextbox1.Text+"')", con);
            

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your Percentage is" + percentage);


           
        }
      




        private void monitoring(object sender, System.EventArgs e)
        {

            var img = _capture.QueryFrame().ToImage<Bgr, Byte>();
            var bmp = img.Bitmap;
            pictureBox1.Image = bmp;
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
       
       private void NextQuestion()
        {
            if (questionNumber < questionnumber.Count)
            {
                i = questionnumber[questionNumber];
            }
        }

       
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

        
        



        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void myButton_Click_1(object sender, EventArgs e)
        {
            if (questionNumber == totalQuestion)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestion);
                MessageBox.Show("Exam Ended!" + Environment.NewLine +
                    "You have Answered" + score + "questions Correctly!" + Environment.NewLine +
                   "Click Ok To Start Your Exam");
                score = 0;
                questionNumber = 0;
                askqQuestion(questionNumber);

            }
            questionNumber++;
            askqQuestion(questionNumber);
        }

        private void Form7_Click(object sender, EventArgs e)
        {
            var senderObject = (RadioButton)sender;
            int radiobuttonTag = Convert.ToInt32(senderObject.Tag);
            if (radiobuttonTag == correctAnswer)
            {
                score++;


            }
        }

        private void radioButton(object sender, EventArgs e)
        {
            var senderObject = (RadioButton)sender;
            int radiobuttonTag = Convert.ToInt32(senderObject.Tag);
            if (radiobuttonTag == correctAnswer)
            {
                score++;


            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
          
            if (questionNumber == totalQuestion)
            {
               

                percentage = (int)Math.Round((double)(score * 100) / totalQuestion);

                MessageBox.Show(
                    "Exam Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine 
                     + Environment.NewLine);
                
                score = 0;
                questionNumber = 0;
                askqQuestion(questionNumber);

            }
            questionNumber++;
            askqQuestion(questionNumber);
        }


        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;

           
        }
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;

        }
    }
}