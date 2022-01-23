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
using System.Configuration;

namespace Institute_Easy_Exam
{
    public partial class Form17 : Form
    {
        Form4 f4;
       
        SqlDataAdapter sda;
        DataSet ds;
        SqlCommandBuilder cb;
        int record_id;
        public Form17(Form4 frm4)
        {
            InitializeComponent();
            this.f4 = frm4;
        }
        DataTable table = new DataTable();
        DataRow dr;
        private void Form17_Load(object sender, EventArgs e)
        {
           
            try
            {
                SqlConnection con11 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
                con11.Open();
                sda = new SqlDataAdapter("select ID, questions,option1,option2,option3,option4 from dbo." + "\n" + f4.bunifuMaterialTextbox1.Text, con11);
                ds = new System.Data.DataSet();
                sda.Fill(ds,"tables");
                dataGridView1.DataSource = ds.Tables[0];
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox7.Text = "";
                bunifuMaterialTextbox3.Text = "";
                bunifuMaterialTextbox4.Text = "";
                bunifuMaterialTextbox5.Text = "";
                bunifuMaterialTextbox6.Text = "";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from dbo." + "\n" + f4.bunifuMaterialTextbox1.Text, con);
            con.Open();
            label5.Text = f4.bunifuMaterialTextbox1.Text;

            string query = "SELECT * FROM dbo." + "\n" + f4.bunifuMaterialTextbox1.Text;
            cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;
            dataGridView1.AllowUserToAddRows = false;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            record_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            bunifuMaterialTextbox7.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            bunifuMaterialTextbox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            bunifuMaterialTextbox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            bunifuMaterialTextbox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            bunifuMaterialTextbox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
            SqlCommand cmd;
            con.Open();
            cmd = new SqlCommand("update dbo." + "\n" + f4.bunifuMaterialTextbox1.Text +"\n"+ "set questions='" + bunifuMaterialTextbox7.Text + "',option1='" + bunifuMaterialTextbox3.Text + "',option2='" + bunifuMaterialTextbox4.Text + "',option3='" + bunifuMaterialTextbox5.Text + "',option4='" + bunifuMaterialTextbox6.Text + "' where ID='" + record_id + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has successfully Updated","Updated",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            con.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
            
            SqlCommand cmds;
            con.Open();
            cmds = new SqlCommand("delete from dbo." + "\n" + f4.bunifuMaterialTextbox1.Text + "\n" + "where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "", con);
            cmds.ExecuteNonQuery();
            MessageBox.Show("Record deleted Successfully","Deleted",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            con.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            SqlConnection con22 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=mcqset1;Integrated Security=True");
            SqlCommand cmds;
            con22.Open();
            cmds = new SqlCommand("insert into dbo." + "\n" + f4.bunifuMaterialTextbox1.Text + "\n" + "([questions],[option1],[option2],[option3],[option4]) VALUES('" + bunifuMaterialTextbox7.Text + "','" + bunifuMaterialTextbox3.Text + "','" + bunifuMaterialTextbox4.Text + "','" + bunifuMaterialTextbox5.Text + "','" + bunifuMaterialTextbox6.Text + "')",con22);
            cmds.ExecuteNonQuery();
            con22.Close();
            MessageBox.Show("Question Added Successfully!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);





            
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Close();
        }
    }
}
