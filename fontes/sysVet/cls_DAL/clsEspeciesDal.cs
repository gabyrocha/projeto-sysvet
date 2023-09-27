using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cls_model;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace cls_DAL
{
    public class clsEspeciesDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;

        public void Inserir(clsEspecies parEspecies)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.obterConexao();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "INSET INTO tblEspecies (espid, espnome) " +
                                     "VALUES (@espid, @espnome) ";

            _comandoSql.Parameters.Add("@espid", SqlDbType.Int).Value = parEspecies.Id;
            _comandoSql.Parameters.Add("@espnome", SqlDbType.VarChar).Value = parEspecies.Nome;
            _comandoSql.ExecuteNonQuery();

            Conexao.fecharConexao();
        }
    }
}
