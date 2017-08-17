using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetica_27.DAL
{
    class ConnectionFactory
    {
        public SqlConnection GetConnection()
        {
            string strConn = ConfigurationManager.ConnectionStrings["ConexaoCasa"].ConnectionString;
            return new SqlConnection(strConn);
        }
    }
}
