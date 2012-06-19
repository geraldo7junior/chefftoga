using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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

        private void bandejaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBandeja _fAlt;
            _fAlt = new fBandeja();
            _fAlt.Show();
        }

        private void retirarCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeTela = "retirarcredito";
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            _fAlt.Show();
        }

        private void bloquearTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeStatus = "bloquear";
            fStatus _fst = new fStatus();
            _fst.Show(); 
        }

        private void desbloquearTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeStatus = "desbloquear";
            fStatus _fst = new fStatus();
            _fst.Show(); 
        }

        private void bloquearTodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeStatus = "bloquearOp";
            fStatus _fst = new fStatus();
            _fst.Show(); 
        }

        private void desbloquearTodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeStatus = "desbloquearOp";
            fStatus _fst = new fStatus();
            _fst.Show(); 
        }

        private void gerarRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatórioGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void porDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.filtro = "data";
            fFiltroRelatorio _fAlt = new fFiltroRelatorio();
            _fAlt.Show();
        }

        private void porCPFDoOperadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.filtro = "operador";
            fFiltroRelatorio _fAlt = new fFiltroRelatorio();
            _fAlt.Show();
        }

        private void porCPFDoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.filtro = "aluno";
            fFiltroRelatorio _fAlt = new fFiltroRelatorio();
            _fAlt.Show();
        }

        private void porTipoDeMovimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.filtro = "movimentacao";
            fFiltroRelatorio _fAlt = new fFiltroRelatorio();
            _fAlt.Show();
        }

        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.filtro = "geral";
            fFiltroRelatorio _fAlt = new fFiltroRelatorio();
            _fAlt.Show();
        }



    }
}
