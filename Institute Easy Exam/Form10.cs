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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (bunifuMaterialTextbox1.Text != string.Empty && bunifuMaterialTextbox2.Text != string.Empty)
                {

                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=college;Integrated Security=True");
                    SqlDataAdapter adapter = new SqlDataAdapter("Select COUNT (*) from institute where proid='" + bunifuMaterialTextbox1.Text + "' and password='" + bunifuMaterialTextbox2.Text + "'", con);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {

                        MessageBox.Show("Successfully Login as a Principal!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        Form3 f = new Form3(this);
                        f.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Institute Code and Pasword is incorrect","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please Fill All Fields","Fill",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox1.Text== "Enter College ID")
            {
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.ForeColor=Color.Black;
            }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "Enter College ID";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
                
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "")
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
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox2.ForeColor = Color.Black;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
