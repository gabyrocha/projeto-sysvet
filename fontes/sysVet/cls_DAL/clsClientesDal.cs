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
    public class clsClientesDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;

        public void Inserir(clsClientes parClientes)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.obterConexao();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "INSET INTO tblClientes (cliid, clinome, clicpf, cliemail, clidatacadastro) " +
                                     "VALUES (@cliid, @clinome, @clicpf, @cliemail, @clidatacadastro) ";

            _comandoSql.Parameters.Add("@cliid", SqlDbType.Int).Value = parClientes.Id;
            _comandoSql.Parameters.Add("@clinome", SqlDbType.VarChar).Value = parClientes.Nome;
            _comandoSql.Parameters.Add("@clicpf", SqlDbType.Decimal).Value = parClientes.Cpf;
            _comandoSql.Parameters.Add("@cliemail", SqlDbType.VarChar).Value = parClientes.Email;
            _comandoSql.Parameters.Add("@clidatacadastro", SqlDbType.Date).Value = parClientes.Datacadastro;

            _comandoSql.ExecuteNonQuery();

            Conexao.fecharConexao();
        }
    }
}
