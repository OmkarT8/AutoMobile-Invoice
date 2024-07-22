using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoManufacture
{
    public class DataLayer
    {
        public SqlConnection createConn()
        {
            var conStr = System.Configuration.ConfigurationManager.ConnectionStrings["autoManufacture"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);

            return con;
        }
    }
}
