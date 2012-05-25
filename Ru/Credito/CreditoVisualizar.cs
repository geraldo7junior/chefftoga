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

            txtID.Text = Utilidades.Id_Card();
            txtNome.Text = Utilidades.Nome();
            mtxtCPF.Text = Utilidades.CpF();
            //cbxCurso.Text = Utilidades.Curso();
            //cbxPeriodo.Text = Utilidades.Periodo();
            mtxtFone.Text = Utilidades.FuncFone();
            //rbtnSim.Checked = Utilidades.Bolsista();
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
            fAlterar _fAlt;
            _fAlt = new fAlterar();
            _fAlt.Show();

        }

        private void msMenuCadastroExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Excluir este Cadastro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                // criar função para excluir cadastro do banco de dados
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
