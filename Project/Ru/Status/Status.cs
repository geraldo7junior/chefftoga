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
    public partial class fStatus : Form
    {
        public fStatus()
        {
            InitializeComponent();
            if ((Utilidades.ControleDeStatus == "bloquear") || (Utilidades.ControleDeStatus == "bloquearOp")) btnDesbloquear.Hide();
            else btnBloquear.Hide();
        }

        private void fStatus_Load(object sender, EventArgs e)
        {


        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            string verificacao = Utilidades.PreencherCampos(txtTodosStatus.Text);

            if (Utilidades.ControleDeStatus == "bloquear")
            {
                if (verificacao == "*") MessageBox.Show("Informe o motivo para o BLOQUEIO DE TODOS OS ALUNOS.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (MessageBox.Show("Deseja realmente BLOQUEAR TODOS OS ALUNOS?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Utilidades.ModStatus("Bloqueado", txtTodosStatus.Text);
                        Close();
                    }
                }
            }
            else
            {
                if (verificacao == "*") MessageBox.Show("Informe o motivo para o BLOQUEIO DE TODOS OS OPERADORES.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (MessageBox.Show("Deseja realmente BLOQUEAR TODOS OS OPERADORES, com exceção dos GERENTES?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Utilidades.ModStatusOp("Bloqueado", txtTodosStatus.Text);
                        Close();
                    }
                }
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            string verificacao = Utilidades.PreencherCampos(txtTodosStatus.Text);

            if (Utilidades.ControleDeStatus == "desbloquear")
            {

                if (verificacao == "*") MessageBox.Show("Informe o motivo para o DESBLOQUEIO DE TODOS OS ALUNOS.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (MessageBox.Show("Deseja realmente DESBLOQUEAR TODOS OS ALUNOS?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Utilidades.ModStatus("Desbloqueado", txtTodosStatus.Text);
                        Close();
                    }
                }
            }
            else
            {
                if (verificacao == "*") MessageBox.Show("Informe o motivo para o DESBLOQUEIO DE TODOS OS OPERADORES.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (MessageBox.Show("Deseja realmente DESBLOQUEAR TODOS OS OPERADORES, com exceção dos GERENTES?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Utilidades.ModStatusOp("Desbloqueado", txtTodosStatus.Text);
                        Close();
                    }
                }
            }
        }
    }
}
