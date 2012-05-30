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

            string cpfSpace = this.mtbLogin.Text.Replace(" ", ".");
            string cpfHifen = cpfSpace.Replace("-", ".");
            Utilidades.CpfOperador = cpfHifen.Replace(".", "");

            if (Utilidades.validaCPF(Utilidades.CpfOperador))
            {
                using (CheffTogaEntities context = new CheffTogaEntities())
                {

                    var linq = (from i in context.Usuario
                                where i.CPF == Utilidades.CpfOperador && i.Senha == this.txtSenha.Text
                                select i.Id_TipoUsuario).ToList();

                    if (linq.ToList().Count() == 1)
                    {
                        Utilidades.Cpf = Utilidades.CpfOperador; //para poder verificar status ao logar
                        if (Utilidades.VerStatus() == true)
                        {
                            //Guardar nome do operador; mostrá-lo nas telas
                            var lista = (from i in context.Usuario
                                         where i.CPF == Utilidades.CpfOperador && i.Senha == this.txtSenha.Text
                                         select i.Nome).ToList();
                            Utilidades.NomeOperador = lista[0];
                            Utilidades.NomeLogin = Utilidades.NomeOperador;

                            //guardar id do Operador
                            var listaid = (from i in context.Usuario
                                           where i.CPF == Utilidades.CpfOperador && i.Senha == this.txtSenha.Text
                                           select i.Id_Card).ToList();
                            Utilidades.IDOperador = listaid[0];

                            Utilidades.Movimentacoes(0, "-", "-", "Login", "-", "-", 0); //registrador de movimentacões

                            if ((linq.ToList().Count() == 1) && (linq[0] == 1))
                            {
                                //abrir pagina dos alunos
                            }

                            else if ((linq.ToList().Count() == 1) && (linq[0] == 2))
                            {
                                fCadastroGerenciar form = new fCadastroGerenciar();
                                form.Show();
                                this.Hide();
                            }

                            else if ((linq.ToList().Count() == 1) && (linq[0] == 3))
                            {
                                fCreditoGerenciar form = new fCreditoGerenciar();
                                form.Show();
                                this.Hide();
                            }

                            else if ((linq.ToList().Count() == 1) && (linq[0] == 4))
                            {
                                fEntradaRuGerenciar form = new fEntradaRuGerenciar();
                                form.Show();
                                this.Hide();
                            }

                            else if ((linq.ToList().Count() == 1) && (linq[0] == 5))
                            {
                                fGerenteGerenciar form = new fGerenteGerenciar();
                                form.Show();
                                this.Hide();
                            }

                            else if ((linq.ToList().Count() == 1) && (linq[0] == 6))
                            {
                                //abrir pagina dos Developers
                            }
                        }
                        else MessageBox.Show("Usuário Bloqueado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else
                    {
                        lblErroLogar.Text = "Usuário ou Senha incorretos!";
                    }
                }

            }

            else
            {
                lblErroLogar.Text = "Usuário ou Senha incorretos!";
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
