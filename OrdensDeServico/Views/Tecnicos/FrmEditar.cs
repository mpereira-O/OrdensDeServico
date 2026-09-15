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
    public partial class FrmEditar : Form
    {
        private readonly TecnicoPresenter presenter;
        private readonly Tecnico tecnico;
        public FrmEditar(TecnicoPresenter presenter, Tecnico tecnico)
        {
            this.presenter = presenter;
            this.tecnico = tecnico;
            InitializeComponent();
            this.Text = $"Editar Tecnico #{tecnico?.Id}";
            CarregarCombos();
            PreencherCampos();
        }

        private void CarregarCombos()
        {
            cbxOrdens.DataSource = presenter.BuscarServico("");
            cbxOrdens.DisplayMember = "Ordem";
            cbxOrdens.ValueMember = "Id";

        }

        private void PreencherCampos()
        {
            if (tecnico != null)
            {
                txtNome.Text = tecnico.Nome;
                txtEspecialidade.Text = tecnico.Especialidade;
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do Técnico.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tecnico.Nome = txtNome.Text.Trim();
            tecnico.Especialidade = txtEspecialidade.Text.Trim();

            if (presenter.Editar(tecnico))
            {
                MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
