using OrdensDeServico.Presenters;
using OrdensDeServico.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Tecnicos
{
    public partial class FrmListar : Form
    {
        private TecnicoPresenter presenter;
        public FrmListar()
        {
            InitializeComponent();
            presenter = new TecnicoPresenter();
            CarregarTecnicos();
        }

        private void FrmListar_Load(object sender, EventArgs e)
        {

        }
        public void CarregarTecnicos()
        {
            flpTecnicos.Controls.Clear();
            var lista = presenter.Buscar(txtBusca.Text);
            foreach(var tecnico in lista)
            {
                var ctr = new TecnicoCtr(this, presenter, tecnico);
                flpTecnicos.Controls.Add(ctr);
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastrar t= new FrmCadastrar(presenter);
            t.ShowDialog();
            CarregarTecnicos();
        }
    }
}
