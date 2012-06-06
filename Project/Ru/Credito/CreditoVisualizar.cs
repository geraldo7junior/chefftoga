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
    public partial class fCreditoVisualizar : Form
    {
        public fCreditoVisualizar()
        {
            InitializeComponent();
            lblOperador.Text += Utilidades.NomeLogin;
            Utilidades.CarregaCombobox(cbxCurso, cbxPeriodo);

            txtID.Text = Utilidades.Id_Card();
            cbxStatus.Text = Utilidades.Status();
            txtNome.Text = Utilidades.Nome();
            mtxtCPF.Text = Utilidades.CpF();
            rbtnSim.Checked = Utilidades.Bolsista();
            try { pctbFoto.Image = Image.FromFile(Utilidades.Foto()); }
            catch { MessageBox.Show("Imagem não encontrada. Verifique o nome da imagem e seu local. Deve estar em (C:->CheffTogaFotos) e seu nome deve ser o número do Cartão do Cliente", "Imagem não encontrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            if (Utilidades.ControleDeTela == "visualizarsaldo")
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
            txtEmail.Text = Utilidades.Email();
            txtSaldo.Text = Utilidades.Saldo();
        }

        private void msMenuCadastroSair_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (Utilidades.ControleDeTela == "visualizarsaldo") Utilidades.ControleDeTela = "creditar";
            else Utilidades.ControleDeTela = "creditarOp";
            fCreditoCreditar _fCad;
            _fCad = new fCreditoCreditar();
            //chamar todos os dados do banco de dados aqui
            _fCad.Show();
            Close();
        }

        private void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {

            this.Close();
            Utilidades.ControleDeTela = "visualizarsaldo";
            fBuscar _fAlt;
            _fAlt = new fBuscar();
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

        private void msMenuImprimir_Click(object sender, EventArgs e)
        {
            printDialogDoc.ShowDialog();
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }


    }
}
