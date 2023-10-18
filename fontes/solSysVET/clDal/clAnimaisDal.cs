using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace clDal
{
    public class clAnimaisDal
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
                    " SELECT isnull(max(aniid, 0) +1 as codigo " +
                    " FROM tblAnimais";

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
        public void inserir(clAnimaisModel parAnimais)
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
        public void atualizar(clAnimaisModel parAnimais)
        {
            _conexao = new SqlConnection();
            _conexao = Conexao.obterConexao();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "UPDATE tblAnimais " +
                                      "SET aninome = @aninome " +
                                      "aniapelido = @aniapelido " +
                                      "anidatanasc = @anidatanasc" +
                                      "aniobs = @aniobs " +
                                      "espid = @espid " +
                                      "WHERE aniid = @aniid ";

            _comandoSql.Parameters.Add("@aniid", SqlDbType.Int).Value = parAnimais.Id;
            _comandoSql.Parameters.Add("@aninome", SqlDbType.VarChar).Value = parAnimais.Nome;
            _comandoSql.Parameters.Add("@aniapelido", SqlDbType.VarChar).Value = parAnimais.Apelido;
            _comandoSql.Parameters.Add("@anidatanasc", SqlDbType.Date).Value = parAnimais.DataNasc;
            _comandoSql.Parameters.Add("@aniobs", SqlDbType.VarChar).Value = parAnimais.Obs;
            _comandoSql.Parameters.Add("@espid", SqlDbType.Int).Value = parAnimais.EspID;
            _comandoSql.ExecuteNonQuery();

            _conexao.Close();
        }
        public void excluir(int parCodigoAnimais)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _conexao = Conexao.obterConexao();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                    "DELETE from tblAnimais " +
                    "WHERE aniid = @aniid ";
                _comandoSql.Parameters.Add("@aniid", SqlDbType.Int).Value = parCodigoAnimais;
                _comandoSql.ExecuteNonQuery ();

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
                    "from tblAnimais " +
                    "ORDER BY aniid asc ";

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

        public List<clAnimaisModel> listarTodosArray()
        {
            List<clAnimaisModel> lista = new List<clAnimaisModel>();
            SqlDataReader leitor;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                    "SELECT * " +
                    "from tblAnimais " +
                    "ORDER BY aniid asc ";

                leitor = _comandoSql.ExecuteReader();
                while (leitor.Read())
                {
                    clAnimaisModel item = new clAnimaisModel();
                    item.Id = Convert.ToInt32(leitor["aniid"]);
                    item.Nome = leitor["aninome"].ToString();
                    item.Apelido = leitor["aniapelido"].ToString();
                    item.DataNasc = Convert.ToDateTime(leitor["anidatanasc"]);
                    item.Obs = leitor["aniobs"].ToString();
                    item.EspID = Convert.ToInt32(leitor["espid"]);

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