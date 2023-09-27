using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace cadastroClientes
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private String _stringConexao = "Data source=GAB-ESTUDO\\SQLEXPRESS;" +  
                                        "Initial Catalog=dbsysvet2023;"  +
                                        "Integrated Security=True;";
        private SqlConnection _Conexao;
        private SqlCommand _comandoSql;
        private SqlDataAdapter _adaptadorSql;
        private DataTable _tabela;
        
        private void carregarGrid()
        {

            try
            {
                _Conexao = new SqlConnection(_stringConexao);
                _Conexao.Open();

                _comandoSql = new SqlCommand();
                _comandoSql.CommandText = "select cliid, clinome, clicpf, cliemail, clidatacadastro " +
                                          " from tblClientes" +
                                          " order by cliid asc";

                _comandoSql.Connection = _Conexao;


                _tabela = new DataTable();

                _adaptadorSql = new SqlDataAdapter(_comandoSql);
                _adaptadorSql.Fill(_tabela);
                gridClientes.DataSource = _tabela;

                _Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void formatarGrid()
        {

        }

        private void atualizarTela()
        {

        }
       
        private void ativarFormulario()
        {
            btNovo.Enabled = true;
            btCancelar.Enabled = false;
            btEditar.Enabled = true;
            btExcluir.Enabled = true;
            btGravar.Enabled = false;
            btPesquisar.Enabled = true;

            carregarGrid();

        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            btNovo.Enabled = false;
            btCancelar.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;
            btGravar.Enabled = true;
            btPesquisar.Enabled = false;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            btNovo.Enabled = false;
            btCancelar.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;
            btGravar.Enabled = true;
            btPesquisar.Enabled = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            btNovo.Enabled = true;
            btCancelar.Enabled = false;
            btEditar.Enabled = true;
            btExcluir.Enabled = true;
            btGravar.Enabled = false;
            btPesquisar.Enabled = true;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            btNovo.Enabled = true;
            btCancelar.Enabled = false;
            btEditar.Enabled = true;
            btExcluir.Enabled = true;
            btGravar.Enabled = false;
            btPesquisar.Enabled = true;
        }

        private void btPeqsuisar_Click(object sender, EventArgs e)
        {
            btNovo.Enabled = false;
            btCancelar.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;
            btGravar.Enabled = true;
            btPesquisar.Enabled = false;
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            ativarFormulario();
        }
    }
}
