namespace OrdensDeServico.Views.Tecnicos
{
    partial class FrmEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            lblEspecialidade = new Label();
            txtEspecialidade = new TextBox();
            btSalvar = new Button();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            comboBox1 = new ComboBox();
            cbxOrdens = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(22, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(22, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(280, 23);
            txtNome.TabIndex = 6;
            // 
            // lblEspecialidade
            // 
            lblEspecialidade.AutoSize = true;
            lblEspecialidade.Location = new Point(22, 74);
            lblEspecialidade.Name = "lblEspecialidade";
            lblEspecialidade.Size = new Size(81, 15);
            lblEspecialidade.TabIndex = 7;
            lblEspecialidade.Text = "Especialidade:";
            // 
            // txtEspecialidade
            // 
            txtEspecialidade.Location = new Point(22, 94);
            txtEspecialidade.Name = "txtEspecialidade";
            txtEspecialidade.Size = new Size(280, 23);
            txtEspecialidade.TabIndex = 8;
            // 
            // btSalvar
            // 
            btSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSalvar.Location = new Point(162, 261);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(140, 32);
            btSalvar.TabIndex = 9;
            btSalvar.Text = "Salvar Alterações";
            btSalvar.Click += btSalvar_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(22, 226);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 10;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(23, 208);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status:";
            lblStatus.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // cbxOrdens
            // 
            cbxOrdens.FormattingEnabled = true;
            cbxOrdens.Location = new Point(22, 158);
            cbxOrdens.Name = "cbxOrdens";
            cbxOrdens.Size = new Size(121, 23);
            cbxOrdens.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 140);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 14;
            label1.Text = "Ordens de serviço:";
            label1.Click += label1_Click_1;
            // 
            // FrmEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 305);
            Controls.Add(label1);
            Controls.Add(cbxOrdens);
            Controls.Add(comboBox1);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblEspecialidade);
            Controls.Add(txtEspecialidade);
            Controls.Add(btSalvar);
            Name = "FrmEditar";
            Text = "FrmEditar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblEspecialidade;
        private TextBox txtEspecialidade;
        private Button btSalvar;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private ComboBox comboBox1;
        private ComboBox cbxOrdens;
        private Label label1;
    }
}