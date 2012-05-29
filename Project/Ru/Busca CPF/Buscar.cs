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
    public partial class fBuscar : Form
    {
        public fBuscar()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string cpfSpace = this.txtCPF.Text.Replace(" ", ".");
            string cpfHifen = cpfSpace.Replace("-", ".");
            Utilidades.Cpf = cpfHifen.Replace(".", "");

            using (CheffTogaEntities context = new CheffTogaEntities())
            {               
                var ExistenciaCadastro = (from i in context.Usuario
                                          where i.CPF == Utilidades.Cpf
                                          select Utilidades.Cpf).ToList();

                if (Utilidades.validaCPF(Utilidades.Cpf))
                {

                    if (ExistenciaCadastro.ToList().Count() == 1)
                    {

                        //Operador de Cadastro          
                        if (Utilidades.ControleDeTela == "alterar")
                        {
                            if (Utilidades.ErrAluno(Utilidades.Cpf) == false)
                            {
                                fCadastroNovo _fCad;
                                _fCad = new fCadastroNovo();
                                _fCad.Show();
                                Close();
                            }
                            else MessageBox.Show("Este cadastro pertence à um funcionário. Acesse-o através da opção Cadastro -> Operador", "Área Gerencial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else if (Utilidades.ControleDeTela == "visualizar")
                        {
                            if (Utilidades.ErrAluno(Utilidades.Cpf) == false)
                            {
                                fCadastroVisualizar _fCad;
                                _fCad = new fCadastroVisualizar();
                                _fCad.Show();
                                Close();
                            }
                            else MessageBox.Show("Este cadastro pertence à um funcionário. Acesse-o através da opção Cadastro -> Operador", "Área Gerencial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else if (Utilidades.ControleDeTela == "excluir")
                        {
                            if (Utilidades.ErrAluno(Utilidades.Cpf) == false)
                            {
                                fCadastroVisualizar _fVCad;
                                _fVCad = new fCadastroVisualizar();
                                _fVCad.Show();
                                Close();
                                if (MessageBox.Show("Deseja Realmente Excluir este Cadastro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Utilidades.ExcluirCadastro();

                                    MessageBox.Show("Cadastro excluído com sucesso!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    _fVCad.Close();
                                }
                            }
                            else MessageBox.Show("Este cadastro pertence à um funcionário. Acesse-o através da opção Cadastro -> Operador", "Área Gerencial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    //Operador de Credito
                        else if (Utilidades.ControleDeTela == "visualizarsaldo")
                        {
                            fCreditoVisualizar _fVCad;
                            _fVCad = new fCreditoVisualizar();
                            _fVCad.Show();
                            Close();
                        }

                        else if (Utilidades.ControleDeTela == "creditar")
                        {
                            fCreditoCreditar _fVCad;
                            _fVCad = new fCreditoCreditar();
                            _fVCad.Show();
                            Close();
                        }

                    //Operador de Autorização
                        else if (Utilidades.ControleDeTela == "autorizarporcpf")
                        {
                            Close();
                            fEntradaRuAutorizar _fVCad;
                            _fVCad = new fEntradaRuAutorizar();
                            _fVCad.Show();
                            
                        }

                        //Gerente Cadastro de Operadores ALTERAR          
                        else if (Utilidades.ControleDeTela == "alterarOp")
                        {
                            if (Utilidades.ErrOperador(Utilidades.Cpf) == false)
                            {
                                fCadastroNovoOp _fCad;
                                _fCad = new fCadastroNovoOp();
                                _fCad.Show();
                                Close();
                            }
                            else MessageBox.Show("Este cadastro pertence à um aluno. Acesse-o através da opção Cadastro -> Aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        //Gerente Cadastro de Operadores VISUALIZAR          
                        else if (Utilidades.ControleDeTela == "visualizarOp")
                        {
                            if (Utilidades.ErrOperador(Utilidades.Cpf) == false)
                            {
                                fCadastroVisualizarOp _fCad;
                                _fCad = new fCadastroVisualizarOp();
                                _fCad.Show();
                                Close();
                            }
                            else MessageBox.Show("Este cadastro pertence à um aluno. Acesse-o através da opção Cadastro -> Aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else if (Utilidades.ControleDeTela == "excluirOp")
                        {
                            if (Utilidades.ErrOperador(Utilidades.Cpf) == false)
                            {
                                fCadastroVisualizarOp _fVCad;
                                _fVCad = new fCadastroVisualizarOp();
                                _fVCad.Show();
                                Close();
                                if (MessageBox.Show("Deseja Realmente Excluir este Cadastro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Utilidades.ExcluirCadastro();

                                    MessageBox.Show("Cadastro excluído com sucesso!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    _fVCad.Close();
                                }
                            }
                            else MessageBox.Show("Este cadastro pertence à um aluno. Acesse-o através da opção Cadastro -> Aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                    else
                    {
                        MessageBox.Show("CPF não Cadastrado", "Buca de CPF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                else
                {
                    MessageBox.Show("CPF Inválido!", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            

            
            
        }

        private void fAlterar_Load(object sender, EventArgs e)
        {

        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOk_Click(sender, e);
            }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOk_Click(sender, e);
            }
        }
    }
}
