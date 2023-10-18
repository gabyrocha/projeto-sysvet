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
    public class clsEspeciesDal
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
                    " SELECT isnull(max(espid, 0) +1 as codigo " +
                    " FROM tblEspecies";

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
        public void inserir(clEspeciesModel parEspecies)
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

            _conexao.Close();
        }
        public void atualizar(clEspeciesModel parEspecies)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.obterConexao();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "UPDATE tblEspecies " +
                                      "SET espnome = @espnome " +
                                      "WHERE espid = @espid";

            _comandoSql.Parameters.Add("@espid", SqlDbType.Int).Value = parEspecies.Id;
            _comandoSql.Parameters.Add("@espnome", SqlDbType.VarChar).Value = parEspecies.Nome;
            _comandoSql.ExecuteNonQuery();

            _conexao.Close();
        }
        public void excluir(int parCodigoEspecies)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _conexao = Conexao.obterConexao();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                    "DELETE from tblEspecias " +
                    "WHERE espid = @espid ";
                _comandoSql.Parameters.Add("@espid", SqlDbType.Int).Value = parCodigoEspecies;
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

        public List<clEspeciesModel> listarTodosArray()
        {
            List<clEspeciesModel> lista = new List<clEspeciesModel>();
            SqlDataReader leitor;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                    "SELECT * " +
                    "from tblEspecies " +
                    "ORDER BY espid asc ";

                leitor = _comandoSql.ExecuteReader();
                while (leitor.Read())
                {
                    clEspeciesModel item = new clEspeciesModel();
                    item.Id = Convert.ToInt32(leitor["espid"]);
                    item.Nome = leitor["espnome"].ToString();

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