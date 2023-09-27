using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cadastroClientes;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace cadastroVet
{
    public partial class frmPrincipal : Form
    {

        private String _stringConexao = "Data source=localhost\\SQLEXPRESS; " +
                                        "Initial Catalog=dbsysvet2023 " +
                                        "Integrated Security=True;";
        private SqlConnection _Conexao;
        private SqlCommand _comandoSql;
        private SqlDataAdapter _adaptadorSql;
        private DataTable _tabela;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frmCadCli = new frmCadastroCliente();
            frmCadCli.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnimais frmAnimais = new frmAnimais();
            frmAnimais.ShowDialog();
        }
    }
}
