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
    public partial class fTelaLogin : Form
    {
        public fTelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login;
            string senha;
            login = mtbLogin.Text;
            senha = txtSenha.Text;

            if (txtSenha.Text == "123")
            {
                lblErroLogar.Text = "Usuário ou Senha incorretos!";
            }
            else
            {
                fLoginMan _fLog;
                _fLog = new fLoginMan();
                _fLog.Show();
                Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fTelaLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
