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
        {   cbxStatus.Items.Clear();
            cbxStatus.Items.Add("Pendente");
            cbxStatus.Items.Add("Em Andamento");
            cbxStatus.Items.Add("Concluído");
            cbxStatus.Items.Add("Cancelado");

            cbxOrdens.SelectedIndexChanged -= cbxOrdens_Selecao;
            cbxOrdens.Format -= cbxOrdens_Formatada;
            cbxOrdens.Format += cbxOrdens_Formatada;

            cbxOrdens.DataSource = presenter.BuscarServico("");
            cbxOrdens.ValueMember = "Id";

            cbxOrdens.SelectedIndexChanged += cbxOrdens_Selecao;
        }
        private void cbxOrdens_Formatada(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is OrdemServico ordem)
            {
                e.Value = $"{ordem.Id} - {ordem.DescricaoProblema}";
            }
        }
        private void cbxOrdens_Selecao(object sender, EventArgs e)
        {
            AtualizarStatusOrdem();
        }
        private void AtualizarStatusOrdem()
        {
            if (cbxOrdens.SelectedItem is OrdemServico ordemSelecionada)
            {
                cbxStatus.SelectedItem = ordemSelecionada.Status;
            }
        }
        private void PreencherCampos()
        {
            if (tecnico != null)
            {
                txtNome.Text = tecnico.Nome;
                txtEspecialidade.Text = tecnico.Especialidade;
                AtualizarStatusOrdem();
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
                MessageBox.Show("Tecnico atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o tecnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmEditar_Load(object sender, EventArgs e)
        {

        }
        
    }
}
