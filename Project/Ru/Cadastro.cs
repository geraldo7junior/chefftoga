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
    public partial class fCadastro : Form
    {
        public fCadastro()
        {
            InitializeComponent();
            txtID.Text = "Ver função p/ ID";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //CONTROLE DA SENHA
            if (txtSenha.Text != txtConfirmeSenha.Text)
            {
                MessageBox.Show("Senhas Diferentes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if ((txtSenha.Text == txtConfirmeSenha.Text) && (txtConfirmeSenha.Text == ""))
                {
                    MessageBox.Show("Digite a senha e confirme!","Erro", MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
                }

                else
                {

                    //CONTROLE DO NOME
                    if (txtNome.Text == "")
                    {
                        MessageBox.Show("Preencha o campo Nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else
                    {

                        //CONTROLE DE IDENTIDADE
                        if (txtIdenditade.Text=="")
                        {
                            MessageBox.Show("Preencha o campo Identidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        else
                        {

                            //CONTROLE DA DATA DE NASCIMENTO
                            if (!Utilidades.validaData(mtxtDataNasc.Text))
                            {
                                MessageBox.Show("Data de nascimento inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }

                            else
                            {

                                //CONTROLE DO CPF
                                if ((!Utilidades.validaCPF(mtxtCPF.Text)))
                                {
                                    MessageBox.Show("CPF Inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }

                                else
                                {

                                    //CONTROLE DO CURSO
                                    if (cbxCurso.Text == "")
                                    {
                                        MessageBox.Show("Selecione o Curso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }

                                    else
                                    {

                                        //CONTROLE DO PERÍODO
                                        if (cbxPeriodo.Text == "")
                                        {
                                            MessageBox.Show("Selecione o Período", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        }

                                        else
                                        {

                                            //CONTROLE DO ENDEREÇO.RUA
                                            if (txtRua.Text == "")
                                            {
                                                MessageBox.Show("No campo Endereço preencha o item Rua", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            }

                                            else
                                            {

                                                //CONTROLE DO ENDEREÇO.Nº
                                                if (txtN.Text == "")
                                                {
                                                    MessageBox.Show("No campo Endereço preencha o item Nº", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                }

                                                else
                                                {

                                                    //CONTROLE DO ENDEREÇO.BAIRRO
                                                    if (txtBairro.Text == "")
                                                    {
                                                        MessageBox.Show("No campo Endereço preencha o item Bairro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                    }

                                                    else
                                                    {

                                                        //CONTROLE DO ENDEREÇO.CIDADE
                                                        if (txtCidade.Text == "")
                                                        {
                                                            MessageBox.Show("No campo Endereço preencha o item Cidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                        }

                                                        else
                                                        {

                                                            //CONTROLE DO ENDEREÇO.UF
                                                            if (cbxUF.Text == "")
                                                            {
                                                                MessageBox.Show("Selecione UF", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                            }

                                                            else
                                                            {

                                                                //CONTROLE DO ENDEREÇO.CEP
                                                                if (!Utilidades.validaCEP(mtxtCEP.Text))
                                                                {
                                                                    MessageBox.Show("CEP Inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                }

                                                                else
                                                                {

                                                                    //CONTROLE DO FONE
                                                                    if (!Utilidades.validaFone(mtxtFone.Text))
                                                                    {
                                                                        MessageBox.Show("Fone Inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                    }

                                                                    //else
                                                                    //{

                                                                        //CONTROLE DA FOTO
                                                                        //if (ptcbFoto == "")
                                                                        //{
                                                                        //    MessageBox.Show("Insira a Foto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                        //}

                                                                        else
                                                                        {
                                                                            MessageBox.Show("Cadastro realizado com sucesso!","Validado");
                                                                            fLoginMan _fLog;
                                                                            _fLog = new fLoginMan();
                                                                            _fLog.Show();
                                                                            Hide();
                                                                        }
                                                                    //}
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
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
            fCadastro _fCad;
            _fCad = new fCadastro();
            _fCad.Show();
            Close();
        }

        private void msMenuCadastroAlterar_Click(object sender, EventArgs e)
        {
            fAlterar _fAlt;
            _fAlt = new fAlterar();
            _fAlt.Show();
        }

        private void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
