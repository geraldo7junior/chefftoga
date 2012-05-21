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
    public partial class fEntradaRuAutorizar : Form
    {
        public fEntradaRuAutorizar()
        {
            InitializeComponent();
            txtID.Text = "Ver função p/ ID";
            lblOperador.Text += Utilidades.NomeLogin;
        }

        private void msMenuCadastroSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fCadastro_Load(object sender, EventArgs e)
        {
            
        }

        private void msMenuCadastroNovo_Click(object sender, EventArgs e)
        {
            fCadastroNovo _fCad;
            _fCad = new fCadastroNovo();
            _fCad.Show();
            Close();
        }

        private void msMenuCadastroAlterar_Click(object sender, EventArgs e)
        {
            fCreditoCreditar _fCad;
            _fCad = new fCreditoCreditar();
            //chamar todos os dados do banco de dados aqui
            _fCad.Show();
            Close();
        }

        private void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {

            this.Close();
            fAlterar _fAlt;
            _fAlt = new fAlterar();
            Utilidades.ControleDeTela = "visualizarsaldo";
            _fAlt.Show();

        }

        private void msMenuCadastroExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Excluir este Cadastro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                // criar função para excluir cadastro do banco de dados
            }
        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPeriodo_Click(object sender, EventArgs e)
        {

        }

        private void lblCurso_Click(object sender, EventArgs e)
        {

        }

        private void txtSaldo_FontChanged(object sender, EventArgs e)
        {

        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autorizado!", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();

            /* 
             * valor a ser debitado dependente do horário
             * if (saldo < valor a ser debitado)
             * {
             *      MessageBox.Show("Saldo insuficiente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             *      Close();
             * }
             * 
             * else if (o campo "em_espera" do DB = "TRUE")
             * {
             *      MessageBox.Show("Refeição em espera!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             *      o sistema autoriza a entrada no Ru
             *      Close();
             *      (depois de passar na bandeja o valor de "em_espera" volta pra "FALSE")
             * }
             * 
             * else if (o campo "refeicao" do DB = "TRUE")
             * {
             *      MessageBox.Show("Refeição já efetuada!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             *      Close();
             * }
             * 
             * 
             * else
             * {
             *      função para debitar do saldo no DB
             *      o sistema autoriza a entrada no Ru
             *      torna o campo "refeicao" do DB com valor "TRUE"
             *      torna o campo "em_espera" do DB com valor "TRUE" ==>> autorização da bandeja (depois de passar na bandeja o valor volta pra "FALSE")
             *      MessageBox.Show("Autorizado!", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
             *      Close();
             * }
             */

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fEntradaRuAutorizar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAutorizar_Click(sender, e);
            }
        }


    }
}
