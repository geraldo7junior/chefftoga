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
            txtID.Text = "Ver função p/ ID";
            lblOperador.Text += Utilidades.NomeLogin;

            txtNome.Text = Utilidades.Nome();
            txtIdenditade.Text = Utilidades.Identidade();
            //mtxtDataNasc.Text = Utilidades.DataNasc();
            mtxtCPF.Text = Utilidades.CpF();
            //cbxCurso.Text = Utilidades.Curso();
            //cbxPeriodo.Text = Utilidades.Periodo();
            txtRua.Text = Utilidades.Rua();
            txtN.Text = Utilidades.Numero();
            txtBairro.Text = Utilidades.Bairro();
            txtCidade.Text = Utilidades.Cidade();
            cbxUF.Text = Utilidades.Uf();
            mtxtCEP.Text = Utilidades.Cep();
            mtxtFone.Text = Utilidades.Fone();
            //rbtnSim.Checked = Utilidades.Bolsista();
           
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
            Utilidades.ControleDeTela = "novo";
            fCadastroNovo _fCad;
            _fCad = new fCadastroNovo();
            _fCad.Show();
            Close();
        }

        private void msMenuCadastroAlterar_Click(object sender, EventArgs e)
        {
            Utilidades.Cpf = mtxtCPF.Text;
            Utilidades.ControleDeTela = "alterar";
            fCadastroNovo _fCad;
            _fCad = new fCadastroNovo();
            //chamar todos os dados do banco de dados aqui
            _fCad.Show();
            Close();
        }

        private void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {
            this.Close();
            fAlterar _fAlt;
            _fAlt = new fAlterar();
            Utilidades.ControleDeTela = "visualizar";
            _fAlt.Show();

        }

        private void msMenuCadastroExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Excluir este Cadastro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utilidades.ExcluirCadastro();

                MessageBox.Show("Cadastro excluído com sucesso!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
