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
    public partial class fAlterar : Form
    {
        public fAlterar()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

//Operador de Cadastro          
            if (Utilidades.ControleDeTela=="alterar")
            {
                fCadastroNovo _fCad;
                _fCad = new fCadastroNovo();
                //chamar todos os dados do banco de dados aqui
                _fCad.Show();
                Close();
            }

            else if (Utilidades.ControleDeTela == "visualizar")
            {
                fCadastroVisualizar _fVCad;
                _fVCad = new fCadastroVisualizar();
                //chamar todos os dados do banco de dados aqui
                _fVCad.Show();
                Close();
            }

            else if (Utilidades.ControleDeTela == "excluir")
            {
                fCadastroVisualizar _fVCad;
                _fVCad = new fCadastroVisualizar();
                //chamar todos os dados do banco de dados aqui
                _fVCad.Show();
                Close();
                if (MessageBox.Show("Deseja Realmente Excluir este Cadastro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // criar função aqui para excluir cadastro do banco de dados
                    _fVCad.Close();
                    
                    
                }
            }

//Operador de Credito
            else if (Utilidades.ControleDeTela == "visualizarsaldo")
            {
                fCreditoVisualizar _fVCad;
                _fVCad = new fCreditoVisualizar();
                //chamar todos os dados de crédito do banco de dados aqui
                _fVCad.Show();
                Close();
            }

            else if (Utilidades.ControleDeTela == "creditar")
            {
                fCreditoCreditar _fVCad;
                _fVCad = new fCreditoCreditar();
                //chamar todos os dados de crédito do banco de dados aqui
                _fVCad.Show();
                Close();
            }

            
            
        }

        private void fAlterar_Load(object sender, EventArgs e)
        {

        }
    }
}
