using OrdensDeServico.Data;
using OrdensDeServico.Models;
using OrdensDeServico.Presenters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Clientes
{
    public partial class FrmCadastrar : Form
    {
        private Label lblNome;
        private TextBox txtNome;
        private Label lblTelefone;
        private Button btnSalvar;


        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            lblTelefone = new Label();
            btnSalvar = new Button();
            txtTel = new MaskedTextBox();
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
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalvar.Location = new Point(180, 140);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 32);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(20, 101);
            txtTel.Mask = "(00) 0 0000-0000";
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(280, 23);
            txtTel.TabIndex = 5;
            // 
            // FrmCadastrar
            // 
            ClientSize = new Size(324, 191);
            Controls.Add(txtTel);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblTelefone);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadastrar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        private MaskedTextBox txtTel;
    }
}