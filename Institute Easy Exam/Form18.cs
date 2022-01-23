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
    public partial class Form18 : Form
    {
        Form29 f29;
       
        public Form18(Form29 frm29)
        {
            InitializeComponent();
            this.f29 = frm29;
            
           
        }
        

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "")
            {
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox2.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox3_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox3.Text == "")
            {
                bunifuMaterialTextbox3.Text = "";
                bunifuMaterialTextbox3.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox3_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox3.Text == "")
            {
                bunifuMaterialTextbox3.Text = "";
                bunifuMaterialTextbox3.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox4_Enter(object sender, EventArgs e)
        {

            if (bunifuMaterialTextbox4.Text == "")
            {
                bunifuMaterialTextbox4.Text = "";
                bunifuMaterialTextbox4.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox4_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.Text == "")
            {
                bunifuMaterialTextbox4.Text = "";
                bunifuMaterialTextbox4.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox5_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox5.Text == "Your Correct Answer")
            {
                bunifuMaterialTextbox5.Text = "";
                bunifuMaterialTextbox5.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox5_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox5.Text == "")
            {
                bunifuMaterialTextbox5.Text = "Your Correct Answer";
                bunifuMaterialTextbox5.ForeColor = Color.Black;
            }
        }

       
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text != string.Empty || bunifuMaterialTextbox2.Text != string.Empty || bunifuMaterialTextbox3.Text != string.Empty || bunifuMaterialTextbox4.Text != string.Empty || bunifuMaterialTextbox5.Text != string.Empty)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = mcqset1; Integrated Security = True"))
                using (var command = con.CreateCommand())
                {

                    con.Open();

                    command.CommandText = "INSERT INTO dbo." +"\n"+ label1.Text +"\n"+ "([questions],[option1],[option2],[option3],[option4]) VALUES ('" + bunifuMaterialTextbox1.Text + "','" + bunifuMaterialTextbox2.Text + "','" + bunifuMaterialTextbox3.Text + "','" + bunifuMaterialTextbox4.Text + "','" + bunifuMaterialTextbox5.Text + "')";
                   
                    command.ExecuteNonQuery();

                   
                    bunifuMaterialTextbox1.Text = "";
                    bunifuMaterialTextbox2.Text = "";
                    bunifuMaterialTextbox3.Text = "";
                    bunifuMaterialTextbox4.Text = "";
                    bunifuMaterialTextbox5.Text = "";



                    con.Close();
                    MessageBox.Show("Answer Submitted","Successfully",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                }

            }
            else
            {

                MessageBox.Show("Fill All Fields","Fill",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           








        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Form18_Load(object sender, EventArgs e)
        {
            label1.Text = f29.bunifuMaterialTextbox1.Text;
            label3.Text = f29.bunifuMaterialTextbox2.Text;
           
            

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Close();
        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {
          
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }
    }
}
