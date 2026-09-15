using OrdensDeServico.Models;
using OrdensDeServico.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Tecnicos
{
    public partial class FrmCadastrar : Form
    {
        private TecnicoPresenter presenter;
        public FrmCadastrar(TecnicoPresenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;
        }

        private void FrmCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtEspecialidade.Text))
            {
                MessageBox.Show("Informe o nome do técnico", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tecnico = new Tecnico
            {
                Nome = txtNome.Text.Trim(),
                Especialidade = txtEspecialidade.Text.Trim()
            };

            if (presenter.Cadastrar(tecnico))
            {
                MessageBox.Show("Técnico cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o tecnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
