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
using Bunifu.Framework;
using Bunifu.Framework.UI;


namespace Institute_Easy_Exam
{

    public partial class Form15 : Form
    {

        public Form15()
        {
            InitializeComponent();

        }


        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True"))
                {
                    using (var command = con.CreateCommand())
                    {
                        con.Open();


                        command.CommandText = @"INSERT INTO[dbo].[samplemcq]
            
                       ([questions] 
                       ,[option1]
                       ,[option2]
                       ,[option3]
                       ,[option4]
                      
                         )
                        VALUES
                           ('" + bunifuMaterialTextbox1.Text + "','" + bunifuMaterialTextbox2.Text + "','" + bunifuMaterialTextbox3.Text + "','" + bunifuMaterialTextbox4.Text + "','" + bunifuMaterialTextbox5.Text + "')";
                        command.ExecuteNonQuery();

                        command.CommandText = @"INSERT INTO[dbo].[Answer]
            
                       ([Correctanswer]
                         )
                        VALUES
                           ('" + bunifuMaterialTextbox5.Text + "')";
                        command.ExecuteNonQuery();

                    }
                    con.Close();
                    bunifuMaterialTextbox1.Text = "";
                    bunifuMaterialTextbox2.Text = "";
                    bunifuMaterialTextbox3.Text = "";
                    bunifuMaterialTextbox4.Text = "";
                    bunifuMaterialTextbox5.Text = "";







                }

            
            MessageBox.Show("Question Added");
        }
         
            
           
            
           











        
           

            
            
        

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {


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
            if (bunifuMaterialTextbox2.Text == "")
            {
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox2.ForeColor = Color.Black;
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
            if (bunifuMaterialTextbox5.Text == "")
            {
                bunifuMaterialTextbox5.Text = "";
                bunifuMaterialTextbox5.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox5_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox5.Text == "")
            {
                bunifuMaterialTextbox5.Text = "";
                bunifuMaterialTextbox5.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }
    } 
}
