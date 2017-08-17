using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Estetica_27.DAL
{
    public class TipoSecaoDAL
    {
        private SqlConnection conn;
        private SqlCommand cmd;

        public DataTable FindAll()
        {
            conn = new ConnectionFactory().GetConnection();
            string query = "SELECT * FROM TB_TIPO_SECAO_27";

            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            conn.Open();
            dt.BeginLoadData();
            da.Fill(dt);
            dt.EndLoadData();

            conn.Close();
            return dt;
        }
    }
}
