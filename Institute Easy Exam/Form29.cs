using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Configuration;
namespace Institute_Easy_Exam
{
    public partial class Form29 : Form
    {
        public Form29()
        {
            InitializeComponent();
        }
        private string getConnection()
        {
            return
            System.Configuration.ConfigurationManager.ConnectionStrings["Institute_Easy_Exam.Properties.Settings.mcqset1ConnectionString"].ConnectionString;
        }
        public bool DeleteData(string TableName)
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
                    MessageBox.Show("Entered Subject is Already Exists","Existed",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                    
                }
                else
                {
                    Form18 f18 = new Form18(this);
                    f18.Show();
                    this.Hide();
                }

                c.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox2.Text = "";
            try
            {
                SqlConnection con = new SqlConnection(getConnection());
                con.Open();
                string sqlstatement = "CREATE TABLE dbo." + TableName + "(ID int IDENTITY(1,1) PRIMARY KEY ,questions varchar(100), option1 varchar(50),option2 varchar(50),option3 varchar(50),option4 varchar(50))";




                SqlCommand cmd = new SqlCommand(sqlstatement, con);
                cmd.ExecuteNonQuery();
                con.Close();
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
          
        }
        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
           

            if(bunifuMaterialTextbox1.Text=="Enter which Subject You Wants To Add Questions")
            {
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }

        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "Enter which Subject You Wants To Add Questions";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            if (bunifuMaterialTextbox2.Text != string.Empty)
            {
                int no = int.Parse(bunifuMaterialTextbox2.Text);
            }
            else
            {
                MessageBox.Show("Please Enter How many questions you wants to add");
            }
            string a = bunifuMaterialTextbox1.Text;
            DeleteData(a);
          

           

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void Form29_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
