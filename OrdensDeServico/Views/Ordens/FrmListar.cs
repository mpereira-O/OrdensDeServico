using OrdensDeServico.Data;
using OrdensDeServico.Presenters;
using OrdensDeServico.Views.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Ordens
{
    public partial class FrmListar : Form
    {
        private OrdemPresenter presenter;

        public FrmListar()
        {
            InitializeComponent();
            presenter = new OrdemPresenter();
            CarregarOrdens();
        }

        public void CarregarOrdens()
        {
            flpOrdens.Controls.Clear();
            var lista = presenter.Buscar(txtBusca.Text);

            foreach (var ordem in lista)
            {
                var ctr = new OrdemCtr(this, presenter, ordem);
                flpOrdens.Controls.Add(ctr);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CarregarOrdens();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            var frm = new FrmCadastrar(presenter);
            frm.ShowDialog();
            CarregarOrdens();
        }

    }
}
