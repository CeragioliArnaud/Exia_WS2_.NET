using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CADTrue;

namespace MiddlewareTrue
{
    public class MiddlewareProcess
    {

        private CAD dataAccess = new CAD();

        public DataSet ChargerPersonnes()
        {
            return dataAccess.ExecuteReq("Select ID,Nom,Prenom from CESI", "CESI");
        }

        public DataSet AfficherParNom(string nom)
        {
            return dataAccess.ExecuteReq("Select ID,Nom,Prenom from CESI where nom='"+ nom +"'", "CESI");
        }

    }
}
