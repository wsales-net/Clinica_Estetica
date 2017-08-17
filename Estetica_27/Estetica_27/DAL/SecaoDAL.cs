using Estetica_27.Model;
using Estetica_27.Model.Enuns;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetica_27.DAL
{
    public class SecaoDAL
    {
        private SqlConnection conn;
        private SqlCommand cmd;

        public DataTable FindAll()
        {
            conn = new ConnectionFactory().GetConnection();

            StringBuilder query = new StringBuilder();

            query.AppendLine("SELECT CONT_ID, CONT_DE_NOME, CONT_ID_TIPO_SECAO, CONT_DE_TELEFONE, "); 
            query.AppendLine("CONT_NU_VALOR, CONT_DT_ATENDIMENTO, CONT_DT_CADASTRO ");
            query.AppendLine("FROM TB_CONTATO_CLIENTE_27 ");


            cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query.ToString();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            conn.Open();
            dt.BeginLoadData();
            da.Fill(dt);
            dt.EndLoadData();

            conn.Close();
            return dt;
        }

        public void Insert(Secao s)
        {
            conn = new ConnectionFactory().GetConnection();
            StringBuilder query = new StringBuilder();

            query.AppendLine("INSERT INTO TB_CONTATO_CLIENTE_27 ");
            query.AppendLine("(CONT_DE_NOME, CONT_ID_TIPO_SECAO, CONT_DT_ATENDIMENTO, CONT_DT_CADASTRO, CONT_DE_TELEFONE, ");
            query.AppendLine("CONT_NU_VALOR) ");
            query.AppendLine("VALUES ");
            query.AppendLine("(@CONT_DE_NOME, @CONT_ID_TIPO_SECAO, @CONT_DT_ATENDIMENTO, @CONT_DT_CADASTRO, @CONT_DE_TELEFONE, ");
            query.AppendLine("@CONT_NU_VALOR) ");
            query.AppendLine("select scope_identity(); ");

            cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@CONT_ID", s.Id);
            cmd.Parameters.AddWithValue("@CONT_DE_NOME", s.Nome);
            cmd.Parameters.AddWithValue("@CONT_ID_TIPO_SECAO", s.TipoSecao);
            cmd.Parameters.AddWithValue("@CONT_DT_ATENDIMENTO", s.DataAtendimento);
            cmd.Parameters.AddWithValue("@CONT_DT_CADASTRO", s.DataCadastro);
            cmd.Parameters.AddWithValue("@CONT_DE_TELEFONE", s.Telefone);
            cmd.Parameters.AddWithValue("@CONT_NU_VALOR", s.Valor);

            if (s.Valor == 0)
            {
                cmd.Parameters["@CONT_NU_VALOR"].Value = DBNull.Value;
            }
            if (s.Id == 0)
            {
                cmd.Parameters["@CONT_ID"].Value = DBNull.Value;
            }
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query.ToString();
            conn.Open();

            s.Id = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
        }

        public int Update(Secao c)
        {
            conn = new ConnectionFactory().GetConnection();
            StringBuilder query = new StringBuilder();
            int linhasAfetadas = 0;

            query.AppendLine("UPDATE TB_CONTATO_CLIENTE_27 SET ");
            query.AppendLine("CONT_DE_NOME = @CONT_DE_NOME, ");
            query.AppendLine("CONT_ID_TIPO_SECAO = @CONT_ID_TIPO_SECAO, ");
            query.AppendLine("CONT_DE_TELEFONE = @CONT_DE_TELEFONE, ");
            query.AppendLine("CONT_NU_VALOR = @CONT_NU_VALOR,");
            query.AppendLine("CONT_DT_ATENDIMENTO = @CONT_DT_ATENDIMENTO, ");
            query.AppendLine("CONT_DT_CADASTRO = @CONT_DT_CADASTRO ");
            query.AppendLine("WHERE CONT_ID = @CONT_ID ");

            cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@CONT_ID", c.Id);
            cmd.Parameters.AddWithValue("@CONT_DE_NOME", c.Nome);
            cmd.Parameters.AddWithValue("@CONT_ID_TIPO_SECAO", c.TipoSecao);
            cmd.Parameters.AddWithValue("@CONT_DE_TELEFONE", c.Telefone);
            cmd.Parameters.AddWithValue("@CONT_NU_VALOR", c.Valor);
            cmd.Parameters.AddWithValue("@CONT_DT_ATENDIMENTO", c.DataAtendimento);
            cmd.Parameters.AddWithValue("@CONT_DT_CADASTRO", c.DataCadastro);

            if (c.Valor == 0)
            {
                // Caso o valor do presente seja 0, gravaremos "NULL" no banco de dados
                cmd.Parameters["@CONT_NU_VALOR"].Value = DBNull.Value;
            }
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query.ToString();
            conn.Open();

            //ExecuteNonQuery retorna o número de linhas afetadas no banco de dados.
            linhasAfetadas = cmd.ExecuteNonQuery();
            conn.Close();
            return linhasAfetadas;
        }

        public int Delete(int id)
        {
            conn = new ConnectionFactory().GetConnection();
            StringBuilder query = new StringBuilder();
            int linhasAfetadas = 0;


            query.AppendLine("DELETE FROM TB_CONTATO_CLIENTE_27");
            query.AppendLine("WHERE CONT_ID = @CONT_ID");

            cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@CONT_ID", id);
            
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query.ToString();
            conn.Open();

            //ExecuteNonQuery retorna o número de linhas afetadas no banco de dados.
            linhasAfetadas = cmd.ExecuteNonQuery();
            conn.Close();
            return linhasAfetadas;
        }

        public Secao FindById(int id)
        {
            conn = new ConnectionFactory().GetConnection();
            string query = "SELECT * FROM TB_CONTATO_CLIENTE_27 WHERE CONT_ID = @CONT_ID";
            Secao c = new Secao();

            cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@CONT_ID", id);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read()) //Indicado que achou um registro
            {
                c.Id = Convert.ToInt32(reader["CONT_ID"]);
                c.Nome = reader["CONT_DE_NOME"].ToString();
                c.TipoSecao = (TipoSecaoEnum)Convert.ToInt32(reader["CONT_ID_TIPO_SECAO"]);
                c.Telefone = reader["CONT_DE_TELEFONE"].ToString();
                c.Valor = 0;
                c.DataAtendimento = Convert.ToDateTime(reader["CONT_DT_ATENDIMENTO"].ToString());
                c.DataCadastro = Convert.ToDateTime(reader["CONT_DT_CADASTRO"].ToString());

                if (!string.IsNullOrEmpty(reader["CONT_NU_VALOR"].ToString()))
                {
                    c.Valor = Convert.ToDouble(reader["CONT_NU_VALOR"]);
                }
                conn.Close();
            }
            return c;
        }
    }
}
