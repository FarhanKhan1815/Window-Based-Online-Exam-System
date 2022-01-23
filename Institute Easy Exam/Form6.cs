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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Students")) Stud();
            if (comboBox1.Text.Equals("Teachers")) Teach();
            
        }
        void Stud()
        {

            Form8 f8 = new Form8(this);
            f8.Show();
            this.Close();
        }
        void Teach()
        {
            Form9 f = new Form9();
            f.Show();
            this.Close();

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
