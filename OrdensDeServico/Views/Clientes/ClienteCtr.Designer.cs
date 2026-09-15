using OrdensDeServico.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Clientes
{
    public partial class ClienteCtr : UserControl
    {
        private Label lblNome;
        private Label lblTelefone;


        private void InitializeComponent()
        {
            lblNome = new Label();
            lblTelefone = new Label();
            btEditar = new Button();
            btRemover = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNome.Location = new Point(10, 10);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(220, 20);
            lblNome.TabIndex = 0;
            // 
            // lblTelefone
            // 
            lblTelefone.Font = new Font("Segoe UI", 8F);
            lblTelefone.Location = new Point(10, 35);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(220, 20);
            lblTelefone.TabIndex = 1;
            // 
            // btEditar
            // 
            btEditar.Location = new Point(10, 83);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(75, 23);
            btEditar.TabIndex = 2;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btRemover
            // 
            btRemover.Location = new Point(155, 83);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(75, 23);
            btRemover.TabIndex = 3;
            btRemover.Text = "Remover";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // ClienteCtr
            // 
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btRemover);
            Controls.Add(btEditar);
            Controls.Add(lblNome);
            Controls.Add(lblTelefone);
            Margin = new Padding(5);
            Name = "ClienteCtr";
            Size = new Size(238, 119);
            ResumeLayout(false);
        }

        private Button btEditar;
        private Button btRemover;
    }
}