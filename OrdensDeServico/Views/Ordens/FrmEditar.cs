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
    public partial class FrmEditar : Form
    {
        private OrdemPresenter presenter;
        private readonly OrdemServico ordemOriginal;

        public FrmEditar(OrdemPresenter presenter, OrdemServico ordem)
        {
            this.presenter = presenter;
            ordemOriginal = ordem;
            InitializeComponent();

            this.Text = $"Editar Ordem de Serviço #{ordemOriginal?.Id}";

            CarregarCombos();
            PreencherFormulario();
        }

        private void CarregarCombos()
        {
            cbxCliente.DataSource = presenter.BuscarClientes("");
            cbxCliente.DisplayMember = "Nome";
            cbxCliente.ValueMember = "Id";

            cbxTecnico.DataSource = presenter.BuscarTecnicos("");
            cbxTecnico.DisplayMember = "Nome";
            cbxTecnico.ValueMember = "Id";
        }

        private void PreencherFormulario()
        {
            if (ordemOriginal != null)
            {
                cbxCliente.SelectedValue = ordemOriginal.ClienteId;
                cbxTecnico.SelectedValue = ordemOriginal.TecnicoId;
                txtDescricao.Text = ordemOriginal.DescricaoProblema;
                numValor.Value = ordemOriginal.ValorTotal;
                cbxStatus.SelectedItem = ordemOriginal.Status;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (cbxCliente.SelectedValue == null || cbxTecnico.SelectedValue == null || string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal valor = numValor.Value;

            ordemOriginal.ClienteId = (int)cbxCliente.SelectedValue;
            ordemOriginal.TecnicoId = (int)cbxTecnico.SelectedValue;
            ordemOriginal.DescricaoProblema = txtDescricao.Text.Trim();
            ordemOriginal.Status = cbxStatus.SelectedItem?.ToString() ?? "Pendente";
            ordemOriginal.ValorTotal = valor;

            if (presenter.Editar(ordemOriginal))
            {
                MessageBox.Show("Ordem de serviço atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar a Ordem de Serviço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
