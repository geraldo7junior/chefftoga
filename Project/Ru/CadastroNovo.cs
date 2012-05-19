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
    public partial class fCadastroNovo : Form
    {
        public fCadastroNovo()
        {
            InitializeComponent();
            txtID.Text = "Ver função p/ ID";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblAstID.Text = Utilidades.PreencherCampos(txtID.Text);
            lblAstNome.Text = Utilidades.PreencherCampos(txtNome.Text);
            lblAstIdentidade.Text = Utilidades.PreencherCampos(txtIdenditade.Text);
            lblAstDataNasc.Text = Utilidades.PreencherCampos(txtDataNasc.Text);
            lblAstCpf.Text = Utilidades.PreencherCampos(txtCpf.Text);
            lblAstCurso.Text = Utilidades.PreencherCampos(cbxCurso.Text);
            lblAstPeriodo.Text = Utilidades.PreencherCampos(cbxPeriodo.Text);
            lblAstRua.Text = Utilidades.PreencherCampos(txtRua.Text);
            lblAstNum.Text = Utilidades.PreencherCampos(txtN.Text);
            lblAstBairro.Text = Utilidades.PreencherCampos(txtBairro.Text);
            lblAstCidade.Text = Utilidades.PreencherCampos(txtCidade.Text);
            lblAstUf.Text = Utilidades.PreencherCampos(cbxUF.Text);
            lblAstCep.Text = Utilidades.PreencherCampos(txtCep.Text);
            lblAstFone.Text = Utilidades.PreencherCampos(txtFone.Text);
            lblAstSenha.Text = Utilidades.PreencherCampos(txtSenha.Text);
            lblAstConfirmeSenha.Text = Utilidades.PreencherCampos(txtConfirmeSenha.Text);

            //CONTROLE DA SENHA
            if (txtSenha.Text != txtConfirmeSenha.Text)
            {
                MessageBox.Show("Senhas Diferentes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (lblAstBairro.Text == "*" || lblAstCep.Text == "*" || lblAstCidade.Text == "*" || lblAstConfirmeSenha.Text == "*" || lblAstCpf.Text == "*" || lblAstCurso.Text == "*" || lblAstDataNasc.Text == "*" || lblAstFone.Text == "*" || lblAstID.Text == "*" || lblAstIdentidade.Text == "*" || lblAstNome.Text == "*" || lblAstNum.Text == "*" || lblAstPeriodo.Text == "*" || lblAstRua.Text == "*" || lblAstSenha.Text == "*" || lblAstUf.Text == "*")
            {
                MessageBox.Show("Preencha os campos em asterisco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("Cadastro/Alteração realizado(a) com sucesso!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //funcao para cadastrar/alterar no DB
                Close();
            }
                

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
            if (MessageBox.Show("Deseja realmente realizar NOVO cadastro e perder os itens que não foram validados? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fCadastroNovo _fCad;
                _fCad = new fCadastroNovo();
                _fCad.Show();
                Close();
            }
        }

        private void msMenuCadastroAlterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente alterar outro cadastro e perder os itens que não foram validados? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                fAlterar _fAlt;
                _fAlt = new fAlterar();
                Utilidades.ControleDeTela = "alterar";
                _fAlt.Show();
            }
        }

        private void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente visualizar outro cadastro e perder os itens que não foram validados? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                fAlterar _fAlt;
                _fAlt = new fAlterar();
                Utilidades.ControleDeTela = "visualizar";
                _fAlt.Show();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void msMenuCadastroExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir outro cadastro e perder os itens que não foram validados? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                fAlterar _fAlt;
                _fAlt = new fAlterar();
                Utilidades.ControleDeTela = "excluir";
                _fAlt.Show();
            }
        }

        private void pctbRU_Click(object sender, EventArgs e)
        {

        }


    }
}
