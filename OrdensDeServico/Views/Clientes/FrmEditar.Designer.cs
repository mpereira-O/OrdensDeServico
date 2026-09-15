using OrdensDeServico.Models;
using OrdensDeServico.Presenters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Clientes
{
    public partial class FrmEditar : Form
    {
        private Label lblNome;
        private TextBox txtNome;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Button btSalvar;



        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            btSalvar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(20, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(20, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(280, 23);
            txtNome.TabIndex = 1;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(20, 75);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(55, 15);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(20, 95);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(280, 23);
            txtTelefone.TabIndex = 3;
            // 
            // btSalvar
            // 
            btSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSalvar.Location = new Point(160, 140);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(140, 32);
            btSalvar.TabIndex = 4;
            btSalvar.Text = "Salvar Alterações";
            btSalvar.Click += btSalvar_Click;
            // 
            // FrmEditar
            // 
            ClientSize = new Size(324, 191);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblTelefone);
            Controls.Add(txtTelefone);
            Controls.Add(btSalvar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEditar";
            StartPosition = FormStartPosition.CenterParent;
            Load += FrmEditar_Load;
            ResumeLayout(false);
            PerformLayout();
        }


    }
}