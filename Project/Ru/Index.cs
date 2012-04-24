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
    public partial class fIndex : Form
    {
        public fIndex()
        {
            InitializeComponent();
        }

        private void timerAp_Tick(object sender, EventArgs e)
        {
            progressBarAp.Value += 2;
            if (progressBarAp.Value <= 40)
            {
                lblAp.Text = "Inicializando...";
            }
            else
                if (progressBarAp.Value <= 70)
                {
                    lblAp.Text = "Carregando Componentes...";
                }
                else
                    if (progressBarAp.Value <= 100)
                    {
                        lblAp.Text = "Verificando Banco de Dados...";
                    }
                    else
                        lblAp.Text = "Aguarde...";

            if (progressBarAp.Value == 130)
            {
                timerAp.Dispose();
                fTelaLogin _Tela;
                _Tela = new fTelaLogin();
                _Tela.Show();
                Hide();
            }
        }

    }
}
