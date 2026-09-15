using OrdensDeServico.Models;
using OrdensDeServico.Presenters;
using OrdensDeServico.Views.Clientes;
using OrdensDeServico.Views.Ordens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Tecnicos
{
    public partial class TecnicoCtr : UserControl
    {
        public Tecnico Tecnico { get; private set; }
        FrmListar form;
        TecnicoPresenter presenter;

        public TecnicoCtr(FrmListar form, TecnicoPresenter presenter, Tecnico tecnico)
        {
            Tecnico = tecnico;
            this.form = form;
            this.presenter = presenter;
            InitializeComponent();
            PreencherDados();
        }

        private void PreencherDados()
        {
            if (Tecnico != null)
            {
                lblNome.Text = Tecnico.Nome;
                lblEspecialidade.Text = $"Especialidade: {Tecnico.Especialidade}";
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            FrmEditar frm = new FrmEditar(presenter, Tecnico);
            frm.ShowDialog();
            form.CarregarTecnicos();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
                $"Deseja realmente remover o tecnico'{Tecnico.Nome}'?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                if (presenter.Remover(Tecnico))
                {
                    MessageBox.Show("Tecnico removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.CarregarTecnicos();
                }
                else
                {
                    MessageBox.Show("Erro ao remover o tecnico. Verifique se existem ordens de serviço associadas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
