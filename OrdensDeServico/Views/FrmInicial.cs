using OrdensDeServico.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrdensDeServico.Views
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }
        private void BtnClientes_Click(object sender, EventArgs e)
        {
            var frm = new Clientes.FrmListar();
            frm.ShowDialog();
        }

        private void BtnTecnicos_Click(object sender, EventArgs e)
        {
            var frm = new Tecnicos.FrmListar();
            frm.ShowDialog();
        }

        private void BtnOrdensServico_Click(object sender, EventArgs e)
        {
            var frm = new Ordens.FrmListar();
            frm.ShowDialog();
        }

        private void FrmInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
