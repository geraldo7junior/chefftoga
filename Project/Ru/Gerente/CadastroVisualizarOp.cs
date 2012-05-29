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
    public partial class fCadastroVisualizarOp : Form
    {
        public fCadastroVisualizarOp()
        {

            InitializeComponent();
            lblOperador.Text += Utilidades.NomeLogin;

            txtID.Text = Utilidades.Id_Card();
            txtNome.Text = Utilidades.Nome();
            txtIdentidade.Text = Utilidades.Identidade();
            mtxtDataNasc.Text = Utilidades.FuncDataNasc();
            mtxtCPF.Text = Utilidades.CpF();
            rbtnSim.Checked = Utilidades.Bolsista();

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
            mtxtCEP.Text = Utilidades.Cep();
            mtxtFone.Text = Utilidades.FuncFone();           
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
            Utilidades.ControleDeTela = "novoOp";
            fCadastroNovoOp _fCad;
            _fCad = new fCadastroNovoOp();
            _fCad.Show();
            Close();
        }

        private void msMenuCadastroAlterar_Click(object sender, EventArgs e)
        {
            string cpf = mtxtCPF.Text.Replace("-", ".");
            Utilidades.Cpf = cpf.Replace(".","");
            Utilidades.ControleDeTela = "alterarOp";
            fCadastroNovoOp _fCad;
            _fCad = new fCadastroNovoOp();
            _fCad.Show();
            Close();
        }

        private void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {
            this.Close();
            Utilidades.ControleDeTela = "visualizarOp";
            fBuscar _fAlt;
            _fAlt = new fBuscar();
            _fAlt.Show();

        }

        private void msMenuCadastroExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Excluir este Cadastro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utilidades.ExcluirCadastro();

                Close();
                
            }
        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void msMenuImprimir_Click(object sender, EventArgs e)
        {
            printDialogDoc.ShowDialog();
        }


    }
}
