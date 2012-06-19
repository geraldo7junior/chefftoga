using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using RuBiz;
using System.Timers;

namespace Ru
{
    public partial class fFiltroRelatorio : Form
    {
        public fFiltroRelatorio()
        {
            InitializeComponent();

            lblOperador.Text += Utilidades.NomeLogin;

            cbxTipoMovimentacao.Text = "Login";

            if (Utilidades.filtro == "data")
            {
                lblData.Show();
                txtData.Show();
                lblTipoMovimentacao.Hide();
                cbxTipoMovimentacao.Hide();
                lblCpfOperador.Hide();
                txtCpfOperador.Hide();
                lblCpfAluno.Hide();
                txtCpfAluno.Hide();
                pctbRelGeral.Hide();
                lblInforme.Show();
            }

            else if (Utilidades.filtro == "movimentacao")
            {
                lblData.Hide();
                txtData.Hide();
                lblTipoMovimentacao.Show();
                cbxTipoMovimentacao.Show();
                lblCpfOperador.Hide();
                txtCpfOperador.Hide();
                lblCpfAluno.Hide();
                txtCpfAluno.Hide();
                pctbRelGeral.Hide();
                lblInforme.Show();
            }

            else if (Utilidades.filtro == "operador")
            {
                lblData.Hide();
                txtData.Hide();
                lblTipoMovimentacao.Hide();
                cbxTipoMovimentacao.Hide();
                lblCpfOperador.Show();
                txtCpfOperador.Show();
                lblCpfAluno.Hide();
                txtCpfAluno.Hide();
                pctbRelGeral.Hide();
                lblInforme.Show();
            }

            else if (Utilidades.filtro == "aluno")
            {
                lblData.Hide();
                txtData.Hide();
                lblTipoMovimentacao.Hide();
                cbxTipoMovimentacao.Hide();
                lblCpfOperador.Hide();
                txtCpfOperador.Hide();
                lblCpfAluno.Show();
                txtCpfAluno.Show();
                pctbRelGeral.Hide();
                lblInforme.Show();
            }

            else
            {
                pctbRelGeral.Show();
                lblData.Hide();
                txtData.Hide();
                lblTipoMovimentacao.Hide();
                cbxTipoMovimentacao.Hide();
                lblCpfOperador.Hide();
                txtCpfOperador.Hide();
                lblCpfAluno.Hide();
                txtCpfAluno.Hide();
                lblInforme.Hide();
            }

        }

        private void msMenuCadastroSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o formulário?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            Utilidades.TipoMov = cbxTipoMovimentacao.SelectedItem.ToString();
            Utilidades.Aluno = txtCpfAluno.Text;
            Utilidades.Operador = txtCpfOperador.Text;
            Utilidades.Data = txtData.Text;

            Utilidades.Movimentacoes(0, "-", "-", "Geração de Relatório", "-", "-",0);

            Utilidades.GerarPdf();
        }

        private void fFiltroRelatorio_Load(object sender, EventArgs e)
        {
            
        }

        private void msMenuImprimir_Click(object sender, EventArgs e)
        {
            printDialogDoc.ShowDialog();
        }

        private void intervaloDeDatasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.filtro = "data";
            lblData.Show();
            txtData.Show();

            lblTipoMovimentacao.Hide();
            cbxTipoMovimentacao.Hide();
            lblCpfOperador.Hide();
            txtCpfOperador.Hide();
            lblCpfAluno.Hide();
            txtCpfAluno.Hide();
            pctbRelGeral.Hide();
            lblInforme.Show();
        }

        private void tipoDeMovimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.filtro = "movimentacao";
            lblTipoMovimentacao.Show();
            cbxTipoMovimentacao.Show();

            lblData.Hide();
            txtData.Hide();
            lblCpfOperador.Hide();
            txtCpfOperador.Hide();
            lblCpfAluno.Hide();
            txtCpfAluno.Hide();
            pctbRelGeral.Hide();
            lblInforme.Show();
        }

        private void cpfDoOperadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.filtro = "operador";
            lblCpfOperador.Show();
            txtCpfOperador.Show();

            lblTipoMovimentacao.Hide();
            cbxTipoMovimentacao.Hide();
            lblData.Hide();
            txtData.Hide();
            lblCpfAluno.Hide();
            txtCpfAluno.Hide();
            pctbRelGeral.Hide();
            lblInforme.Show();

        }

        private void cpfDoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.filtro = "aluno";
            lblCpfAluno.Show();
            txtCpfAluno.Show();

            lblCpfOperador.Hide();
            txtCpfOperador.Hide();
            lblTipoMovimentacao.Hide();
            cbxTipoMovimentacao.Hide();
            lblData.Hide();
            txtData.Hide();
            pctbRelGeral.Hide();
            lblInforme.Show();
        }

        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilidades.filtro = "geral";
            pctbRelGeral.Show();
            lblData.Hide();
            txtData.Hide();
            lblTipoMovimentacao.Hide();
            cbxTipoMovimentacao.Hide();
            lblCpfOperador.Hide();
            txtCpfOperador.Hide();
            lblCpfAluno.Hide();
            txtCpfAluno.Hide();
            lblInforme.Hide();
        }     


    }
}
