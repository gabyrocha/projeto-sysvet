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
    internal class clsAnimaisClientesDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;

        public void Inserir(clsAnimaisClientes parCliAni)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.obterConexao();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "INSET INTO tblEspecies (cliid, aniid) " +
                                      "VALUES (@cliid, @aniid) ";

            _comandoSql.Parameters.Add("@cliid", SqlDbType.Int).Value = parCliAni.CliId;
            _comandoSql.Parameters.Add("@aniid", SqlDbType.Int).Value = parCliAni.AniId;
            _comandoSql.ExecuteNonQuery();

            Conexao.fecharConexao();
        }
    }
}
