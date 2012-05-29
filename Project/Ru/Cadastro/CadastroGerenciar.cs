using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ru
{
    public partial class fCadastroGerenciar : Form
    {
        public fCadastroGerenciar()
        {
            InitializeComponent();
            lblBemVindo.Text = "Olá " + Utilidades.NomeLogin + "! Seja Bem Vindo ao Sistema Cheff Toga!";
        }

        private void msMenuCadastroNovo_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeTela = "novo";
            fCadastroNovo _fCad;
            _fCad = new fCadastroNovo();
            _fCad.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar a sessão?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utilidades.Movimentacoes(0, "-", "-", "Logoff", "-", "-", 0); //registrador de movimentacões
                Close();
                fTelaLogin _tela;
                _tela = new fTelaLogin();
                _tela.Show();
            }
        }

        private void msMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void msMenuCadastroAlterar_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeTela = "alterar";
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            _fAlt.Show();
        }

        public void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeTela = "visualizar";
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            _fAlt.Show();
        }

        public void msMenuCadastroExcluir_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeTela = "excluir";
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            _fAlt.Show();
        }

        private void fCadastroGerenciar_Load(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void msMenuImprimir_Click(object sender, EventArgs e)
        {
        }

    }
}
