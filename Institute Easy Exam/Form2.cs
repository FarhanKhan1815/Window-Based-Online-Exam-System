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
    public partial class Form2 : Form
    {
        public Form2()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = college; Integrated Security = True");
        public void proid()
        {
            string proid;
            string query = "select proid from institute order by proid Desc";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                proid = id.ToString("00000");
            }
            else if (Convert.IsDBNull(dr))
            {
                proid = ("00000");
            }
            else
            {
                proid = ("00000");
            }
            con.Close();
            bunifuMaterialTextbox4.Text = proid.ToString();
        }
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox2.Text!=bunifuMaterialTextbox5.Text)
            {
                MessageBox.Show("Incorrect  Password","Invalid Password",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
           
           else if (bunifuMaterialTextbox3.Text!=string.Empty|| bunifuMaterialTextbox1.Text!=string.Empty || bunifuMaterialTextbox4.Text!=string.Empty || bunifuMaterialTextbox2.Text!=string.Empty )
            
            {
                MessageBox.Show("Registered Successfully","Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else
            {
                MessageBox.Show("Please fill All Fields..!","Fill",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
                
            }
           
            
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=college;Integrated Security=True ");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[institute]
            ([institutecode] 
            ,[institutename]
            ,[proid]
            ,[password])
          VALUES
               ('" + bunifuMaterialTextbox3.Text + "','" + bunifuMaterialTextbox1.Text + "','" +bunifuMaterialTextbox4.Text + "','"+bunifuMaterialTextbox2.Text+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox2.Text = "";
            bunifuMaterialTextbox3.Text = "";
           
            bunifuMaterialTextbox5.Text = "";







        }

        private void Form2_Load(object sender, EventArgs e)
        {
            proid();
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
            Form1 f = new Form1();
            f.Show();
            this.Hide();
            
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox3_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox3.Text== "Enter Your Institute Code")
            {
                bunifuMaterialTextbox3.Text = "";
                bunifuMaterialTextbox3.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox3_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox3.Text == "")
            {
                bunifuMaterialTextbox3.Text = "Enter Your Institute Code";
                bunifuMaterialTextbox3.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox1.Text== "Enter Your Institute Name")
            {
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "Enter Your Institute Name";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox2.Text== "")
            {
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox2.ForeColor = Color.Black;
                bunifuMaterialTextbox2.isPassword = true;
            }
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "")
            {
                bunifuMaterialTextbox2.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox5_Enter(object sender, EventArgs e)
        {
            bunifuMaterialTextbox5.isPassword = true;
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 f11 = new Form1();
            f11.Show();
            this.Close();
        }
    }
}
