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
    public partial class fCadastroNovoOp : Form
    {
        public fCadastroNovoOp()
        {
            InitializeComponent();
            txtID.Text = "Sistema Gera ID";
            lblOperador.Text += Utilidades.NomeLogin;
            cbxStatus.Text = "Desbloqueado";

            if (Utilidades.ControleDeTela == "alterarOp")
            {
                txtID.Text = Utilidades.Id_Card();
                cbxStatus.Text = Utilidades.Status();
                txtNome.Text = Utilidades.Nome();
                txtIdentidade.Text = Utilidades.Identidade();
                txtDataNasc.Text = Utilidades.FuncDataNasc();
                txtCpf.Text = Utilidades.CpF();
                rbtnSim.Checked = Utilidades.Bolsista();
                try { pctbFoto.Image = Image.FromFile(Utilidades.Foto()); }
                catch { MessageBox.Show("Imagem não encontrada. Verifique o nome da imagem e seu local. Deve estar em (C:->CheffTogaFotos) e seu nome deve ser o número do Cartão do Cliente", "Imagem não encontrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

                //tipo de operador
                if (Utilidades.TipoOperador() == 2) rbtnOpCadastro.Checked = true;
                else if (Utilidades.TipoOperador() == 3) rbtnOpCredito.Checked = true;
                else if (Utilidades.TipoOperador() == 4) rbtnOpEntradaRU.Checked = true;
                else if (Utilidades.TipoOperador() == 5) rbtnGerente.Checked = true;

                txtRua.Text = Utilidades.Rua();
                txtN.Text = Utilidades.Numero();
                txtBairro.Text = Utilidades.Bairro();
                txtCidade.Text = Utilidades.Cidade();
                cbxUF.Text = Utilidades.Uf();
                txtCep.Text = Utilidades.Cep();
                txtFone.Text = Utilidades.FuncFone();
                txtEmail.Text = Utilidades.Email();

                txtSenha.Hide();
                txtConfirmeSenha.Hide();
                lblSenha.Hide();
                lblConfirmeSenha.Hide();

                //Variáveis para verificar alterações em Campos
                Utilidades.DataNascCampos = this.txtDataNasc.Text;
                Utilidades.CepCampos = this.txtCep.Text;
                Utilidades.FoneCampos = this.txtFone.Text;               
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
            lblAstTipoOperador.Text = Utilidades.PreencherCamposVF(rbtnGerente.Checked, rbtnOpCadastro.Checked, rbtnOpCredito.Checked, rbtnOpEntradaRU.Checked);
            lblAstRua.Text = Utilidades.PreencherCampos(txtRua.Text);
            lblAstNum.Text = Utilidades.PreencherCampos(txtN.Text);
            lblAstBairro.Text = Utilidades.PreencherCampos(txtBairro.Text);
            lblAstCidade.Text = Utilidades.PreencherCampos(txtCidade.Text);
            lblAstUf.Text = Utilidades.PreencherCampos(cbxUF.Text);
            lblAstCep.Text = Utilidades.PreencherCampos(txtCep.Text);
            lblAstFone.Text = Utilidades.PreencherCampos(txtFone.Text);
            lblAstEmail.Text = Utilidades.PreencherCampos(txtEmail.Text);

            //manda de data de nascimento, fone
            Utilidades.DataNasc = this.txtDataNasc.Text;
            Utilidades.cep = this.txtCep.Text;
            Utilidades.fone = this.txtFone.Text;
            
            //NOVO CADASTRO
            if (Utilidades.ControleDeTela == "novoOp")
            {
                lblAstSenha.Text = Utilidades.PreencherCampos(txtSenha.Text);
                lblAstConfirmeSenha.Text = Utilidades.PreencherCampos(txtConfirmeSenha.Text);

                string cpfSpace = this.txtCpf.Text.ToString().Replace(" ", ".");
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
                else if (lblAstBairro.Text == "*" || lblAstCep.Text == "*" || lblAstCidade.Text == "*" || lblAstConfirmeSenha.Text == "*" || lblAstCpf.Text == "*" || lblAstTipoOperador.Text == "*" || lblAstDataNasc.Text == "*" || lblAstFone.Text == "*" || lblAstEmail.Text == "*" || lblAstID.Text == "*" || lblAstIdentidade.Text == "*" || lblAstNome.Text == "*" || lblAstNum.Text == "*" || lblAstRua.Text == "*" || lblAstSenha.Text == "*" || lblAstUf.Text == "*")
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
                        user.Status = cbxStatus.Text;
                        user.RG = this.txtIdentidade.Text;
                        user.Nome = this.txtNome.Text;
                        user.Logradouro = this.txtRua.Text;
                        user.CPF = Utilidades.Cpf;
                        user.Id_TipoUsuario = Utilidades.SelecionaUsuario(rbtnGerente.Checked,rbtnOpCadastro.Checked,rbtnOpCredito.Checked,rbtnOpEntradaRU.Checked);
                        user.Bolsista = this.rbtnSim.Checked;
                        user.DataNascimento = this.txtDataNasc.Text;
                        var linq = (from i in context.Usuario select i.Id_Usuario).Max();
                        user.Id_Usuario = linq + 1;
                        user.Id_Periodo = 0;
                        user.Id_Curso = 0;
                        user.Id_Card = Utilidades.GerarIdCard(linq + 1);
                        user.Numero = this.txtN.Text;
                        user.Bairro = this.txtBairro.Text;
                        user.Cidade = this.txtCidade.Text;
                        user.CEP = this.txtCep.Text;
                        user.Fone = this.txtFone.Text;
                        user.E_mail = this.txtEmail.Text;
                        user.Senha = this.txtSenha.Text;
                        user.UF = this.cbxUF.SelectedItem.ToString();
                        user.Saldo = 0;
                        user.Bandeja_Em_Espera = false;
                        user.Data_Refeicao = DateTime.Now.ToShortDateString();
                        user.Almoco = false;
                        user.Jantar = false;
                        user.Foto = Utilidades.pasta_fotos(Utilidades.GerarIdCard(linq + 1));
                        context.AddObject("Usuario", user);
                        context.SaveChanges();

                        Utilidades.Movimentacoes(user.Id_Card, Utilidades.Cpf, txtNome.Text, "Novo Cadastro de Operador", "Todos", "-", 0); //registrador de movimentacões
                        MessageBox.Show("Cadastro realizado com sucesso!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Close();
                    }
                }
            }

            //ALTERAR CADASTRO
            else
            {
                string cpfSpace = this.txtCpf.Text.ToString().Replace(" ", ".");
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
                else if (lblAstBairro.Text == "*" || lblAstCep.Text == "*" || lblAstCidade.Text == "*" || lblAstConfirmeSenha.Text == "*" || lblAstCpf.Text == "*" || lblAstTipoOperador.Text == "*" || lblAstDataNasc.Text == "*" || lblAstFone.Text == "*" || lblAstEmail.Text == "*" || lblAstID.Text == "*" || lblAstIdentidade.Text == "*" || lblAstNome.Text == "*" || lblAstNum.Text == "*" || lblAstRua.Text == "*" || lblAstSenha.Text == "*" || lblAstUf.Text == "*")
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
                    Utilidades.status = cbxStatus.Text;
                    Utilidades.nome = txtNome.Text;
                    Utilidades.identidade = txtIdentidade.Text;
                    Utilidades.rua = txtRua.Text;
                    Utilidades.numero = txtN.Text;
                    Utilidades.bairro = txtBairro.Text;
                    Utilidades.cidade = txtCidade.Text;
                    Utilidades.uf = cbxUF.SelectedItem.ToString();
                    Utilidades.cep = txtCep.Text;
                    Utilidades.fone = txtFone.Text;
                    Utilidades.email = txtEmail.Text;
                    Utilidades.bolsista = rbtnSim.Checked;
                    Utilidades.TipoUser = Utilidades.SelecionaUsuario(rbtnGerente.Checked, rbtnOpCadastro.Checked, rbtnOpCredito.Checked, rbtnOpEntradaRU.Checked);
                    Utilidades.IDCurso = 0;
                    Utilidades.IDPeriodo = 0;
                    Utilidades.DataNasc = txtDataNasc.Text;

                    //Verificar campos alterados, alterar dados, informar movimentações                   
                    Utilidades.AltCampos();
                    Utilidades.AlterarDados();
                    Utilidades.Movimentacoes(Utilidades.IdCard, Utilidades.Cpf, txtNome.Text, "Alterar Cadastro de Operador", Utilidades.modificacao, "-", 0); //registrador de movimentacões
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
                Utilidades.ControleDeTela = "novoOp";
                fCadastroNovoOp _fCad;
                _fCad = new fCadastroNovoOp();
                _fCad.Show();
                Close();
            }
        }

        private void msMenuCadastroAlterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente alterar outro cadastro e perder os itens que não foram validados? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Utilidades.ControleDeTela = "alterarOp";
                fBuscar _fAlt;
                _fAlt = new fBuscar();
                _fAlt.Show();
            }
        }

        private void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente visualizar outro cadastro e perder os itens que não foram validados? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Utilidades.ControleDeTela = "visualizarOp";
                fBuscar _fAlt;
                _fAlt = new fBuscar();
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
                Utilidades.ControleDeTela = "excluirOp";
                fBuscar _fAlt;
                _fAlt = new fBuscar();
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

        private void rbtnNao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pctbFoto_Click(object sender, EventArgs e)
        {
            if ((Utilidades.ControleDeTela == "novoOp") || (Utilidades.ControleDeTela == "alterarOp")) System.Diagnostics.Process.Start(@"C:\Program Files\Acer Crystal Eye webcam\CrystalEye.exe");           
        }


    }
}
