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

namespace OrdensDeServico.Views.Clientes
{
    public partial class FrmCadastrar : Form
    {
        private ClientePresenter presenter;

        public FrmCadastrar(ClientePresenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cliente = new Cliente
            {
                Nome = txtNome.Text.Trim(),
                Telefone = txtTel.Text.Trim()
            };

            if (presenter.Cadastrar(cliente))
            {
                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
