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
    public partial class fCreditoCreditar : Form
    {
        public fCreditoCreditar()
        {
            InitializeComponent();
            lblOperador.Text += Utilidades.NomeLogin;
            Utilidades.CarregaCombobox(cbxCurso, cbxPeriodo);

            txtID.Text = Utilidades.Id_Card();
            cbxStatus.Text = Utilidades.Status();
            txtNome.Text = Utilidades.Nome();
            mtxtCPF.Text = Utilidades.CpF();
            rbtnSim.Checked = Utilidades.Bolsista();
            mtxtFone.Text = Utilidades.FuncFone();
            txtEmail.Text = Utilidades.Email();
            txtSaldo.Text = Utilidades.Saldo();    
            if (Utilidades.ControleDeTela == "creditar")
            {
                cbxCurso.Text = Utilidades.Curso();
                cbxPeriodo.Text = Utilidades.Periodo();
                gpbTipoOperador.Hide();
                lblValorASerDebitado.Hide();
                lblDebitador.Hide();
                btnDebitar.Hide();
                txtObs.Hide();
                lblObs.Hide();
            }

            else if(Utilidades.ControleDeTela == "creditarOp")
            {                   
                lblPeriodo.Hide();
                lblCurso.Hide();
                cbxPeriodo.Hide();
                cbxCurso.Hide();
                lblValorASerDebitado.Hide();
                lblDebitador.Hide();
                btnDebitar.Hide();
                txtObs.Hide();
                lblObs.Hide();

                //tipo de operador
                if (Utilidades.TipoOperador() == 2) rbtnOpCadastro.Checked = true;
                else if (Utilidades.TipoOperador() == 3) rbtnOpCredito.Checked = true;
                else if (Utilidades.TipoOperador() == 4) rbtnOpEntradaRU.Checked = true;
                else if (Utilidades.TipoOperador() == 5) rbtnGerente.Checked = true;
            }
       
            else if (Utilidades.ControleDeTela == "retirarcredito")
            {
                cbxCurso.Text = Utilidades.Curso();
                cbxPeriodo.Text = Utilidades.Periodo();
                gpbTipoOperador.Hide();
            }

            else if (Utilidades.ControleDeTela == "retirarcreditoOp")
            {
                lblPeriodo.Hide();
                lblCurso.Hide();
                cbxPeriodo.Hide();
                cbxCurso.Hide();

                //tipo de operador
                if (Utilidades.TipoOperador() == 2) rbtnOpCadastro.Checked = true;
                else if (Utilidades.TipoOperador() == 3) rbtnOpCredito.Checked = true;
                else if (Utilidades.TipoOperador() == 4) rbtnOpEntradaRU.Checked = true;
                else if (Utilidades.TipoOperador() == 5) rbtnGerente.Checked = true;
            }

        }

        private void msMenuCadastroSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar SEM CREDITAR o valor?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fCadastro_Load(object sender, EventArgs e)
        {
            if (Utilidades.ControleDeTela == "creditarOp")
            {
                MessageBox.Show("Operação não autorizada! Este usuário é um Operador.", "Autorização", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

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
                Utilidades.ControleDeTela = "creditar";
                fBuscar _fAlt;
                _fAlt = new fBuscar();
                _fAlt.Show();
            }
        }

        private void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente visualizar outro saldo e perder os valores não creditados?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Utilidades.ControleDeTela = "visualizarsaldo";
                fBuscar _fAlt;
                _fAlt = new fBuscar();
                _fAlt.Show();
            }
            

        }

        private void msMenuCadastroExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Excluir este Cadastro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
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
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var SaldoDB = (from i in context.Usuario
                            where i.CPF == Utilidades.Cpf
                            select i.Saldo).ToList();

                float saldo = float.Parse(SaldoDB[0].ToString());

                var listaid = (from i in context.Usuario
                               where i.CPF == Utilidades.Cpf
                               select i.Id_Card).ToList();

                int id = listaid[0];

                var listanome = (from i in context.Usuario
                               where i.CPF == Utilidades.Cpf
                               select i.Nome).ToList();

                string nome = listanome[0];

                if ((saldo + float.Parse(txtValorASerCreditado.Text)) > 999)
                {
                    MessageBox.Show("NÃO AUTORIZADO! O saldo não pode exceder R$ 999,00", "Autorização!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (MessageBox.Show("Deseja realmente creditar R$ " + txtValorASerCreditado.Text + " ao aluno " + txtNome.Text + "?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string ValorSpace = this.txtValorASerCreditado.Text.Replace(" ", "");
                    Utilidades.credito = float.Parse(ValorSpace);

                    Utilidades.Creditar();

                    Utilidades.Movimentacoes(id, Utilidades.Cpf, nome, "Inserir Crédito", "-", "-", Utilidades.credito); //registrador de movimentacões

                    MessageBox.Show("O novo saldo do aluno " + txtNome.Text + " é R$ " + Utilidades.saldo + "!", "Operação realizada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();

                }
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtValorASerCreditado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorASerCreditado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (e.KeyChar == 13)
            {
               btnCreditar_Click(sender, e);
            }
        }

        private void msMenuImprimir_Click(object sender, EventArgs e)
        {
            printDialogDoc.ShowDialog();
        }

        private void txtValorASerCreditado_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        string str = "";
        private void txtValorASerCreditado_KeyDown(object sender, KeyEventArgs e)
        {            
            int KeyCode = e.KeyValue;

            if (!IsNumeric(KeyCode))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = true;
            }
            if (((KeyCode == 8) || (KeyCode == 46)) && (str.Length > 0))
            {
                str = str.Substring(0, str.Length - 1);
            }
            else if (!((KeyCode == 8) || (KeyCode == 46)))
            {
                str = str + Convert.ToChar(KeyCode);
            }
            if (str.Length == 0)
            {
                txtValorASerCreditado.Text = "";
            }
            if (str.Length == 1)
            {
                txtValorASerCreditado.Text = "0,0" + str;
            }
            else if (str.Length == 2)
            {
                txtValorASerCreditado.Text = "0," + str;
            }
            else if (str.Length > 2)
            {
                txtValorASerCreditado.Text = str.Substring(0, str.Length - 2) + "," +
                                str.Substring(str.Length - 2);
            }
        }

        private bool IsNumeric(int Val)
        {
            return ((Val >= 48 && Val <= 57) || (Val == 8) || (Val == 46));
        }

        private void btnDebitar_Click(object sender, EventArgs e)
        {
            lblAstObs.Text = Utilidades.PreencherCampos(txtObs.Text);

            if (lblAstObs.Text == "*") MessageBox.Show("Informe o motivo da retirada de crédito!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                using (CheffTogaEntities context = new CheffTogaEntities())
                {
                    var SaldoDB = (from i in context.Usuario
                                   where i.CPF == Utilidades.Cpf
                                   select i.Saldo).ToList();

                    float saldo = float.Parse(SaldoDB[0].ToString());

                    var listaid = (from i in context.Usuario
                                   where i.CPF == Utilidades.Cpf
                                   select i.Id_Card).ToList();

                    int id = listaid[0];

                    var listanome = (from i in context.Usuario
                                     where i.CPF == Utilidades.Cpf
                                     select i.Nome).ToList();

                    string nome = listanome[0];

                    if ((saldo - float.Parse(txtValorASerCreditado.Text)) < 0)
                    {
                        MessageBox.Show("NÃO AUTORIZADO! O valor a ser debitado é maior que o Saldo existente.", "Autorização!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else if (MessageBox.Show("Deseja realmente debitar R$ " + txtValorASerCreditado.Text + " ao aluno " + txtNome.Text + "?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string ValorSpace = this.txtValorASerCreditado.Text.Replace(" ", "");
                        Utilidades.debito = float.Parse(ValorSpace);

                        Utilidades.DebitarEstorno();

                        Utilidades.Movimentacoes(id, Utilidades.Cpf, nome, "Crédito Retirado", "-", txtObs.Text, Utilidades.debito); //registrador de movimentacões

                        MessageBox.Show("O novo saldo do aluno " + txtNome.Text + " é R$ " + Utilidades.saldo + "!", "Operação realizada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();

                    }
                }
            }
        }
    }
}
