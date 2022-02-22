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
            List<string> ret = new List<string>();

            try
            {
                con = new SqlConnection(connection);

                DataSet ds = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from TrialTable", con);
                sqlDataAdapter.Fill(ds);

                

                foreach (DataRow x in ds.Tables[0].Rows)
                {
                    ret.Add(x[1].ToString());
                }

            }
            catch (Exception err)
            {
                ret.Add(err.Message);
            }
            return ret;
        }
    }
}
