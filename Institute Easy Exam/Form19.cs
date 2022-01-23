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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form21 f21 = new Form21();
            f21.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text != string.Empty && bunifuMaterialTextbox2.Text==string.Empty)
            {
                string tblnm = bunifuMaterialTextbox1.Text;
                string str = @"IF EXISTS(
                SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
                WHERE TABLE_NAME = @table) 
                SELECT 1 ELSE SELECT 0";
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = mcqset1; Integrated Security = True");
                    SqlCommand c = new SqlCommand(str, conn);
                    conn.Open();
                    c.Parameters.Add("@table", SqlDbType.NVarChar).Value = tblnm;
                    int exists = (int)c.ExecuteScalar();
                    if (exists == 1)
                    {
                        Form23 f23 = new Form23();
                        f23.Show();
                        this.Close();
                            


                    }
                    else
                    {
                        MessageBox.Show("Please Enter Correct Subject Name");
                    }

                    c.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (bunifuMaterialTextbox2.Text != string.Empty && bunifuMaterialTextbox1.Text==string.Empty)
            {

                string tblnm1 = bunifuMaterialTextbox2.Text;
                string str1 = @"IF EXISTS(
                SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
                WHERE TABLE_NAME = @table) 
                SELECT 1 ELSE SELECT 0";
                try
                {
                    SqlConnection conn1 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = mcqset2; Integrated Security = True");
                    SqlCommand c1 = new SqlCommand(str1, conn1);
                    conn1.Open();
                    c1.Parameters.Add("@table", SqlDbType.NVarChar).Value = tblnm1;
                    int exists1 = (int)c1.ExecuteScalar();
                    if (exists1 == 1)
                    {
                        Form22 f22 = new Form22();
                        f22.Show();
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("Please Enter Correct Subject Name");
                    }

                    c1.ExecuteNonQuery();
                    conn1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Any One Field");
            }
            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox2.Text = "";
           
           

        }
       

        private void Form19_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }
    }
}
