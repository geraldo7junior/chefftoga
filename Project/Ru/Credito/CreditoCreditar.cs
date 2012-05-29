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

            txtID.Text = Utilidades.Id_Card();
            txtNome.Text = Utilidades.Nome();
            mtxtCPF.Text = Utilidades.CpF();
            rbtnSim.Checked = Utilidades.Bolsista();
            cbxCurso.Text = Utilidades.Curso();
            cbxPeriodo.Text = Utilidades.Periodo();
            mtxtFone.Text = Utilidades.FuncFone();
            txtSaldo.Text = Utilidades.Saldo();            
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

                if ((saldo + float.Parse(txtValorASerCreditado.Text)) > 999)
                {
                    MessageBox.Show("NÃO AUTORIZADO! O saldo não pode exceder R$ 999,00", "Autorização!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (MessageBox.Show("Deseja realmente creditar R$ " + txtValorASerCreditado.Text + " ao aluno " + txtNome.Text + "?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string ValorSpace = this.txtValorASerCreditado.Text.Replace(" ", "");
                    Utilidades.credito = float.Parse(ValorSpace);

                    Utilidades.Creditar();

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
    }
}
