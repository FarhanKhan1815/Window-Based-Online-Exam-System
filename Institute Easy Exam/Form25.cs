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
using System.Data;
using System.Configuration;
using System.IO;

namespace Institute_Easy_Exam
{
    public partial class Form25 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Records; Integrated Security = True");
        SqlCommand cmd;
        
        public Form25()
        {
            InitializeComponent();
           
         
           
        }

        private void Form25_Load(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Exam";
            cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;
            dataGridView1.AllowUserToAddRows = false;
            da.Fill(dt);
           dataGridView1.DataSource = dt;
            
            
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView1.Columns[2];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
          


        }
       
    }
}
