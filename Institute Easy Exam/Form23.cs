using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Institute_Easy_Exam
{
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void Form23_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mcqset1DataSet12.cplusscoreboard' table. You can move, or remove it, as needed.
            this.cplusscoreboardTableAdapter1.Fill(this.mcqset1DataSet12.cplusscoreboard);


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Close();
        }
    }
}
