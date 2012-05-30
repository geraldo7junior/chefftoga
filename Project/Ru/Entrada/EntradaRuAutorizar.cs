using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using RuBiz;

namespace Ru
{
    public partial class fEntradaRuAutorizar : Form
    {
        public fEntradaRuAutorizar()
        {
            InitializeComponent();
            lblOperador.Text += Utilidades.NomeLogin;
            Utilidades.CarregaCombobox(cbxCurso, cbxPeriodo);

            txtID.Text = Utilidades.Id_Card();
            txtNome.Text = Utilidades.Nome();
            mtxtCPF.Text = Utilidades.CpF();
            rbtnSim.Checked = Utilidades.Bolsista();
            if (Utilidades.ControleDeTela == "autorizarporcpf")
            {
                cbxCurso.Text = Utilidades.Curso();
                cbxPeriodo.Text = Utilidades.Periodo();
                gpbTipoOperador.Hide();
            }

            else
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
            
            mtxtFone.Text = Utilidades.FuncFone();
            txtSaldo.Text = Utilidades.Saldo();
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
            if ((DateTime.Now.Hour >= 11) && (DateTime.Now.Hour <= 15))
            {
                Utilidades.ControleRefeicao = "almoco";
            }

            else Utilidades.ControleRefeicao = "jantar";

            if (Utilidades.VerRefeicao() == true)
            {
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
            fCreditoCreditar _fCad;
            _fCad = new fCreditoCreditar();
            //chamar todos os dados do banco de dados aqui
            _fCad.Show();
            Close();
        }

        private void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {

            this.Close();
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            Utilidades.ControleDeTela = "visualizarsaldo";
            _fAlt.Show();

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

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            string hora = DateTime.Now.ToShortTimeString();
            string hora1 = hora[0].ToString() + hora[1].ToString();
            int h = int.Parse(hora1);
            string data = DateTime.Now.ToShortDateString();

            if ((h>=17) && (h<=19))
            {
                Utilidades.ValorASerCobrado = float.Parse("2,6");
                if (Utilidades.Debitar() == true)
                {
                    using (CheffTogaEntities context = new CheffTogaEntities())
                    {
                        string strSQL = "UPDATE Usuario SET Jantar = '" + true + "' , Data_Refeicao= '" + data + "' WHERE CPF= '" + Utilidades.Cpf + "'";

                        context.ExecuteStoreCommand(strSQL);

                        Utilidades.Bandeja_Espera();

                        MessageBox.Show("Autorizado!", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }

                else MessageBox.Show("Não Autorizado! Crédito Insuficiente!", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Close();
            }
            else if ((h >= 11) && (h <= 14))
            {
                Utilidades.ValorASerCobrado = float.Parse("3");
                if (Utilidades.Debitar() == true)
                {
                    using (CheffTogaEntities context = new CheffTogaEntities())
                    {
                        string strSQL = "UPDATE Usuario SET Almoco = '" + true + "' , Data_Refeicao= '" + data + "' WHERE CPF= '" + Utilidades.Cpf + "'";

                        context.ExecuteStoreCommand(strSQL);

                        Utilidades.Bandeja_Espera();

                        MessageBox.Show("Autorizado!", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }

                else MessageBox.Show("Não Autorizado! Crédito Insuficiente!", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                Close();
            }

            else
            {
                MessageBox.Show("Não Autorizado! Fora do horário de refeição!", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
            
                       
             // tornar o campo "em_espera" do DB com valor "TRUE" ==>> autorização da bandeja (depois de passar na bandeja o valor volta pra "FALSE")

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fEntradaRuAutorizar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAutorizar_Click(sender, e);
            }
        }


    }
}
