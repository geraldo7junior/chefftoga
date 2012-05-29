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
    public partial class fCreditoGerenciar : Form
    {
        public fCreditoGerenciar()
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
            Utilidades.ControleDeTela = "creditar";
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            _fAlt.Show();
            
        }

        public void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {
            Utilidades.ControleDeTela = "visualizarsaldo";
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

        private void fLoginMan_Load(object sender, EventArgs e)
        {

        }

        private void lblBemVindo_Click(object sender, EventArgs e)
        {

        }

    }
}
