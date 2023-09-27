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
        public class clsAnimaisDal
        {
            private SqlConnection _conexao;
            private SqlCommand _comandoSql;

            public void Inserir(clsAnimais parAnimais)
            {
                _conexao = new SqlConnection();
                _conexao = Conexao.obterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText = "INSET INTO tblAnimais (aniid, aninome, aniapelido, anidatanasc, aniobs,espid) " +
                                         "VALUES (@aniid, @aninome, @aniapelido, @anidatanasc, @aniobs, @espid) ";

                _comandoSql.Parameters.Add("@aniid", SqlDbType.Int).Value = parAnimais.Id;
                _comandoSql.Parameters.Add("@aninome", SqlDbType.VarChar).Value = parAnimais.Nome;
                _comandoSql.Parameters.Add("@aniapelido", SqlDbType.VarChar).Value = parAnimais.Apelido;
                _comandoSql.Parameters.Add("@anidatanasc", SqlDbType.Date).Value = parAnimais.DataNasc;
                _comandoSql.Parameters.Add("@aniobs", SqlDbType.VarChar).Value = parAnimais.Obs;
                _comandoSql.Parameters.Add("@espid", SqlDbType.Int).Value = parAnimais.EspID;
                _comandoSql.ExecuteNonQuery();

                Conexao.fecharConexao();
            }
        }
}
