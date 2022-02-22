using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace RepositoryCore
{
    public class PcgTrialRepository
    {
        private string connection = ConfigurationManager.ConnectionStrings["pcgtrialConnection"].ConnectionString;
        private SqlConnection con;
        public List<string> GetPcgTrial() {
            con = new SqlConnection(connection);
            
            DataSet ds = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from TrialTable", con);
            sqlDataAdapter.Fill(ds);

            List<string> ret = new List<string>();

            foreach (DataRow x in ds.Tables[0].Rows)
            {
                ret.Add(x[1].ToString());
            }

            return ret;
        }
    }
}
