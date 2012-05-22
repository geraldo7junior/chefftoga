using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using RuBiz;

namespace Ru
{
    public partial class fCadastroNovo : Form
    {
        public fCadastroNovo()
        {
            InitializeComponent();
            txtID.Text = "Ver função p/ ID";
            CarregaCombobox();
            lblOperador.Text += Utilidades.NomeLogin;

            if (Utilidades.ControleDeTela == "alterar")
            {
                txtNome.Text = Utilidades.Nome();
                txtIdenditade.Text = Utilidades.Identidade();
                //txtDataNasc.Text = Utilidades.DataNasc();
                txtCpf.Text = Utilidades.CpF();
                //cbxCurso.Text = Utilidades.Curso();
                //cbxPeriodo.Text = Utilidades.Periodo();
                txtRua.Text = Utilidades.Rua();
                txtN.Text = Utilidades.Numero();
                txtBairro.Text = Utilidades.Bairro();
                txtCidade.Text = Utilidades.Cidade();
                cbxUF.Text = Utilidades.Uf();
                txtCep.Text = Utilidades.Cep();
                txtFone.Text = Utilidades.Fone();
                //rbtnSim.Checked = Utilidades.Bolsista();

                txtSenha.Hide();
                txtConfirmeSenha.Hide();
                lblSenha.Hide();
                lblConfirmeSenha.Hide();
               
            }
        }

        private void CarregaCombobox()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
               //Filtro de Cursos apartir do DB:
                this.cbxCurso.DataSource = from i in context.Curso select i;
                this.cbxCurso.ValueMember = "IdCurso";
                this.cbxCurso.DisplayMember = "DescricaoCurso";
               
               //Filtro de Periodo apartir do DB:
                
            }
        }

        public void btnOk_Click(object sender, EventArgs e)
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
            if (Utilidades.ControleDeTela != "alterar")
            {
                lblAstSenha.Text = Utilidades.PreencherCampos(txtSenha.Text);
                lblAstConfirmeSenha.Text = Utilidades.PreencherCampos(txtConfirmeSenha.Text);
            }

            //CONTROLE DA SENHA
            if (txtSenha.Text != txtConfirmeSenha.Text)
            {
                MessageBox.Show("Senhas Diferentes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (lblAstBairro.Text == "*" || lblAstCep.Text == "*" || lblAstCidade.Text == "*" || lblAstConfirmeSenha.Text == "*" || lblAstCpf.Text == "*" || lblAstCurso.Text == "*" || lblAstDataNasc.Text == "*" || lblAstFone.Text == "*" || lblAstID.Text == "*" || lblAstIdentidade.Text == "*" || lblAstNome.Text == "*" || lblAstNum.Text == "*" || lblAstPeriodo.Text == "*" || lblAstRua.Text == "*" || lblAstSenha.Text == "*" || lblAstUf.Text == "*")
            {
                MessageBox.Show("Preencha os campos em asterisco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else if (Utilidades.ControleDeTela == "novo")
            {

                using (CheffTogaEntities context = new CheffTogaEntities())
                {   
                    Usuario user = new Usuario();
                    Cartao card = new Cartao();
                    user.RG = this.txtIdenditade.Text;
                    user.Nome = this.txtNome.Text;
                    user.Logradouro = this.txtRua.Text;
                    user.CPF = this.txtCpf.Text;
                    //user.Periodo = this.cbxPeriodo;
                    //curso
                    user.Bolsista = this.rbtnSim.Checked;
                    //data de nascimento
                    var linq = (from i in context.Usuario select i.Id_Usuario).Max();
                    user.Id_Usuario = linq + 1;
                    user.Numero = this.txtN.Text;
                    user.Bairro = this.txtBairro.Text;
                    user.Cidade = this.txtCidade.Text;
                    user.CEP = this.txtCep.Text;
                    user.Fone = this.txtFone.Text;
                    user.Senha = this.txtSenha.Text;
                    user.Id_TipoUsuario = 1;
                    user.UF = this.cbxUF.SelectedItem.ToString();
                    card.Saldo = 0;
                    context.AddObject("Usuario", user);
                    context.SaveChanges();
                    MessageBox.Show("Cadastro realizado com sucesso!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();
                }                
            }

            else if (Utilidades.ControleDeTela == "alterar")
            {
                Utilidades.CpfNovo = txtCpf.Text;
                Utilidades.nome = txtNome.Text;
                Utilidades.identidade = txtIdenditade.Text;
                Utilidades.rua = txtRua.Text;
                Utilidades.numero = txtN.Text;
                Utilidades.bairro = txtBairro.Text;
                Utilidades.cidade = txtCidade.Text;
                Utilidades.uf = cbxUF.SelectedItem.ToString();
                Utilidades.cep = txtCep.Text;
                Utilidades.fone = txtFone.Text;
                
                Utilidades.AlterarDados();

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
                Utilidades.ControleDeTela = "novo";
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

        private void msMenuImprimir_Click(object sender, EventArgs e)
        {
            printDialogDoc.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmeSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOk_Click(sender, e);
            }
        }


    }
}
