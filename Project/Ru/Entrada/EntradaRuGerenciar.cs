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
    public partial class fEntradaRuGerenciar : Form
    {
        public fEntradaRuGerenciar()
        {
            InitializeComponent();
            lblBemVindo.Text = "Olá " + Utilidades.NomeLogin + "! Seja Bem Vindo ao Sistema Cheff Toga!";

            
        }

        private void msMenuCadastroNovo_Click(object sender, EventArgs e)
        {
            fCadastroNovo _fCad;
            _fCad = new fCadastroNovo();
            _fCad.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void msMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void msMenuCadastroAlterar_Click(object sender, EventArgs e)
        {
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            Utilidades.ControleDeTela = "alterar";
            _fAlt.Show();
            
        }

        public void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            Utilidades.ControleDeTela = "autorizarporcpf";
            _fAlt.Show();
        }

        public void msMenuCadastroExcluir_Click(object sender, EventArgs e)
        {
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            Utilidades.ControleDeTela = "excluir";
            _fAlt.Show();
        }

        private void fCadastroGerenciar_Load(object sender, EventArgs e)
        {

        }

        private void pctbBoasVindas_Click(object sender, EventArgs e)
        {
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            Utilidades.ControleDeTela = "autorizarporcpf";
            _fAlt.Show();
        }

    }
}
