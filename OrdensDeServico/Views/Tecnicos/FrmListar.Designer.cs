namespace OrdensDeServico.Views.Tecnicos
{
    partial class FrmListar
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
            flpTecnicos = new FlowLayoutPanel();
            pnlTopo = new Panel();
            txtBusca = new TextBox();
            btnBuscar = new Button();
            pnlRodape = new Panel();
            btnNovo = new Button();
            pnlTopo.SuspendLayout();
            pnlRodape.SuspendLayout();
            SuspendLayout();
            // 
            // flpTecnicos
            // 
            flpTecnicos.AutoScroll = true;
            flpTecnicos.Dock = DockStyle.Fill;
            flpTecnicos.Location = new Point(0, 50);
            flpTecnicos.Name = "flpTecnicos";
            flpTecnicos.Padding = new Padding(10);
            flpTecnicos.Size = new Size(527, 326);
            flpTecnicos.TabIndex = 3;
            // 
            // pnlTopo
            // 
            pnlTopo.Controls.Add(txtBusca);
            pnlTopo.Controls.Add(btnBuscar);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(527, 50);
            pnlTopo.TabIndex = 4;
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
            // 
            // pnlRodape
            // 
            pnlRodape.Controls.Add(btnNovo);
            pnlRodape.Dock = DockStyle.Bottom;
            pnlRodape.Location = new Point(0, 376);
            pnlRodape.Name = "pnlRodape";
            pnlRodape.Size = new Size(527, 55);
            pnlRodape.TabIndex = 5;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNovo.Location = new Point(212, 11);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(110, 32);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "+ Novo Tecnico";
            btnNovo.Click += btnNovo_Click;
            // 
            // FrmListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 431);
            Controls.Add(flpTecnicos);
            Controls.Add(pnlTopo);
            Controls.Add(pnlRodape);
            Name = "FrmListar";
            Text = "FrmListar";
            Load += FrmListar_Load;
            pnlTopo.ResumeLayout(false);
            pnlTopo.PerformLayout();
            pnlRodape.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpTecnicos;
        private Panel pnlTopo;
        private TextBox txtBusca;
        private Button btnBuscar;
        private Panel pnlRodape;
        private Button btnNovo;
    }
}