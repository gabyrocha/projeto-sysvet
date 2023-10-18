using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace clDal
{
    public class clClientesDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;

        private int obterProximoId()
        {
            int codigo = 0;
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                    " SELECT isnull(max(cliid, 0) +1 as codigo " +
                    " FROM tblClientes";

                codigo = Int32.Parse(_comandoSql.ExecuteScalar().ToString());

                Conexao.fecharConexao();
                return codigo;
            }

            catch (Exception ex)
            {
                return -1;
                throw new Exception(ex.Message);
            }
        }
        public void inserir(clClientesModel parClientes)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.obterConexao();
            int codigo = obterProximoId();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "INSERT INTO tblClientes (cliid, clinome, clicpf, cliemail, clidatacadastro) " +
                                     "VALUES (@cliid, @clinome, @clicpf, @cliemail, @clidatacadastro) ";

            _comandoSql.Parameters.Add("@cliid", SqlDbType.Int).Value = codigo;
            _comandoSql.Parameters.Add("@clinome", SqlDbType.VarChar).Value = parClientes.Nome;
            _comandoSql.Parameters.Add("@clicpf", SqlDbType.Decimal).Value = parClientes.Cpf;
            _comandoSql.Parameters.Add("@cliemail", SqlDbType.VarChar).Value = parClientes.Email;
            _comandoSql.Parameters.Add("@clidatacadastro", SqlDbType.Date).Value = parClientes.Datacadastro;

            _comandoSql.ExecuteNonQuery();

            _conexao.Close();
        }
        public void atualizar(clClientesModel parClientes)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.obterConexao();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "UPDATE tblClientes " +
                                      "SET clinome = @clinome " +
                                      "clicpf = @clicpf " +
                                      "cliemail = @cliemail" +
                                      "clidatacadastro = @clidatacadastro " +
                                      "WHERE cliid = @cliid ";

            _comandoSql.Parameters.Add("@cliid", SqlDbType.Int).Value = parClientes.Id;
            _comandoSql.Parameters.Add("@clinome", SqlDbType.VarChar).Value = parClientes.Nome;
            _comandoSql.Parameters.Add("@clicpf", SqlDbType.Decimal).Value = parClientes.Cpf;
            _comandoSql.Parameters.Add("@cliemail", SqlDbType.VarChar).Value = parClientes.Email;
            _comandoSql.Parameters.Add("@clidatacadastro", SqlDbType.Date).Value = parClientes.Datacadastro;

            _comandoSql.ExecuteNonQuery();

            _conexao.Close();
        }
        public void excluir(int parCodigoClientes)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _conexao = Conexao.obterConexao();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                    "DELETE from tblClientes " +
                    "WHERE aniid = @cliid ";
                _comandoSql.Parameters.Add("@cliid", SqlDbType.Int).Value = parCodigoClientes;
                _comandoSql.ExecuteNonQuery();

                _conexao.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable listarTodos()
        {
            DataTable tabela;
            SqlDataAdapter adaptador;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                    "SELECT * " +
                    "from tblClientes " +
                    "ORDER BY cliid asc ";

                tabela = new DataTable();
                adaptador = new SqlDataAdapter(_comandoSql);
                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }

        public List<clClientesModel> listarTodosArray()
        {
            List<clClientesModel> lista = new List<clClientesModel>();
            SqlDataReader leitor;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                    "SELECT * " +
                    "from tblClientes " +
                    "ORDER BY cliid asc ";

                leitor = _comandoSql.ExecuteReader();
                while (leitor.Read())
                {
                    clClientesModel item = new clClientesModel();
                    item.Id = Convert.ToInt32(leitor["cliid"]);
                    item.Nome = leitor["clinome"].ToString();
                    item.Cpf = Convert.ToInt32(leitor["clicpf"]);
                    item.Email = leitor["cliemail"].ToString();
                    item.Datacadastro = Convert.ToDateTime(leitor["clidatacadastro"]);

                    lista.Add(item);
                }
                leitor.Close();

                return lista;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }
    }
}