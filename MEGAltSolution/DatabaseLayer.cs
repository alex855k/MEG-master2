using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAltSolution
{
    public class DatabaseLayer
    {
        private string SQLString;
        private string ConnectionString;
        SqlDataAdapter adapter;

        private getAllTeachers(string SPname)
        {
            DataSet ds = new DataSet("TimeRanges");
            using (SqlConnection conn = new SqlConnection("ConnectionString"))
            {
                SqlCommand sqlComm = new SqlCommand("Get", conn);
                sqlComm.Parameters.AddWithValue("@Start", StartTime);
                sqlComm.Parameters.AddWithValue("@Finish", FinishTime);
                sqlComm.Parameters.AddWithValue("@TimeRange", TimeRange);

                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;

                da.Fill(ds);
            }

        }
    }
}
