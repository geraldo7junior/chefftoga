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

            txtNome.Text = Utilidades.Nome();
            mtxtCPF.Text = Utilidades.CpF();
            //cbxCurso.Text = Utilidades.Curso();
            //cbxPeriodo.Text = Utilidades.Periodo();
            mtxtFone.Text = Utilidades.Fone();
            //rbtnSim.Checked = Utilidades.Bolsista();
            txtSaldo.Text = Utilidades.Saldo();
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
            
            string hora = DateTime.Now.ToShortTimeString();
            string hora1 = hora[0].ToString() + hora[1].ToString();
            int h = int.Parse(hora1);

            if ((h>=17) && (h<=20))
            {
                Utilidades.ValorASerCobrado = decimal.Parse("2,6");
                Utilidades.Debitar();                
                Close();
            }
            else if ((h >= 11) && (h <= 17))
            {
                Utilidades.ValorASerCobrado = decimal.Parse("3");
                Utilidades.Debitar();
                Close();
            }

            else
            {
                MessageBox.Show("Não Autorizado! Fora do horário de refeição!", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
            

            /* 
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
