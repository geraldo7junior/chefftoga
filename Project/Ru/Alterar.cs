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
    public partial class fAlterar : Form
    {
        public fAlterar()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                string VerCpf = this.txtCPF.Text;
                
                var ExistenciaCadastro = (from i in context.Usuario
                                          where i.CPF == VerCpf
                                          select VerCpf).ToList();

                if ((ExistenciaCadastro.ToList().Count() == 1) && (ExistenciaCadastro[0] == this.txtCPF.Text))
                {
                    Utilidades.Cpf = this.txtCPF.Text;

                    //Operador de Cadastro          
                    if (Utilidades.ControleDeTela == "alterar")
                    {
                        fCadastroNovo _fCad;
                        _fCad = new fCadastroNovo();
                        //chamar todos os dados do banco de dados aqui
                        _fCad.Show();
                        Close();
                    }

                    else if (Utilidades.ControleDeTela == "visualizar")
                    {
                        fCadastroVisualizar _fVCad;
                        _fVCad = new fCadastroVisualizar();
                        //chamar todos os dados do banco de dados aqui
                        _fVCad.Show();
                        Close();
                    }

                    else if (Utilidades.ControleDeTela == "excluir")
                    {
                        fCadastroVisualizar _fVCad;
                        _fVCad = new fCadastroVisualizar();
                        //chamar todos os dados do banco de dados aqui
                        _fVCad.Show();
                        Close();
                        if (MessageBox.Show("Deseja Realmente Excluir este Cadastro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MessageBox.Show("Cadastro excluído com sucesso!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            // criar função aqui para excluir cadastro do banco de dados
                            _fVCad.Close();


                        }
                    }

                //Operador de Credito
                    else if (Utilidades.ControleDeTela == "visualizarsaldo")
                    {
                        fCreditoVisualizar _fVCad;
                        _fVCad = new fCreditoVisualizar();
                        //chamar todos os dados de crédito do banco de dados aqui
                        _fVCad.Show();
                        Close();
                    }

                    else if (Utilidades.ControleDeTela == "creditar")
                    {
                        fCreditoCreditar _fVCad;
                        _fVCad = new fCreditoCreditar();
                        //chamar todos os dados de crédito do banco de dados aqui
                        _fVCad.Show();
                        Close();
                    }

                //Operador de Autorização
                    else if (Utilidades.ControleDeTela == "autorizarporcpf")
                    {
                        fEntradaRuAutorizar _fVCad;
                        _fVCad = new fEntradaRuAutorizar();
                        //chamar todos os dados de crédito do banco de dados aqui
                        _fVCad.Show();
                        Close();
                    }

                }

                else
                {
                    MessageBox.Show("CPF não Cadastrado", "Buca de CPF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
