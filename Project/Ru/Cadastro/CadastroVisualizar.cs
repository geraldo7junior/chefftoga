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
    public partial class fCadastroVisualizar : Form
    {
        public fCadastroVisualizar()
        {

            InitializeComponent();
            lblOperador.Text += Utilidades.NomeLogin;
            fCadastroNovo fcadnovo = new fCadastroNovo();
            Utilidades.CarregaCombobox(cbxCurso, cbxPeriodo);

            txtID.Text = Utilidades.Id_Card();
            cbxStatus.Text = Utilidades.Status();
            txtNome.Text = Utilidades.Nome();
            txtIdentidade.Text = Utilidades.Identidade();
            mtxtDataNasc.Text = Utilidades.FuncDataNasc();
            mtxtCPF.Text = Utilidades.CpF();
            rbtnSim.Checked = Utilidades.Bolsista();
            cbxCurso.Text = Utilidades.Curso();
            cbxPeriodo.Text = Utilidades.Periodo();
            txtRua.Text = Utilidades.Rua();
            txtN.Text = Utilidades.Numero();
            txtBairro.Text = Utilidades.Bairro();
            txtCidade.Text = Utilidades.Cidade();
            cbxUF.Text = Utilidades.Uf();
            mtxtCEP.Text = Utilidades.Cep();
            mtxtFone.Text = Utilidades.FuncFone();
            txtEmail.Text = Utilidades.Email();
            try { pctbFoto.Image = Image.FromFile(Utilidades.Foto() + txtID.Text + ".jpg"); }
            catch { MessageBox.Show("Imagem não encontrada. Verifique o nome da imagem e seu local. Deve estar em (C:->Users->Mário->Pictures) e seu nome deve ser o número do Cartão do Cliente", "Imagem não encontrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
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
            Utilidades.ControleDeTela = "novo";
            fCadastroNovo _fCad;
            _fCad = new fCadastroNovo();
            _fCad.Show();
            Close();
        }

        private void msMenuCadastroAlterar_Click(object sender, EventArgs e)
        {
            string cpf = mtxtCPF.Text.Replace("-", ".");
            Utilidades.Cpf = cpf.Replace(".","");
            Utilidades.ControleDeTela = "alterar";
            fCadastroNovo _fCad;
            _fCad = new fCadastroNovo();
            _fCad.Show();
            Close();
        }

        private void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {
            this.Close();
            Utilidades.ControleDeTela = "visualizar";
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
