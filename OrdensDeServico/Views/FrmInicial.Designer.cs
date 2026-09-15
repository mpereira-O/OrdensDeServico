using OrdensDeServico.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrdensDeServico.Views
{
    public partial class FrmInicial : Form
    {
        private Button btnClientes;
        private Button btnTecnicos;
        private Button btnOrdensServico;

        private void InitializeComponent()
        {
            btnClientes = new Button();
            btnTecnicos = new Button();
            btnOrdensServico = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClientes.Location = new Point(65, 30);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(220, 45);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "&Clientes";
            btnClientes.Click += BtnClientes_Click;
            // 
            // btnTecnicos
            // 
            btnTecnicos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTecnicos.Location = new Point(65, 95);
            btnTecnicos.Name = "btnTecnicos";
            btnTecnicos.Size = new Size(220, 45);
            btnTecnicos.TabIndex = 1;
            btnTecnicos.Text = "&Técnicos";
            btnTecnicos.Click += BtnTecnicos_Click;
            // 
            // btnOrdensServico
            // 
            btnOrdensServico.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOrdensServico.Location = new Point(65, 160);
            btnOrdensServico.Name = "btnOrdensServico";
            btnOrdensServico.Size = new Size(220, 45);
            btnOrdensServico.TabIndex = 2;
            btnOrdensServico.Text = "&Ordens de Serviço";
            btnOrdensServico.Click += BtnOrdensServico_Click;
            // 
            // FrmInicial
            // 
            ClientSize = new Size(350, 260);
            Controls.Add(btnClientes);
            Controls.Add(btnTecnicos);
            Controls.Add(btnOrdensServico);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal - Ordens de Serviço";
            FormClosed += FrmInicial_FormClosed;
            ResumeLayout(false);
        }


    }
}