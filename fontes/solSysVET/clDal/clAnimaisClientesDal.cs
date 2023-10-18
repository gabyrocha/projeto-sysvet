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
    public class clsAnimaisClientesDal
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
                    " FROM tblAnimaisClientes";

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
        public void inserir(clAnimaisClientesModel parAnimaisClientes)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.obterConexao();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "INSET INTO tblAnimaisClientes (cliid, aniid) " +
                                      "VALUES (@cliid, @aniid) ";

            _comandoSql.Parameters.Add("@cliid", SqlDbType.Int).Value = parAnimaisClientes.CliId;
            _comandoSql.Parameters.Add("@aniid", SqlDbType.Int).Value = parAnimaisClientes.AniId;
            _comandoSql.ExecuteNonQuery();

            _conexao.Close();
        }
        public void atualizar(clAnimaisClientesModel parAnimaisClientes)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.obterConexao();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "UPDATE tblAnimaisClientes " +
                                      "SET aniid = @aniid " +
                                      "WHERE cliid = @cliid";

            _comandoSql.Parameters.Add("@cliid", SqlDbType.Int).Value = parAnimaisClientes.CliId;
            _comandoSql.Parameters.Add("@aniid", SqlDbType.Int).Value = parAnimaisClientes.AniId;
            _comandoSql.ExecuteNonQuery();

            _conexao.Close();
        }
        public void excluir(int parCodigoAnimaisClientes)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _conexao = Conexao.obterConexao();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                    "DELETE from tblAnimaisClientes " +
                    "WHERE cliid = @cliid ";
                _comandoSql.Parameters.Add("@cliid", SqlDbType.Int).Value = parCodigoAnimaisClientes;
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
                    "from tblAnimaisClientes " +
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

        public List<clAnimaisClientesModel> listarTodosArray()
        {
            List<clAnimaisClientesModel> lista = new List<clAnimaisClientesModel> ();
            SqlDataReader leitor;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                    "SELECT * " +
                    "from tblAnimaisClientes " +
                    "ORDER BY cliid asc ";
                
                leitor = _comandoSql.ExecuteReader();
                while (leitor.Read())
                {
                    clAnimaisClientesModel item = new clAnimaisClientesModel();
                    item.CliId = Convert.ToInt32(leitor["cliid"]);
                    item.AniId = Convert.ToInt32(leitor["aniid"]);

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