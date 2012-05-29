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
    public partial class fGerenteGerenciar : Form
    {
        public fGerenteGerenciar()
        {
            InitializeComponent();
            lblBemVindo.Text = "Olá " + Utilidades.NomeLogin + "! Seja Bem Vindo ao Sistema Cheff Toga!";
        }

        private void msMenuCadastroNovo_Click(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar a sessão?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
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
            
        }

        public void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {
            
        }

        public void msMenuCadastroExcluir_Click(object sender, EventArgs e)
        {
            
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeTela = "visualizarsaldo";
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            _fAlt.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeTela = "creditar";
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            _fAlt.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar a sessão?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                fTelaLogin _tela;
                _tela = new fTelaLogin();
                _tela.Show();
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            Utilidades.ControleDeTela = "autorizarporcpf";
            _fAlt.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeTela = "novo";
            fCadastroNovo _fCad;
            _fCad = new fCadastroNovo();
            _fCad.Show();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeTela = "visualizar";
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            _fAlt.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeTela = "alterar";
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            _fAlt.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeTela = "excluir";
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            _fAlt.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeTela = "novoOp";
            fCadastroNovoOp _fCad;
            _fCad = new fCadastroNovoOp();
            _fCad.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeTela = "visualizarOp";
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            _fAlt.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeTela = "alterarOp";
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            _fAlt.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeTela = "excluirOp";
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            _fAlt.Show();
        }

        private void encerrarSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar a sessão?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utilidades.Movimentacoes(0, "-", "-", "Logoff", "-", "-", 0); //registrador de movimentacões
                this.Close();
                fTelaLogin _tela;
                _tela = new fTelaLogin();
                _tela.Show();

            }
        }



    }
}
