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
        public fLoginMan()
        {
            InitializeComponent();
        }

        private void msMenuCadastroNovo_Click(object sender, EventArgs e)
        {
            fCadastro _fCad;
            _fCad = new fCadastro();
            _fCad.Show();
            Hide();

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

    }
}
