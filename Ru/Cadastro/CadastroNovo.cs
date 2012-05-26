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
using System.Timers;

namespace Ru
{
    public partial class fCadastroNovo : Form
    {
        public fCadastroNovo()
        {
            InitializeComponent();
            txtID.Text = "Sistema Gera ID";
            CarregaCombobox();
            lblOperador.Text += Utilidades.NomeLogin;

            if (Utilidades.ControleDeTela == "alterar")
            {
                txtID.Text = Utilidades.Id_Card();
                txtNome.Text = Utilidades.Nome();
                txtIdentidade.Text = Utilidades.Identidade();
                txtDataNasc.Text = Utilidades.FuncDataNasc();
                txtCpf.Text = Utilidades.CpF();
                rbtnSim.Checked = Utilidades.Bolsista();
                cbxCurso.Text = Utilidades.Curso();
                cbxPeriodo.Text = Utilidades.Periodo();
                txtRua.Text = Utilidades.Rua();
                txtN.Text = Utilidades.Numero();
                txtBairro.Text = Utilidades.Bairro();
                txtCidade.Text = Utilidades.Cidade();
                cbxUF.Text = Utilidades.Uf();
                txtCep.Text = Utilidades.Cep();
                txtFone.Text = Utilidades.FuncFone();

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
            //põe asterisco nos campos em branco
            lblAstID.Text = Utilidades.PreencherCampos(txtID.Text);
            lblAstNome.Text = Utilidades.PreencherCampos(txtNome.Text);
            lblAstIdentidade.Text = Utilidades.PreencherCampos(txtIdentidade.Text);
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

            //manda de data de nascimento, fone
            Utilidades.DataNasc = this.txtDataNasc.Text;
            Utilidades.cep = this.txtCep.Text;
            Utilidades.fone = this.txtFone.Text;
            
            //NOVO CADASTRO
            if (Utilidades.ControleDeTela == "novo")
            {
                lblAstSenha.Text = Utilidades.PreencherCampos(txtSenha.Text);
                lblAstConfirmeSenha.Text = Utilidades.PreencherCampos(txtConfirmeSenha.Text);

                string cpfSpace = this.txtCpf.Text.Replace(" ", ".");
                string cpfHifen = cpfSpace.Replace("-", ".");
                Utilidades.Cpf = cpfHifen.Replace(".", "");

                //função para validar todos os campos
                Utilidades.ValidaCampos();
                if (Utilidades.ControleDeValidaCampos == "N")
                {
                    Utilidades.ControleDeValidaCampos = "";
                    Utilidades.ErrDataNasc = "";
                    Utilidades.ErrCep = "";
                    Utilidades.ErrFone = "";
                }

                //CONTROLE DE CAMPOS VAZIOS
                else if (lblAstBairro.Text == "*" || lblAstCep.Text == "*" || lblAstCidade.Text == "*" || lblAstConfirmeSenha.Text == "*" || lblAstCpf.Text == "*" || lblAstCurso.Text == "*" || lblAstDataNasc.Text == "*" || lblAstFone.Text == "*" || lblAstID.Text == "*" || lblAstIdentidade.Text == "*" || lblAstNome.Text == "*" || lblAstNum.Text == "*" || lblAstPeriodo.Text == "*" || lblAstRua.Text == "*" || lblAstSenha.Text == "*" || lblAstUf.Text == "*")
                {
                    MessageBox.Show("Preencha os campos em asterisco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                //CONTROLE DA SENHA
                else if (txtSenha.Text != txtConfirmeSenha.Text)
                {
                    MessageBox.Show("Senhas Diferentes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    using (CheffTogaEntities context = new CheffTogaEntities())
                    {
                        Usuario user = new Usuario();
                        user.RG = this.txtIdentidade.Text;
                        user.Nome = this.txtNome.Text;
                        user.Logradouro = this.txtRua.Text;
                        user.CPF = Utilidades.Cpf;
                        user.Periodo = this.cbxPeriodo.SelectedIndex + 1;
                        user.Id_Curso = this.cbxCurso.SelectedIndex + 1;
                        user.Bolsista = this.rbtnSim.Checked;
                        user.DataNascimento = this.txtDataNasc.Text;
                        var linq = (from i in context.Usuario select i.Id_Usuario).Max();
                        user.Id_Usuario = linq + 1;
                        user.Id_Card = Utilidades.GerarIdCard(linq + 1);
                        user.Numero = this.txtN.Text;
                        user.Bairro = this.txtBairro.Text;
                        user.Cidade = this.txtCidade.Text;
                        user.CEP = this.txtCep.Text;
                        user.Fone = this.txtFone.Text;
                        user.Senha = this.txtSenha.Text;
                        user.Id_TipoUsuario = 1;
                        user.UF = this.cbxUF.SelectedItem.ToString();
                        user.Saldo = 0;
                        user.Data_Refeicao = DateTime.Now.ToShortDateString();
                        user.Almoco = false;
                        user.Jantar = false;
                        context.AddObject("Usuario", user);
                        context.SaveChanges();

                        MessageBox.Show("Cadastro realizado com sucesso!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Close();
                    }
                }
            }

            //ALTERAR CADASTRO
            else
            {
                string cpfSpace = this.txtCpf.Text.Replace(" ", ".");
                string cpfHifen = cpfSpace.Replace("-", ".");
                Utilidades.CpfNovo = cpfHifen.Replace(".", "");

                //função para validar todos os campos
                Utilidades.ValidaCampos();
                if (Utilidades.ControleDeValidaCampos == "N")
                {
                    Utilidades.ControleDeValidaCampos = "";
                    Utilidades.ErrDataNasc = "";
                    Utilidades.ErrCep = "";
                    Utilidades.ErrFone = "";
                }
                
                //CONTROLE DE CAMPOS VAZIOS
                else if (lblAstBairro.Text == "*" || lblAstCep.Text == "*" || lblAstCidade.Text == "*" || lblAstConfirmeSenha.Text == "*" || lblAstCpf.Text == "*" || lblAstCurso.Text == "*" || lblAstDataNasc.Text == "*" || lblAstFone.Text == "*" || lblAstID.Text == "*" || lblAstIdentidade.Text == "*" || lblAstNome.Text == "*" || lblAstNum.Text == "*" || lblAstPeriodo.Text == "*" || lblAstRua.Text == "*" || lblAstSenha.Text == "*" || lblAstUf.Text == "*")
                {
                    MessageBox.Show("Preencha os campos em asterisco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                //CONTROLE DA SENHA
                else if (txtSenha.Text != txtConfirmeSenha.Text)
                {
                    MessageBox.Show("Senhas Diferentes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    Utilidades.nome = txtNome.Text;
                    Utilidades.identidade = txtIdentidade.Text;
                    Utilidades.rua = txtRua.Text;
                    Utilidades.numero = txtN.Text;
                    Utilidades.bairro = txtBairro.Text;
                    Utilidades.cidade = txtCidade.Text;
                    Utilidades.uf = cbxUF.SelectedItem.ToString();
                    Utilidades.cep = txtCep.Text;
                    Utilidades.fone = txtFone.Text;
                    Utilidades.bolsista = rbtnSim.Checked;
                    
                    using (CheffTogaEntities context = new CheffTogaEntities())
                    {
                        var linq = (from i in context.Curso
                                         where i.IdCurso == (this.cbxCurso.SelectedIndex + 1)
                                         select i.IdCurso).ToList();
                        Utilidades.IDCurso = linq[0];
                    }

                    //usar mesma lógica acima (CURSO) para PERIODO

                    Utilidades.AlterarDados();
                    Close();
                }
            }
        }

        private void msMenuCadastroSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o formulário e perder os dados alterados?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
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
                Utilidades.ControleDeTela = "alterar";
                fAlterar _fAlt;
                _fAlt = new fAlterar();
                _fAlt.Show();
            }
        }

        private void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente visualizar outro cadastro e perder os itens que não foram validados? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Utilidades.ControleDeTela = "visualizar";
                fAlterar _fAlt;
                _fAlt = new fAlterar();
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
                Utilidades.ControleDeTela = "excluir";
                fAlterar _fAlt;
                _fAlt = new fAlterar();
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
