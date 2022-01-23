using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Institute_Easy_Exam
{
    class returnclass
    {
        private string constring = ConfigurationManager.ConnectionStrings["Institute_Easy_Exam.Properties.Settings.mcqset1ConnectionString"].ConnectionString;
        public string scalarReturn(string q)
        {
            string s;
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(q, conn);
                s = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                s = " ";

            }
            conn.Close();
            return s;
        }
    }
}
