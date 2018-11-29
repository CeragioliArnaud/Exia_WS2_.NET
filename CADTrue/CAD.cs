using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CADTrue
{
    public class CAD
    {

        public string conString = @"Data Source=HOLYANDER\SQL2016;Initial Catalog=CESI_3eAnnee;Integrated Security=True";

        private SqlConnection Connect()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            return con;
        }

        public DataSet ExecuteReq(string requête, string table)
        {
             var adapter = new SqlDataAdapter(requête, Connect());
             var dataset = new DataSet();
             adapter.Fill(dataset, table);
             return dataset;
        }
    }
}
