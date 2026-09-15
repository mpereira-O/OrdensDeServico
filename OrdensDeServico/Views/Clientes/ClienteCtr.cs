using OrdensDeServico.Models;
using OrdensDeServico.Presenters;
using OrdensDeServico.Views.Ordens;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Clientes
{
    public partial class ClienteCtr : UserControl
    {
        public Cliente Cliente { get; private set; }
        FrmListar form;
        ClientePresenter presenter;

        public ClienteCtr(FrmListar form, ClientePresenter presenter, Cliente cliente)
        {
            Cliente = cliente;
            this.form = form;
            this.presenter = presenter;
            InitializeComponent();
            PreencherDados();
        }

        private void PreencherDados()
        {
            if (Cliente != null)
            {
                lblNome.Text = Cliente.Nome;
                lblTelefone.Text = $"Tel: {Cliente.Telefone}";
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            FrmEditar frm = new FrmEditar(presenter, Cliente);
            frm.ShowDialog();
            form.CarregarClientes();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
                $"Deseja realmente remover o cliente '{Cliente.Nome}'?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                if (presenter.Remover(Cliente))
                {
                    MessageBox.Show("Cliente removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.CarregarClientes();
                }
                else
                {
                    MessageBox.Show("Erro ao remover o cliente. Verifique se existem ordens de serviço associadas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}