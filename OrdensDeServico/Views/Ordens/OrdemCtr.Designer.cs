using OrdensDeServico.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Ordens
{
    public partial class OrdemCtr : UserControl
    {
        private Label lblCliente;
        private Label lblTecnico;
        private Label lblDescricao;
        private Label lblStatusValor;


        private void InitializeComponent()
        {
            lblCliente = new Label();
            lblTecnico = new Label();
            lblDescricao = new Label();
            lblStatusValor = new Label();
            btEditar = new Button();
            btRemover = new Button();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCliente.Location = new Point(10, 8);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(220, 18);
            lblCliente.TabIndex = 0;
            // 
            // lblTecnico
            // 
            lblTecnico.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblTecnico.Location = new Point(10, 28);
            lblTecnico.Name = "lblTecnico";
            lblTecnico.Size = new Size(220, 16);
            lblTecnico.TabIndex = 1;
            // 
            // lblDescricao
            // 
            lblDescricao.Font = new Font("Segoe UI", 8F);
            lblDescricao.Location = new Point(10, 46);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(220, 34);
            lblDescricao.TabIndex = 2;
            // 
            // lblStatusValor
            // 
            lblStatusValor.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblStatusValor.ForeColor = Color.DarkBlue;
            lblStatusValor.Location = new Point(10, 85);
            lblStatusValor.Name = "lblStatusValor";
            lblStatusValor.Size = new Size(220, 18);
            lblStatusValor.TabIndex = 3;
            // 
            // btEditar
            // 
            btEditar.Location = new Point(10, 125);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(75, 23);
            btEditar.TabIndex = 4;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btRemover
            // 
            btRemover.Location = new Point(155, 125);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(75, 23);
            btRemover.TabIndex = 5;
            btRemover.Text = "Remover";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // OrdemCtr
            // 
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btRemover);
            Controls.Add(btEditar);
            Controls.Add(lblCliente);
            Controls.Add(lblTecnico);
            Controls.Add(lblDescricao);
            Controls.Add(lblStatusValor);
            Margin = new Padding(5);
            Name = "OrdemCtr";
            Size = new Size(238, 151);
            ResumeLayout(false);
        }

        private Button btEditar;
        private Button btRemover;
    }
}