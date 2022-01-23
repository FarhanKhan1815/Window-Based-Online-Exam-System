using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Institute_Easy_Exam
{
    class Subject

    {
        internal int branchid;

        public SqlConnection GetConnection()
        {

            return new SqlConnection()
            {
                ConnectionString = "server=(LocalDBdatabase=dropdown;Integrated Security=true"
            };
        }
    }
}
