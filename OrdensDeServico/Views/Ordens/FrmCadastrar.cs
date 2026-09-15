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
    public partial class FrmCadastrar : Form
    {
        private OrdemPresenter presenter;

        public FrmCadastrar(OrdemPresenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;

            CarregarCombos();
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (cbxCliente.SelectedValue == null || cbxTecnico.SelectedValue == null || string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal valor = numValor.Value;

            var ordem = new OrdemServico
            {
                ClienteId = (int)cbxCliente.SelectedValue,
                TecnicoId = (int)cbxTecnico.SelectedValue,
                DescricaoProblema = txtDescricao.Text.Trim(),
                ValorTotal = valor,
                Status = "Pendente",
                DataAbertura = DateTime.UtcNow
            };

            if (presenter.Cadastrar(ordem))
            {
                MessageBox.Show("Ordem de Serviço criada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar OS.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
