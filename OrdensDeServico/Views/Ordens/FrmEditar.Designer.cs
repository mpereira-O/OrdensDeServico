using OrdensDeServico.Data;
using OrdensDeServico.Models;
using OrdensDeServico.Presenters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Ordens
{
    public partial class FrmEditar : Form
    {
        private Label lblCliente;
        private ComboBox cbxCliente;
        private Label lblTecnico;
        private ComboBox cbxTecnico;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private Label lblValor;
        private Label lblStatus;
        private ComboBox cbxStatus;
        private Button btnSalvar;

        private void InitializeComponent()
        {
            lblCliente = new Label();
            cbxCliente = new ComboBox();
            lblTecnico = new Label();
            cbxTecnico = new ComboBox();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            lblValor = new Label();
            lblStatus = new Label();
            cbxStatus = new ComboBox();
            btnSalvar = new Button();
            numValor = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(20, 15);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // cbxCliente
            // 
            cbxCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCliente.Location = new Point(20, 35);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(300, 23);
            cbxCliente.TabIndex = 1;
            // 
            // lblTecnico
            // 
            lblTecnico.AutoSize = true;
            lblTecnico.Location = new Point(20, 70);
            lblTecnico.Name = "lblTecnico";
            lblTecnico.Size = new Size(51, 15);
            lblTecnico.TabIndex = 2;
            lblTecnico.Text = "Técnico:";
            // 
            // cbxTecnico
            // 
            cbxTecnico.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTecnico.Location = new Point(20, 90);
            cbxTecnico.Name = "cbxTecnico";
            cbxTecnico.Size = new Size(300, 23);
            cbxTecnico.TabIndex = 3;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(20, 125);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(132, 15);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição do Problema:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(20, 145);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(300, 60);
            txtDescricao.TabIndex = 5;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(190, 215);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(89, 15);
            lblValor.TabIndex = 8;
            lblValor.Text = "Valor Total (R$):";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(20, 215);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status:";
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.Items.AddRange(new object[] { "Pendente", "Em Andamento", "Concluído", "Cancelado" });
            cbxStatus.Location = new Point(20, 235);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(130, 23);
            cbxStatus.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalvar.Location = new Point(180, 310);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(140, 32);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar Alterações";
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // numValor
            // 
            numValor.DecimalPlaces = 2;
            numValor.Location = new Point(190, 235);
            numValor.Maximum = new decimal(new int[] { 1241513984, 370409800, 542101, 0 });
            numValor.Name = "numValor";
            numValor.Size = new Size(120, 23);
            numValor.TabIndex = 11;
            numValor.TextAlign = HorizontalAlignment.Right;
            // 
            // FrmEditar
            // 
            ClientSize = new Size(344, 371);
            Controls.Add(numValor);
            Controls.Add(lblCliente);
            Controls.Add(cbxCliente);
            Controls.Add(lblTecnico);
            Controls.Add(cbxTecnico);
            Controls.Add(lblDescricao);
            Controls.Add(txtDescricao);
            Controls.Add(lblStatus);
            Controls.Add(cbxStatus);
            Controls.Add(lblValor);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmEditar";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private NumericUpDown numValor;
    }
}