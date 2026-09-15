using OrdensDeServico.Data;
using OrdensDeServico.Models;
using OrdensDeServico.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Ordens
{
    public partial class OrdemCtr : UserControl
    {
        public OrdemServico Ordem { get; private set; }
        FrmListar form;
        OrdemPresenter presenter;

        public OrdemCtr(FrmListar form, OrdemPresenter presenter, OrdemServico ordem)
        {
            Ordem = ordem;
            this.form = form;
            this.presenter = presenter;
            InitializeComponent();
            PreencherDados();
        }

        private void PreencherDados()
        {
            if (Ordem != null)
            {
                lblCliente.Text = $"#{Ordem.Id} - {Ordem.Cliente?.Nome ?? "Cliente N/A"}";
                lblTecnico.Text = $"Técnico: {Ordem.Tecnico?.Nome ?? "N/A"}";
                lblDescricao.Text = Ordem.DescricaoProblema;
                lblStatusValor.Text = $"[{Ordem.Status}] - R$ {Ordem.ValorTotal:N2}";
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            FrmEditar frm = new FrmEditar(presenter, Ordem);
            frm.ShowDialog();
            form.CarregarOrdens();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
                $"Deseja realmente remover a Ordem de Serviço #{Ordem.Id}?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                if (presenter.Remover(Ordem))
                {
                    MessageBox.Show("Ordem de serviço removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.CarregarOrdens();
                }
                else
                {
                    MessageBox.Show("Erro ao remover a ordem de serviço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
