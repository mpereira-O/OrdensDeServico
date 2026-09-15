using OrdensDeServico.Data;
using OrdensDeServico.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Clientes
{
    public partial class FrmListar : Form
    {
        private ClientePresenter presenter;

        public FrmListar()
        {
            InitializeComponent();
            presenter = new ClientePresenter();
            CarregarClientes();
        }


        public void CarregarClientes()
        {
            flpClientes.Controls.Clear();
            var lista = presenter.Buscar(txtBusca.Text);

            foreach (var cliente in lista)
            {
                var ctr = new ClienteCtr(this, presenter, cliente);
                flpClientes.Controls.Add(ctr);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastrar c = new FrmCadastrar(presenter);
            c.ShowDialog();
            CarregarClientes();
        }

        private void pnlRodape_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTopo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpClientes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
