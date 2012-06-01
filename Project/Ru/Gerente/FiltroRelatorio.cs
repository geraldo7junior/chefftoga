using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using RuBiz;
using System.Timers;

namespace Ru
{
    public partial class fFiltroRelatorio : Form
    {
        public fFiltroRelatorio()
        {
            InitializeComponent();

            lblOperador.Text += Utilidades.NomeLogin;
        }

        private void msMenuCadastroSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o formulário?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            Utilidades.Movimentacoes(0, "-", "-", "Geração de Relatório", "-", "-",0);

            Utilidades.CtrlIdMov = 1;

            Utilidades.GerarPdf();
        }

        private void fFiltroRelatorio_Load(object sender, EventArgs e)
        {
            
        }

        private void msMenuImprimir_Click(object sender, EventArgs e)
        {
            printDialogDoc.ShowDialog();
        }     


    }
}
