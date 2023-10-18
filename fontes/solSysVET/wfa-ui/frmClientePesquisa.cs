using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using clModel;
using clDal;

namespace wfa_ui
{
    public partial class frmClientePesquisa : Form
    {
        public frmClientePesquisa()
        {
            InitializeComponent();
        }

        public clClientesModel cliente;
        private clClientesDal clienteDal;

        private void carregarGrid()
        {
            gridPesquisar.DataSource = clienteDal.listarTodosArray();
        }
        private void selecionarItem()
        {
            Int32 i = 0;

            i = gridPesquisar.CurrentRow.Index;
            cliente.Id = Int32.Parse(gridPesquisar[0, i].Value.ToString());
            cliente.Nome = gridPesquisar[1, i].Value.ToString();
            cliente.Cpf = Int32.Parse(gridPesquisar[2, i].Value.ToString());
            cliente.Email = gridPesquisar[3, i].Value.ToString();
            cliente.Datacadastro = Convert.ToDateTime(gridPesquisar[4, i].Value.ToString());
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            this.selecionarItem();
            this.Close();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.cliente.Id = 0;
            this.Close();
        }

        private void gridPesquisar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cliente = new clClientesModel();
            this.clienteDal = new clClientesDal();
            carregarGrid();
        }
    }
}
