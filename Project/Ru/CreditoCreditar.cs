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
    public partial class fCreditoCreditar : Form
    {
        public fCreditoCreditar()
        {
            InitializeComponent();
            txtID.Text = "Ver função p/ ID";
            txtNome.Text = "Mário Gomes";
        }

        private void msMenuCadastroSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            if (MessageBox.Show("Deseja Realmente creditar em outro usuário e perder os valores não creditados no usuário atual?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                fAlterar _fAlt;
                _fAlt = new fAlterar();
                Utilidades.ControleDeTela = "creditar";
                _fAlt.Show();
            }
        }

        private void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente visualizar outro saldo e perder os valores não creditados?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                fAlterar _fAlt;
                _fAlt = new fAlterar();
                Utilidades.ControleDeTela = "visualizarsaldo";
                _fAlt.Show();
            }
            

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

        private void btnCreditar_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Deseja realmente creditar R$ " + txtValorASerCreditado.Text + " ao aluno " + txtNome.Text + "?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // criar função para fazer: (saldo += txtValorASerCreditado) no banco de dados
                MessageBox.Show("O novo saldo do aluno " + txtNome.Text + " é " + "buscar saldo no DB" + "!", "Operação realizada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
                
            }
     
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
           
        }
     


    }
}
