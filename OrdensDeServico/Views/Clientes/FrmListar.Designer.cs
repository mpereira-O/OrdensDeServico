using OrdensDeServico.Data;
using OrdensDeServico.Presenters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Clientes
{
    public partial class FrmListar : Form
    {
        private Panel pnlTopo;
        private TextBox txtBusca;
        private Button btnBuscar;
        private FlowLayoutPanel flpClientes;

        private void InitializeComponent()
        {
            pnlTopo = new Panel();
            txtBusca = new TextBox();
            btnBuscar = new Button();
            flpClientes = new FlowLayoutPanel();
            pnlRodape = new Panel();
            btnNovo = new Button();
            pnlTopo.SuspendLayout();
            pnlRodape.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopo
            // 
            pnlTopo.BorderStyle = BorderStyle.FixedSingle;
            pnlTopo.Controls.Add(txtBusca);
            pnlTopo.Controls.Add(btnBuscar);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(534, 50);
            pnlTopo.TabIndex = 1;
            pnlTopo.Paint += pnlTopo_Paint;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(15, 14);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(380, 23);
            txtBusca.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(405, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 27);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // flpClientes
            // 
            flpClientes.AutoScroll = true;
            flpClientes.Dock = DockStyle.Fill;
            flpClientes.Location = new Point(0, 50);
            flpClientes.Name = "flpClientes";
            flpClientes.Padding = new Padding(10);
            flpClientes.Size = new Size(534, 336);
            flpClientes.TabIndex = 0;
            flpClientes.Paint += flpClientes_Paint;
            // 
            // pnlRodape
            // 
            pnlRodape.Controls.Add(btnNovo);
            pnlRodape.Dock = DockStyle.Bottom;
            pnlRodape.Location = new Point(0, 386);
            pnlRodape.Name = "pnlRodape";
            pnlRodape.Size = new Size(534, 55);
            pnlRodape.TabIndex = 2;
            pnlRodape.Paint += pnlRodape_Paint;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNovo.Location = new Point(212, 11);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(110, 32);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "+ Novo Cliente";
            btnNovo.Click += btnNovo_Click;
            // 
            // FrmListar
            // 
            ClientSize = new Size(534, 441);
            Controls.Add(flpClientes);
            Controls.Add(pnlTopo);
            Controls.Add(pnlRodape);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmListar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lista de Clientes";
            pnlTopo.ResumeLayout(false);
            pnlTopo.PerformLayout();
            pnlRodape.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlRodape;
        private Button btnNovo;
    }
}