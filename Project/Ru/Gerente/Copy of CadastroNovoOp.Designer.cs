namespace Ru
{
    partial class fFiltroRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFiltroRelatorio));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msMenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroSair = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervaloDeDatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeMovimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cpfDoOperadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cpfDoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.printDialogDoc = new System.Windows.Forms.PrintDialog();
            this.cbxTipoMovimentacao = new System.Windows.Forms.ComboBox();
            this.lblTipoMovimentacao = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfAluno = new System.Windows.Forms.MaskedTextBox();
            this.lblCpfAluno = new System.Windows.Forms.Label();
            this.txtCpfOperador = new System.Windows.Forms.MaskedTextBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.lblGeradorRelatorio = new System.Windows.Forms.Label();
            this.lblCpfOperador = new System.Windows.Forms.Label();
            this.pctbRU = new System.Windows.Forms.PictureBox();
            this.lblInforme = new System.Windows.Forms.Label();
            this.geralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pctbRelGeral = new System.Windows.Forms.PictureBox();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRelGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuCadastro,
            this.msMenuImprimir,
            this.filtroToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msMenu.Size = new System.Drawing.Size(800, 24);
            this.msMenu.TabIndex = 16;
            this.msMenu.Text = "Menu";
            // 
            // msMenuCadastro
            // 
            this.msMenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuCadastroSair});
            this.msMenuCadastro.Name = "msMenuCadastro";
            this.msMenuCadastro.Size = new System.Drawing.Size(66, 20);
            this.msMenuCadastro.Text = "&Relatório";
            // 
            // msMenuCadastroSair
            // 
            this.msMenuCadastroSair.Name = "msMenuCadastroSair";
            this.msMenuCadastroSair.Size = new System.Drawing.Size(152, 22);
            this.msMenuCadastroSair.Text = "&Fechar";
            this.msMenuCadastroSair.Click += new System.EventHandler(this.msMenuCadastroSair_Click);
            // 
            // msMenuImprimir
            // 
            this.msMenuImprimir.Name = "msMenuImprimir";
            this.msMenuImprimir.Size = new System.Drawing.Size(65, 20);
            this.msMenuImprimir.Text = "&Imprimir";
            this.msMenuImprimir.Click += new System.EventHandler(this.msMenuImprimir_Click);
            // 
            // filtroToolStripMenuItem
            // 
            this.filtroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intervaloDeDatasToolStripMenuItem,
            this.cpfDoOperadorToolStripMenuItem,
            this.cpfDoAlunoToolStripMenuItem,
            this.tipoDeMovimentaçãoToolStripMenuItem,
            this.geralToolStripMenuItem});
            this.filtroToolStripMenuItem.Name = "filtroToolStripMenuItem";
            this.filtroToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.filtroToolStripMenuItem.Text = "&Filtros";
            // 
            // intervaloDeDatasToolStripMenuItem
            // 
            this.intervaloDeDatasToolStripMenuItem.Name = "intervaloDeDatasToolStripMenuItem";
            this.intervaloDeDatasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.intervaloDeDatasToolStripMenuItem.Text = "&Data";
            this.intervaloDeDatasToolStripMenuItem.Click += new System.EventHandler(this.intervaloDeDatasToolStripMenuItem_Click);
            // 
            // tipoDeMovimentaçãoToolStripMenuItem
            // 
            this.tipoDeMovimentaçãoToolStripMenuItem.Name = "tipoDeMovimentaçãoToolStripMenuItem";
            this.tipoDeMovimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.tipoDeMovimentaçãoToolStripMenuItem.Text = "&Tipo de Movimentação";
            this.tipoDeMovimentaçãoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeMovimentaçãoToolStripMenuItem_Click);
            // 
            // cpfDoOperadorToolStripMenuItem
            // 
            this.cpfDoOperadorToolStripMenuItem.Name = "cpfDoOperadorToolStripMenuItem";
            this.cpfDoOperadorToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cpfDoOperadorToolStripMenuItem.Text = "CPF do &Operador";
            this.cpfDoOperadorToolStripMenuItem.Click += new System.EventHandler(this.cpfDoOperadorToolStripMenuItem_Click);
            // 
            // cpfDoAlunoToolStripMenuItem
            // 
            this.cpfDoAlunoToolStripMenuItem.Name = "cpfDoAlunoToolStripMenuItem";
            this.cpfDoAlunoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cpfDoAlunoToolStripMenuItem.Text = "CPF do &Aluno";
            this.cpfDoAlunoToolStripMenuItem.Click += new System.EventHandler(this.cpfDoAlunoToolStripMenuItem_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(587, 579);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(201, 12);
            this.lblCopyright.TabIndex = 64;
            this.lblCopyright.Text = "Copyright © BSI UFRPE 2011.2";
            // 
            // lblOperador
            // 
            this.lblOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperador.AutoSize = true;
            this.lblOperador.BackColor = System.Drawing.Color.White;
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.ForeColor = System.Drawing.Color.Red;
            this.lblOperador.Location = new System.Drawing.Point(536, 6);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(57, 13);
            this.lblOperador.TabIndex = 83;
            this.lblOperador.Text = "Operador: ";
            // 
            // printDialogDoc
            // 
            this.printDialogDoc.UseEXDialog = true;
            // 
            // cbxTipoMovimentacao
            // 
            this.cbxTipoMovimentacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTipoMovimentacao.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxTipoMovimentacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoMovimentacao.FormattingEnabled = true;
            this.cbxTipoMovimentacao.Items.AddRange(new object[] {
            "Login",
            "Logoff",
            "Novo Cadastro de Aluno",
            "Novo Cadastro de Operador",
            "Alterar Cadastro de Aluno",
            "Alterar Cadastro de Operador",
            "Exclusão de Cadastro de Aluno",
            "Exclusão de Cadastro de Operador",
            "Crédito Retirado",
            "Crédito Inserido",
            "Entrada de Aluno com Desconto",
            "Entrada de ALUNO BOLSISTA",
            "Entrada de OPERADOR BOLSISTA",
            "Status de todos os Alunos Desbloqueados",
            "Status de todos os Alunos Bloqueados",
            "Status de todos os Operadores Desbloqueados",
            "Status de todos os Operadores Bloqueados",
            "Geração de Relatório"});
            this.cbxTipoMovimentacao.Location = new System.Drawing.Point(279, 227);
            this.cbxTipoMovimentacao.Name = "cbxTipoMovimentacao";
            this.cbxTipoMovimentacao.Size = new System.Drawing.Size(298, 24);
            this.cbxTipoMovimentacao.TabIndex = 5;
            this.cbxTipoMovimentacao.Visible = false;
            // 
            // lblTipoMovimentacao
            // 
            this.lblTipoMovimentacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoMovimentacao.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMovimentacao.ForeColor = System.Drawing.Color.Black;
            this.lblTipoMovimentacao.Location = new System.Drawing.Point(108, 230);
            this.lblTipoMovimentacao.Name = "lblTipoMovimentacao";
            this.lblTipoMovimentacao.Size = new System.Drawing.Size(175, 22);
            this.lblTipoMovimentacao.TabIndex = 142;
            this.lblTipoMovimentacao.Text = "Tipo da Movimentação:";
            this.lblTipoMovimentacao.Visible = false;
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(290, 188);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(50, 22);
            this.lblData.TabIndex = 139;
            this.lblData.Text = "Data";
            this.lblData.Visible = false;
            // 
            // txtData
            // 
            this.txtData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtData.Location = new System.Drawing.Point(335, 188);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.RejectInputOnFirstFailure = true;
            this.txtData.Size = new System.Drawing.Size(80, 22);
            this.txtData.TabIndex = 3;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtData.Visible = false;
            // 
            // txtCpfAluno
            // 
            this.txtCpfAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCpfAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfAluno.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtCpfAluno.Location = new System.Drawing.Point(306, 285);
            this.txtCpfAluno.Mask = "00000000000";
            this.txtCpfAluno.Name = "txtCpfAluno";
            this.txtCpfAluno.RejectInputOnFirstFailure = true;
            this.txtCpfAluno.Size = new System.Drawing.Size(91, 22);
            this.txtCpfAluno.TabIndex = 13;
            this.txtCpfAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCpfAluno.Visible = false;
            // 
            // lblCpfAluno
            // 
            this.lblCpfAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCpfAluno.BackColor = System.Drawing.Color.Transparent;
            this.lblCpfAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfAluno.ForeColor = System.Drawing.Color.Black;
            this.lblCpfAluno.Location = new System.Drawing.Point(211, 288);
            this.lblCpfAluno.Name = "lblCpfAluno";
            this.lblCpfAluno.Size = new System.Drawing.Size(94, 22);
            this.lblCpfAluno.TabIndex = 133;
            this.lblCpfAluno.Text = "Cpf_Aluno:";
            this.lblCpfAluno.Visible = false;
            // 
            // txtCpfOperador
            // 
            this.txtCpfOperador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCpfOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfOperador.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtCpfOperador.Location = new System.Drawing.Point(323, 257);
            this.txtCpfOperador.Mask = "00000000000";
            this.txtCpfOperador.Name = "txtCpfOperador";
            this.txtCpfOperador.RejectInputOnFirstFailure = true;
            this.txtCpfOperador.Size = new System.Drawing.Size(92, 22);
            this.txtCpfOperador.TabIndex = 10;
            this.txtCpfOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCpfOperador.Visible = false;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRelatorio.Location = new System.Drawing.Point(265, 506);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(150, 23);
            this.btnRelatorio.TabIndex = 15;
            this.btnRelatorio.Text = "&Gerar Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // lblGeradorRelatorio
            // 
            this.lblGeradorRelatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGeradorRelatorio.AutoSize = true;
            this.lblGeradorRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.lblGeradorRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeradorRelatorio.Location = new System.Drawing.Point(229, 24);
            this.lblGeradorRelatorio.Name = "lblGeradorRelatorio";
            this.lblGeradorRelatorio.Size = new System.Drawing.Size(205, 24);
            this.lblGeradorRelatorio.TabIndex = 0;
            this.lblGeradorRelatorio.Text = "Gerador de Relatório";
            // 
            // lblCpfOperador
            // 
            this.lblCpfOperador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCpfOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblCpfOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfOperador.ForeColor = System.Drawing.Color.Black;
            this.lblCpfOperador.Location = new System.Drawing.Point(210, 260);
            this.lblCpfOperador.Name = "lblCpfOperador";
            this.lblCpfOperador.Size = new System.Drawing.Size(117, 22);
            this.lblCpfOperador.TabIndex = 120;
            this.lblCpfOperador.Text = "Cpf_Operador:";
            this.lblCpfOperador.Visible = false;
            // 
            // pctbRU
            // 
            this.pctbRU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbRU.BackColor = System.Drawing.Color.Transparent;
            this.pctbRU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctbRU.BackgroundImage")));
            this.pctbRU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctbRU.Location = new System.Drawing.Point(661, 27);
            this.pctbRU.Name = "pctbRU";
            this.pctbRU.Size = new System.Drawing.Size(127, 129);
            this.pctbRU.TabIndex = 147;
            this.pctbRU.TabStop = false;
            // 
            // lblInforme
            // 
            this.lblInforme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInforme.AutoSize = true;
            this.lblInforme.BackColor = System.Drawing.Color.Transparent;
            this.lblInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInforme.Location = new System.Drawing.Point(45, 70);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(600, 16);
            this.lblInforme.TabIndex = 1;
            this.lblInforme.Text = "Informe os valores dos campos abaixo que deseja filtrar para poder gerar um Relat" +
    "ório do Sistema:";
            // 
            // geralToolStripMenuItem
            // 
            this.geralToolStripMenuItem.Name = "geralToolStripMenuItem";
            this.geralToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.geralToolStripMenuItem.Text = "&Geral";
            this.geralToolStripMenuItem.Click += new System.EventHandler(this.geralToolStripMenuItem_Click);
            // 
            // pctbRelGeral
            // 
            this.pctbRelGeral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbRelGeral.BackColor = System.Drawing.Color.Transparent;
            this.pctbRelGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctbRelGeral.BackgroundImage")));
            this.pctbRelGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctbRelGeral.Location = new System.Drawing.Point(190, 89);
            this.pctbRelGeral.Name = "pctbRelGeral";
            this.pctbRelGeral.Size = new System.Drawing.Size(235, 236);
            this.pctbRelGeral.TabIndex = 148;
            this.pctbRelGeral.TabStop = false;
            // 
            // fFiltroRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pctbRelGeral);
            this.Controls.Add(this.txtCpfAluno);
            this.Controls.Add(this.txtCpfOperador);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.cbxTipoMovimentacao);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.pctbRU);
            this.Controls.Add(this.lblTipoMovimentacao);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCpfAluno);
            this.Controls.Add(this.lblInforme);
            this.Controls.Add(this.lblGeradorRelatorio);
            this.Controls.Add(this.lblCpfOperador);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.msMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fFiltroRelatorio";
            this.Text = "Operador de Cadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fFiltroRelatorio_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRelGeral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem msMenuImprimir;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroSair;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.PrintDialog printDialogDoc;
        private System.Windows.Forms.ComboBox cbxTipoMovimentacao;
        private System.Windows.Forms.Label lblTipoMovimentacao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.MaskedTextBox txtCpfAluno;
        private System.Windows.Forms.Label lblCpfAluno;
        private System.Windows.Forms.MaskedTextBox txtCpfOperador;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Label lblGeradorRelatorio;
        private System.Windows.Forms.Label lblCpfOperador;
        private System.Windows.Forms.PictureBox pctbRU;
        private System.Windows.Forms.Label lblInforme;
        private System.Windows.Forms.ToolStripMenuItem filtroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervaloDeDatasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeMovimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cpfDoOperadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cpfDoAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem;
        private System.Windows.Forms.PictureBox pctbRelGeral;
    }
}