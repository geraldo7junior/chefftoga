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
    public partial class fLoginMan : Form
    {
        String ControleDeTela;
        public fLoginMan()
        {
            InitializeComponent();
        }

        private void msMenuCadastroNovo_Click(object sender, EventArgs e)
        {
            fCadastro _fCad;
            _fCad = new fCadastro();
            _fCad.Show();
         
            //fIndex _fLog;
            //_fLog = new fIndex();
            //_fLog.Show();
            //Hide();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void msMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void msMenuCadastroAlterar_Click(object sender, EventArgs e)
        {
            fAlterar _fAlt;
            _fAlt = new fAlterar();
            ControleDeTela = "alterar";
            _fAlt.Show();
            
        }

        public void msMenuCadastroVisualizar_Click(object sender, EventArgs e)
        {
            fAlterar _fAlt;
            _fAlt = new fAlterar();
            ControleDeTela = "visualizar";
            _fAlt.Show();
        }

        public void msMenuCadastroExcluir_Click(object sender, EventArgs e)
        {
            fAlterar _fAlt;
            _fAlt = new fAlterar();
            ControleDeTela = "excluir";
            _fAlt.Show();
        }

    }
}
