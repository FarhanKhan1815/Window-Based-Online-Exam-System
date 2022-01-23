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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "teacheremailid")
            {
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "teacheremailid";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "Password")
            {
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox2.ForeColor = Color.Black;
                bunifuMaterialTextbox2.isPassword = true;
            }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "teacheremailid";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }



        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text != string.Empty && bunifuMaterialTextbox2.Text != string.Empty)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=teacher signup;Integrated Security=True ");
                SqlDataAdapter adapter = new SqlDataAdapter("Select COUNT (*) from teacher where teacheremailid='" + bunifuMaterialTextbox1.Text + "' and password='" + bunifuMaterialTextbox2.Text + "'", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Form4 f4 = new Form4();
                    f4.Show();
                    this.Hide();
                    MessageBox.Show("Welcome" +"\n"+ bunifuMaterialTextbox1.Text);

                    

                }
                else
                {
                    MessageBox.Show("teacheremailid and password is incorrect","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();

        }
    }
}