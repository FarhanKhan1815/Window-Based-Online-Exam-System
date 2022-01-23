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
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void Form27_Load(object sender, EventArgs e)
        {
            string[] file = Directory.GetFiles(@"C:\Java stud pic");
            DataTable dt = new DataTable();
            dt.Columns.Add("File name");
            for (int i = 0; i < file.Length; i++)
            {
                FileInfo files = new FileInfo(file[i]);
                dt.Rows.Add(files.Name);
            }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form14 fm = new Form14();
            string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Image img;
            img = Image.FromFile(@"C:\Java stud pic\" + name);
            fm.pictureBox1.Image = img;
            fm.ShowDialog();
        }
    }
}
