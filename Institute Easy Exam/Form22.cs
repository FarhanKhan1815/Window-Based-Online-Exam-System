using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institute_Easy_Exam
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mcqset2DataSet3.java_percentage' table. You can move, or remove it, as needed.
            this.java_percentageTableAdapter1.Fill(this.mcqset2DataSet3.java_percentage);
           
            dataGridView1.RowTemplate.Height = 120;
           

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

            Form9 f9 = new Form9();
            f9.Show();
            this.Close();
        }
    }
}
