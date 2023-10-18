using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace clDal
{
    public class Conexao
    {

        private static String _stringConexao = "Data source=GAB-ESTUDO\\SQLEXPRESS;" +
                                        "Initial Catalog=dbsysvet2023;" +
                                        "Integrated Security=True;";
        private static SqlConnection _conexao;
        private static SqlCommand _comandoSql;
        private static SqlDataAdapter _adaptadorSql;
        private static DataTable _tabela;

        public static SqlConnection obterConexao()
        {
            try
            {
                _conexao = new SqlConnection();
                _conexao.ConnectionString = _stringConexao;
                _conexao.Open();
                return _conexao;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void fecharConexao()
        {
            if (_conexao != null && _conexao.State == ConnectionState.Open)
            {
                _conexao.Close();
            }
        }

    }
}