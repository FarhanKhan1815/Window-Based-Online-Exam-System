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

namespace Institute_Easy_Exam
{
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text != string.Empty || bunifuMaterialTextbox2.Text != string.Empty || bunifuMaterialTextbox3.Text != string.Empty || bunifuMaterialTextbox4.Text != string.Empty || bunifuMaterialTextbox5.Text != string.Empty)

            {
                MessageBox.Show("Questions Added Successfully");
            }
            else
            {
                MessageBox.Show("Please fill All Fields..!");
            }

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset2;Integrated Security=True ");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[java_questions]
            ([questions] 
            ,[option1]
            ,[option2]
            ,[option3]
            ,[option4]
            )
          VALUES
               ('" + bunifuMaterialTextbox1.Text + "','" + bunifuMaterialTextbox2.Text + "','" + bunifuMaterialTextbox3.Text + "','" + bunifuMaterialTextbox4.Text + "','" + bunifuMaterialTextbox5.Text + "')", con);
            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox2.Text = "";
            bunifuMaterialTextbox3.Text = "";
            bunifuMaterialTextbox4.Text = "";
            bunifuMaterialTextbox5.Text = "";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Form24_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox1.Text== "Which of the following is the correct identifier?")
            {
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void Form24_Leave(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox1.Text=="")
            {
                bunifuMaterialTextbox1.Text = "Which of the following is the correct identifier?";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox1.Text== "")
            {
                bunifuMaterialTextbox1.Text = "Which of the following is the correct identifier?";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox2.Text=="Option 1")
            {
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox2.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox2.Text=="")
            {
                bunifuMaterialTextbox2.Text = "Option 1";
                bunifuMaterialTextbox2.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox3_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox3.Text == "Option2")
            {
                bunifuMaterialTextbox3.Text = "";
                bunifuMaterialTextbox3.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox3_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox3.Text == "")
            {
                bunifuMaterialTextbox3.Text = "Option2";
                bunifuMaterialTextbox3.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox4_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.Text == "Option3")
            {
                bunifuMaterialTextbox4.Text = "";
                bunifuMaterialTextbox4.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox4_Leave(object sender, EventArgs e)
        {

            if (bunifuMaterialTextbox4.Text == "")
            {
                bunifuMaterialTextbox4.Text = "Option3";
                bunifuMaterialTextbox4.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox5_Enter(object sender, EventArgs e)
        {

            if (bunifuMaterialTextbox5.Text == "Option4")
            {
                bunifuMaterialTextbox5.Text = "";
                bunifuMaterialTextbox5.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox5_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox5.Text == "")
            {
                bunifuMaterialTextbox5.Text = "Option4";
                bunifuMaterialTextbox5.ForeColor = Color.Black;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
