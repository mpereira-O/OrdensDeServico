namespace OrdensDeServico.Views.Tecnicos
{
    partial class TecnicoCtr
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btRemover = new Button();
            btEditar = new Button();
            lblNome = new Label();
            lblEspecialidade = new Label();
            SuspendLayout();
            // 
            // btRemover
            // 
            btRemover.Location = new Point(154, 84);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(75, 23);
            btRemover.TabIndex = 7;
            btRemover.Text = "Remover";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btEditar
            // 
            btEditar.Location = new Point(9, 84);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(75, 23);
            btEditar.TabIndex = 6;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNome.Location = new Point(9, 11);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(220, 20);
            lblNome.TabIndex = 4;
            // 
            // lblEspecialidade
            // 
            lblEspecialidade.Font = new Font("Segoe UI", 8F);
            lblEspecialidade.Location = new Point(9, 36);
            lblEspecialidade.Name = "lblEspecialidade";
            lblEspecialidade.Size = new Size(220, 20);
            lblEspecialidade.TabIndex = 5;
            // 
            // TecnicoCtr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btRemover);
            Controls.Add(btEditar);
            Controls.Add(lblNome);
            Controls.Add(lblEspecialidade);
            Name = "TecnicoCtr";
            Size = new Size(238, 119);
            ResumeLayout(false);
        }

        #endregion

        private Button btRemover;
        private Button btEditar;
        private Label lblNome;
        private Label lblEspecialidade;
    }
}
