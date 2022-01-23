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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void Form26_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mcqset2DataSet1.java_percentage' table. You can move, or remove it, as needed.
            this.java_percentageTableAdapter.Fill(this.mcqset2DataSet1.java_percentage);

        }
    }
}
