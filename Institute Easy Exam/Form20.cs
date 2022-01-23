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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mcqset2DataSet.java_questions' table. You can move, or remove it, as needed.
            this.java_questionsTableAdapter.Fill(this.mcqset2DataSet.java_questions);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);

        }
    }
}
