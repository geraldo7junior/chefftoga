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
            fCadastroNovo _fCad;
            _fCad = new fCadastroNovo();
            Utilidades.ControleDeTela = "novo";
            _fCad.Show();
         
            //fIndex _fLog;
            //_fLog = new fIndex();
            //_fLog.Show();
            //Hide();

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
            fAlterar _fAlt;
            _fAlt = new fAlterar();
            Utilidades.ControleDeTela = "alterar";
            _fAlt.Show();
            
        }

        public void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {
            fAlterar _fAlt;
            _fAlt = new fAlterar();
            Utilidades.ControleDeTela = "visualizar";
            _fAlt.Show();
        }

        public void msMenuCadastroExcluir_Click(object sender, EventArgs e)
        {
            fAlterar _fAlt;
            _fAlt = new fAlterar();
            Utilidades.ControleDeTela = "excluir";
            _fAlt.Show();
        }

        private void fCadastroGerenciar_Load(object sender, EventArgs e)
        {
            
        }

    }
}
