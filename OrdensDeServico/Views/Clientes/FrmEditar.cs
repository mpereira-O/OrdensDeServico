using OrdensDeServico.Models;
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
    public partial class FrmEditar : Form
    {
        private readonly ClientePresenter presenter;
        private readonly Cliente cliente;

        public FrmEditar(ClientePresenter presenter, Cliente cliente)
        {
            this.presenter = presenter;
            this.cliente = cliente;

            InitializeComponent();

            this.Text = $"Editar Cliente #{cliente?.Id}";

            PreencherCampos();
        }

        private void PreencherCampos()
        {
            if (cliente != null)
            {
                txtNome.Text = cliente.Nome;
                txtTelefone.Text = cliente.Telefone;
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cliente.Nome = txtNome.Text.Trim();
            cliente.Telefone = txtTelefone.Text.Trim();

            if (presenter.Editar(cliente))
            {
                MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEditar_Load(object sender, EventArgs e)
        {

        }
    }
}
