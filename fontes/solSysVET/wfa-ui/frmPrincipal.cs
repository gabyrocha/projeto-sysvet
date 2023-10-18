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

using clDal;


namespace wfa_ui
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frmCadastroCliente = new frmCadastroCliente();
            frmCadastroCliente.ShowDialog();
        }

        private void espéciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEspecies frmCadastroEspecie = new frmCadastroEspecies();
            frmCadastroEspecie.ShowDialog();
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroAnimais frmCadastroAnimais = new frmCadastroAnimais();
            frmCadastroAnimais.ShowDialog();

        }

        private void mnPesquisa_Click(object sender, EventArgs e)
        {
            frmAnimalPesquisa frmPesquisa = new frmAnimalPesquisa();
            frmPesquisa.ShowDialog();
        }
    }
}
