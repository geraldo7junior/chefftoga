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
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.printDialogDoc = new System.Windows.Forms.PrintDialog();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtCamposAlterados = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblCamposAlterados = new System.Windows.Forms.Label();
            this.cbxTipoMovimentacao = new System.Windows.Forms.ComboBox();
            this.lblTipoMovimentacao = new System.Windows.Forms.Label();
            this.lblHoraMovimentacao = new System.Windows.Forms.Label();
            this.txtHoraMovimentacao = new System.Windows.Forms.MaskedTextBox();
            this.lblDataMovimentacao = new System.Windows.Forms.Label();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.txtCpfAluno = new System.Windows.Forms.MaskedTextBox();
            this.txtCardAluno = new System.Windows.Forms.MaskedTextBox();
            this.lblCpfAluno = new System.Windows.Forms.Label();
            this.lblCardAluno = new System.Windows.Forms.Label();
            this.txtNomeOperador = new System.Windows.Forms.TextBox();
            this.lblNomeOperador = new System.Windows.Forms.Label();
            this.txtCpfOperador = new System.Windows.Forms.MaskedTextBox();
            this.txtCardOperador = new System.Windows.Forms.MaskedTextBox();
            this.txtIdMovimentacao = new System.Windows.Forms.MaskedTextBox();
            this.lblInforme = new System.Windows.Forms.Label();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.lblGeradorRelatorio = new System.Windows.Forms.Label();
            this.lblIdMovimentacao = new System.Windows.Forms.Label();
            this.lblCpfOperador = new System.Windows.Forms.Label();
            this.lblCardOperador = new System.Windows.Forms.Label();
            this.pctbRU = new System.Windows.Forms.PictureBox();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRU)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuCadastro,
            this.msMenuImprimir});
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
            this.msMenuCadastro.Text = "&Cadastro";
            // 
            // msMenuCadastroSair
            // 
            this.msMenuCadastroSair.Name = "msMenuCadastroSair";
            this.msMenuCadastroSair.Size = new System.Drawing.Size(109, 22);
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
            // txtObs
            // 
            this.txtObs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObs.Location = new System.Drawing.Point(99, 333);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(177, 96);
            this.txtObs.TabIndex = 7;
            this.txtObs.Text = "";
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(64, 435);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(173, 22);
            this.txtValor.TabIndex = 8;
            // 
            // txtCamposAlterados
            // 
            this.txtCamposAlterados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCamposAlterados.BackColor = System.Drawing.Color.White;
            this.txtCamposAlterados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCamposAlterados.Location = new System.Drawing.Point(153, 302);
            this.txtCamposAlterados.Name = "txtCamposAlterados";
            this.txtCamposAlterados.Size = new System.Drawing.Size(173, 22);
            this.txtCamposAlterados.TabIndex = 6;
            // 
            // lblValor
            // 
            this.lblValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.Black;
            this.lblValor.Location = new System.Drawing.Point(7, 435);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(175, 22);
            this.lblValor.TabIndex = 146;
            this.lblValor.Text = "Valor:";
            // 
            // lblObs
            // 
            this.lblObs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObs.BackColor = System.Drawing.Color.Transparent;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.Color.Black;
            this.lblObs.Location = new System.Drawing.Point(4, 334);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(175, 22);
            this.lblObs.TabIndex = 145;
            this.lblObs.Text = "Observação:";
            // 
            // lblCamposAlterados
            // 
            this.lblCamposAlterados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCamposAlterados.BackColor = System.Drawing.Color.Transparent;
            this.lblCamposAlterados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamposAlterados.ForeColor = System.Drawing.Color.Black;
            this.lblCamposAlterados.Location = new System.Drawing.Point(4, 302);
            this.lblCamposAlterados.Name = "lblCamposAlterados";
            this.lblCamposAlterados.Size = new System.Drawing.Size(175, 22);
            this.lblCamposAlterados.TabIndex = 144;
            this.lblCamposAlterados.Text = "Campos Alterados:";
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
            this.cbxTipoMovimentacao.Location = new System.Drawing.Point(175, 266);
            this.cbxTipoMovimentacao.Name = "cbxTipoMovimentacao";
            this.cbxTipoMovimentacao.Size = new System.Drawing.Size(298, 24);
            this.cbxTipoMovimentacao.TabIndex = 5;
            // 
            // lblTipoMovimentacao
            // 
            this.lblTipoMovimentacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoMovimentacao.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMovimentacao.ForeColor = System.Drawing.Color.Black;
            this.lblTipoMovimentacao.Location = new System.Drawing.Point(4, 269);
            this.lblTipoMovimentacao.Name = "lblTipoMovimentacao";
            this.lblTipoMovimentacao.Size = new System.Drawing.Size(175, 22);
            this.lblTipoMovimentacao.TabIndex = 142;
            this.lblTipoMovimentacao.Text = "Tipo da Movimentação:";
            // 
            // lblHoraMovimentacao
            // 
            this.lblHoraMovimentacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHoraMovimentacao.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraMovimentacao.ForeColor = System.Drawing.Color.Black;
            this.lblHoraMovimentacao.Location = new System.Drawing.Point(4, 234);
            this.lblHoraMovimentacao.Name = "lblHoraMovimentacao";
            this.lblHoraMovimentacao.Size = new System.Drawing.Size(175, 22);
            this.lblHoraMovimentacao.TabIndex = 141;
            this.lblHoraMovimentacao.Text = "Hora da Movimentação:";
            // 
            // txtHoraMovimentacao
            // 
            this.txtHoraMovimentacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoraMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraMovimentacao.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtHoraMovimentacao.Location = new System.Drawing.Point(180, 230);
            this.txtHoraMovimentacao.Mask = "00:00";
            this.txtHoraMovimentacao.Name = "txtHoraMovimentacao";
            this.txtHoraMovimentacao.RejectInputOnFirstFailure = true;
            this.txtHoraMovimentacao.Size = new System.Drawing.Size(80, 22);
            this.txtHoraMovimentacao.TabIndex = 4;
            this.txtHoraMovimentacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDataMovimentacao
            // 
            this.lblDataMovimentacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataMovimentacao.BackColor = System.Drawing.Color.Transparent;
            this.lblDataMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataMovimentacao.ForeColor = System.Drawing.Color.Black;
            this.lblDataMovimentacao.Location = new System.Drawing.Point(4, 203);
            this.lblDataMovimentacao.Name = "lblDataMovimentacao";
            this.lblDataMovimentacao.Size = new System.Drawing.Size(175, 22);
            this.lblDataMovimentacao.TabIndex = 139;
            this.lblDataMovimentacao.Text = "Data da Movimentação:";
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox6.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.maskedTextBox6.Location = new System.Drawing.Point(180, 199);
            this.maskedTextBox6.Mask = "00/00/0000";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.RejectInputOnFirstFailure = true;
            this.maskedTextBox6.Size = new System.Drawing.Size(80, 22);
            this.maskedTextBox6.TabIndex = 3;
            this.maskedTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeAluno.BackColor = System.Drawing.Color.White;
            this.txtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(611, 395);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(173, 22);
            this.txtNomeAluno.TabIndex = 14;
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeAluno.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.ForeColor = System.Drawing.Color.Black;
            this.lblNomeAluno.Location = new System.Drawing.Point(498, 395);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(117, 22);
            this.lblNomeAluno.TabIndex = 136;
            this.lblNomeAluno.Text = "Nome_Aluno:";
            // 
            // txtCpfAluno
            // 
            this.txtCpfAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCpfAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfAluno.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtCpfAluno.Location = new System.Drawing.Point(593, 361);
            this.txtCpfAluno.Mask = "00000000000";
            this.txtCpfAluno.Name = "txtCpfAluno";
            this.txtCpfAluno.RejectInputOnFirstFailure = true;
            this.txtCpfAluno.Size = new System.Drawing.Size(91, 22);
            this.txtCpfAluno.TabIndex = 13;
            this.txtCpfAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCardAluno
            // 
            this.txtCardAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCardAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardAluno.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtCardAluno.Location = new System.Drawing.Point(593, 322);
            this.txtCardAluno.Mask = "000000000000000";
            this.txtCardAluno.Name = "txtCardAluno";
            this.txtCardAluno.RejectInputOnFirstFailure = true;
            this.txtCardAluno.Size = new System.Drawing.Size(119, 22);
            this.txtCardAluno.TabIndex = 12;
            this.txtCardAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCpfAluno
            // 
            this.lblCpfAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCpfAluno.BackColor = System.Drawing.Color.Transparent;
            this.lblCpfAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfAluno.ForeColor = System.Drawing.Color.Black;
            this.lblCpfAluno.Location = new System.Drawing.Point(498, 364);
            this.lblCpfAluno.Name = "lblCpfAluno";
            this.lblCpfAluno.Size = new System.Drawing.Size(94, 22);
            this.lblCpfAluno.TabIndex = 133;
            this.lblCpfAluno.Text = "Cpf_Aluno:";
            // 
            // lblCardAluno
            // 
            this.lblCardAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCardAluno.BackColor = System.Drawing.Color.Transparent;
            this.lblCardAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardAluno.ForeColor = System.Drawing.Color.Black;
            this.lblCardAluno.Location = new System.Drawing.Point(498, 325);
            this.lblCardAluno.Name = "lblCardAluno";
            this.lblCardAluno.Size = new System.Drawing.Size(94, 22);
            this.lblCardAluno.TabIndex = 132;
            this.lblCardAluno.Text = "Card_Aluno:";
            // 
            // txtNomeOperador
            // 
            this.txtNomeOperador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeOperador.BackColor = System.Drawing.Color.White;
            this.txtNomeOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeOperador.Location = new System.Drawing.Point(622, 259);
            this.txtNomeOperador.Name = "txtNomeOperador";
            this.txtNomeOperador.Size = new System.Drawing.Size(173, 22);
            this.txtNomeOperador.TabIndex = 11;
            // 
            // lblNomeOperador
            // 
            this.lblNomeOperador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeOperador.ForeColor = System.Drawing.Color.Black;
            this.lblNomeOperador.Location = new System.Drawing.Point(498, 259);
            this.lblNomeOperador.Name = "lblNomeOperador";
            this.lblNomeOperador.Size = new System.Drawing.Size(132, 22);
            this.lblNomeOperador.TabIndex = 130;
            this.lblNomeOperador.Text = "Nome_Operador:";
            // 
            // txtCpfOperador
            // 
            this.txtCpfOperador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCpfOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfOperador.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtCpfOperador.Location = new System.Drawing.Point(611, 217);
            this.txtCpfOperador.Mask = "00000000000";
            this.txtCpfOperador.Name = "txtCpfOperador";
            this.txtCpfOperador.RejectInputOnFirstFailure = true;
            this.txtCpfOperador.Size = new System.Drawing.Size(92, 22);
            this.txtCpfOperador.TabIndex = 10;
            this.txtCpfOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCardOperador
            // 
            this.txtCardOperador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCardOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardOperador.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtCardOperador.Location = new System.Drawing.Point(622, 170);
            this.txtCardOperador.Mask = "000000000000000";
            this.txtCardOperador.Name = "txtCardOperador";
            this.txtCardOperador.RejectInputOnFirstFailure = true;
            this.txtCardOperador.Size = new System.Drawing.Size(115, 22);
            this.txtCardOperador.TabIndex = 9;
            this.txtCardOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdMovimentacao
            // 
            this.txtIdMovimentacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMovimentacao.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtIdMovimentacao.Location = new System.Drawing.Point(141, 172);
            this.txtIdMovimentacao.Mask = "0000000000";
            this.txtIdMovimentacao.Name = "txtIdMovimentacao";
            this.txtIdMovimentacao.RejectInputOnFirstFailure = true;
            this.txtIdMovimentacao.Size = new System.Drawing.Size(80, 22);
            this.txtIdMovimentacao.TabIndex = 2;
            this.txtIdMovimentacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // btnRelatorio
            // 
            this.btnRelatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRelatorio.Location = new System.Drawing.Point(323, 514);
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
            // lblIdMovimentacao
            // 
            this.lblIdMovimentacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdMovimentacao.BackColor = System.Drawing.Color.Transparent;
            this.lblIdMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMovimentacao.ForeColor = System.Drawing.Color.Black;
            this.lblIdMovimentacao.Location = new System.Drawing.Point(4, 172);
            this.lblIdMovimentacao.Name = "lblIdMovimentacao";
            this.lblIdMovimentacao.Size = new System.Drawing.Size(175, 22);
            this.lblIdMovimentacao.TabIndex = 117;
            this.lblIdMovimentacao.Text = "Id_Movimentação:";
            // 
            // lblCpfOperador
            // 
            this.lblCpfOperador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCpfOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblCpfOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfOperador.ForeColor = System.Drawing.Color.Black;
            this.lblCpfOperador.Location = new System.Drawing.Point(498, 220);
            this.lblCpfOperador.Name = "lblCpfOperador";
            this.lblCpfOperador.Size = new System.Drawing.Size(117, 22);
            this.lblCpfOperador.TabIndex = 120;
            this.lblCpfOperador.Text = "Cpf_Operador:";
            // 
            // lblCardOperador
            // 
            this.lblCardOperador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCardOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblCardOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardOperador.ForeColor = System.Drawing.Color.Black;
            this.lblCardOperador.Location = new System.Drawing.Point(498, 173);
            this.lblCardOperador.Name = "lblCardOperador";
            this.lblCardOperador.Size = new System.Drawing.Size(132, 22);
            this.lblCardOperador.TabIndex = 119;
            this.lblCardOperador.Text = "Card_Operador:";
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
            // fFiltroRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pctbRU);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCamposAlterados);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.lblCamposAlterados);
            this.Controls.Add(this.cbxTipoMovimentacao);
            this.Controls.Add(this.lblTipoMovimentacao);
            this.Controls.Add(this.lblHoraMovimentacao);
            this.Controls.Add(this.txtHoraMovimentacao);
            this.Controls.Add(this.lblDataMovimentacao);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.lblNomeAluno);
            this.Controls.Add(this.txtCpfAluno);
            this.Controls.Add(this.txtCardAluno);
            this.Controls.Add(this.lblCpfAluno);
            this.Controls.Add(this.lblCardAluno);
            this.Controls.Add(this.txtNomeOperador);
            this.Controls.Add(this.lblNomeOperador);
            this.Controls.Add(this.txtCpfOperador);
            this.Controls.Add(this.txtCardOperador);
            this.Controls.Add(this.txtIdMovimentacao);
            this.Controls.Add(this.lblInforme);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.lblGeradorRelatorio);
            this.Controls.Add(this.lblIdMovimentacao);
            this.Controls.Add(this.lblCpfOperador);
            this.Controls.Add(this.lblCardOperador);
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
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtCamposAlterados;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblCamposAlterados;
        private System.Windows.Forms.ComboBox cbxTipoMovimentacao;
        private System.Windows.Forms.Label lblTipoMovimentacao;
        private System.Windows.Forms.Label lblHoraMovimentacao;
        private System.Windows.Forms.MaskedTextBox txtHoraMovimentacao;
        private System.Windows.Forms.Label lblDataMovimentacao;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.MaskedTextBox txtCpfAluno;
        private System.Windows.Forms.MaskedTextBox txtCardAluno;
        private System.Windows.Forms.Label lblCpfAluno;
        private System.Windows.Forms.Label lblCardAluno;
        private System.Windows.Forms.TextBox txtNomeOperador;
        private System.Windows.Forms.Label lblNomeOperador;
        private System.Windows.Forms.MaskedTextBox txtCpfOperador;
        private System.Windows.Forms.MaskedTextBox txtCardOperador;
        private System.Windows.Forms.MaskedTextBox txtIdMovimentacao;
        private System.Windows.Forms.Label lblInforme;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Label lblGeradorRelatorio;
        private System.Windows.Forms.Label lblIdMovimentacao;
        private System.Windows.Forms.Label lblCpfOperador;
        private System.Windows.Forms.Label lblCardOperador;
        private System.Windows.Forms.PictureBox pctbRU;
    }
}