using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RuBiz;

namespace Ru
{
    public partial class fTelaLogin : Form
    {
        public fTelaLogin()
        {
            InitializeComponent();
        }

        public void btnEntrar_Click(object sender, EventArgs e)
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var linq = (from i in context.Usuario
                            where i.CPF == this.mtbLogin.Text && i.Senha == this.txtSenha.Text
                            select i.CPF).ToList();

                if (linq.ToList().Count() >= 1)
                {
                    fCadastroGerenciar form = new fCadastroGerenciar();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    lblErroLogar.Text = "Usuário ou Senha incorretos!";
                }
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

        private void mtbLogin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnEntrar_Click(sender, e);
            }
        }

    }
}
