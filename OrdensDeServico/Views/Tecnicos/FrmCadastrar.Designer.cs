namespace OrdensDeServico.Views.Tecnicos
{
    partial class FrmCadastrar
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
            txtEspecialidade = new MaskedTextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            lblEspecialidade = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtEspecialidade
            // 
            txtEspecialidade.Location = new Point(39, 103);
            txtEspecialidade.Name = "txtEspecialidade";
            txtEspecialidade.Size = new Size(280, 23);
            txtEspecialidade.TabIndex = 10;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(39, 22);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(39, 42);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(280, 23);
            txtNome.TabIndex = 7;
            // 
            // lblEspecialidade
            // 
            lblEspecialidade.AutoSize = true;
            lblEspecialidade.Location = new Point(39, 77);
            lblEspecialidade.Name = "lblEspecialidade";
            lblEspecialidade.Size = new Size(81, 15);
            lblEspecialidade.TabIndex = 8;
            lblEspecialidade.Text = "Especialidade:";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalvar.Location = new Point(199, 142);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 32);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 196);
            Controls.Add(txtEspecialidade);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblEspecialidade);
            Controls.Add(btnSalvar);
            Name = "FrmCadastrar";
            Text = "FrmCadastrar";
            Load += FrmCadastrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtEspecialidade;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblEspecialidade;
        private Button btnSalvar;
    }
}