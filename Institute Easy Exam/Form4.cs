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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form29 f29 = new Form29();
            f29.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            string tblnm = bunifuMaterialTextbox1.Text;
            string str = @"IF EXISTS(
                SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
                WHERE TABLE_NAME = @table) 
                SELECT 1 ELSE SELECT 0";
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = mcqset1; Integrated Security = True");
                SqlCommand c = new SqlCommand(str, con);
                con.Open();
                c.Parameters.Add("@table", SqlDbType.NVarChar).Value = tblnm;
                int exists = (int)c.ExecuteScalar();
                if (exists == 1)
                {
                    Form17 f17 = new Form17(this);
                    f17.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Subject doesn't exists");
                }

                c.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
                
            
            

 
        }
       

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Form19 f19 = new Form19();
            f19.Show();
            this.Hide();
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox1.Text== "Enter Subject name")
            {
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "Enter Subject name";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
                
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Close();
        }
    }
}
