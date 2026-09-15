using OrdensDeServico.Data;
using OrdensDeServico.Presenters;
using OrdensDeServico.Views.Clientes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Ordens
{
    public partial class FrmListar : Form
    {
        private Panel pnlTopo;
        private TextBox txtBusca;
        private Button btnBuscar;
        private FlowLayoutPanel flpOrdens;
        private Panel pnlRodape;
        private Button btnNovo;

        
        private void InitializeComponent()
        {
            this.pnlTopo = new Panel();
            this.txtBusca = new TextBox();
            this.btnBuscar = new Button();
            this.flpOrdens = new FlowLayoutPanel();
            this.pnlRodape = new Panel();
            this.btnNovo = new Button();

            this.SuspendLayout();

            this.Text = "Ordens de Serviço";
            this.Size = new Size(550, 480);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Painel Topo
            this.pnlTopo.Dock = DockStyle.Top;
            this.pnlTopo.Height = 50;

            this.txtBusca.Location = new Point(15, 14);
            this.txtBusca.Size = new Size(380, 23);

            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Location = new Point(405, 12);
            this.btnBuscar.Size = new Size(110, 27);
            this.btnBuscar.Click += BtnBuscar_Click;

            this.pnlTopo.Controls.Add(this.txtBusca);
            this.pnlTopo.Controls.Add(this.btnBuscar);

            // FlowLayoutPanel
            this.flpOrdens.Dock = DockStyle.Fill;
            this.flpOrdens.AutoScroll = true;
            this.flpOrdens.Padding = new Padding(10);

            // Painel Rodapé
            this.pnlRodape.Dock = DockStyle.Bottom;
            this.pnlRodape.Height = 55;

            this.btnNovo.Text = "+ Nova OS";
            this.btnNovo.Location = new Point(405, 10);
            this.btnNovo.Size = new Size(110, 32);
            this.btnNovo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnNovo.Click += BtnNovo_Click;

            this.pnlRodape.Controls.Add(this.btnNovo);

            this.Controls.Add(this.flpOrdens);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.pnlRodape);

            this.ResumeLayout(false);
        }

        
    }
}