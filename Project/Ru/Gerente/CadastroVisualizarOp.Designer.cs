namespace Ru
{
    partial class fCadastroVisualizarOp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCadastroVisualizarOp));
            this.mtxtFone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblFormCadastro = new System.Windows.Forms.Label();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairrro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFone = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblIdentidade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msMenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroVisualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroSair = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.mtxtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.pctbFoto = new System.Windows.Forms.PictureBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.gpbBolsista = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.lblOperador = new System.Windows.Forms.Label();
            this.printDialogDoc = new System.Windows.Forms.PrintDialog();
            this.txtIdentidade = new System.Windows.Forms.MaskedTextBox();
            this.gpbTipoOperador = new System.Windows.Forms.GroupBox();
            this.rbtnGerente = new System.Windows.Forms.RadioButton();
            this.rbtnOpEntradaRU = new System.Windows.Forms.RadioButton();
            this.rbtnOpCredito = new System.Windows.Forms.RadioButton();
            this.rbtnOpCadastro = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.pctbRU = new System.Windows.Forms.PictureBox();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbFoto)).BeginInit();
            this.gpbBolsista.SuspendLayout();
            this.gpbTipoOperador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRU)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtFone
            // 
            this.mtxtFone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtFone.Location = new System.Drawing.Point(183, 393);
            this.mtxtFone.Mask = "(00)0000-0000";
            this.mtxtFone.Name = "mtxtFone";
            this.mtxtFone.ReadOnly = true;
            this.mtxtFone.Size = new System.Drawing.Size(100, 22);
            this.mtxtFone.TabIndex = 14;
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCEP.Location = new System.Drawing.Point(263, 354);
            this.mtxtCEP.Mask = "00,000-000";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.ReadOnly = true;
            this.mtxtCEP.Size = new System.Drawing.Size(100, 22);
            this.mtxtCEP.TabIndex = 13;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCPF.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtxtCPF.Location = new System.Drawing.Point(218, 253);
            this.mtxtCPF.Mask = "000,000,000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.ReadOnly = true;
            this.mtxtCPF.RejectInputOnFirstFailure = true;
            this.mtxtCPF.Size = new System.Drawing.Size(100, 22);
            this.mtxtCPF.TabIndex = 5;
            // 
            // lblFormCadastro
            // 
            this.lblFormCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFormCadastro.AutoSize = true;
            this.lblFormCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblFormCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormCadastro.Location = new System.Drawing.Point(198, 24);
            this.lblFormCadastro.Name = "lblFormCadastro";
            this.lblFormCadastro.Size = new System.Drawing.Size(354, 24);
            this.lblFormCadastro.TabIndex = 0;
            this.lblFormCadastro.Text = "Formulário de Cadastro de Operador";
            // 
            // cbxUF
            // 
            this.cbxUF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxUF.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUF.Enabled = false;
            this.cbxUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbxUF.Location = new System.Drawing.Point(715, 323);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(48, 24);
            this.cbxUF.TabIndex = 10;
            // 
            // lblCEP
            // 
            this.lblCEP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCEP.AutoSize = true;
            this.lblCEP.BackColor = System.Drawing.Color.Transparent;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.ForeColor = System.Drawing.Color.Black;
            this.lblCEP.Location = new System.Drawing.Point(215, 354);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(42, 16);
            this.lblCEP.TabIndex = 12;
            this.lblCEP.Text = "CEP:";
            // 
            // lblUF
            // 
            this.lblUF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUF.AutoSize = true;
            this.lblUF.BackColor = System.Drawing.Color.Transparent;
            this.lblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.ForeColor = System.Drawing.Color.Black;
            this.lblUF.Location = new System.Drawing.Point(685, 325);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(32, 16);
            this.lblUF.TabIndex = 11;
            this.lblUF.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCidade.BackColor = System.Drawing.Color.White;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(517, 323);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(153, 22);
            this.txtCidade.TabIndex = 9;
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.Black;
            this.lblCidade.Location = new System.Drawing.Point(456, 325);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(62, 16);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtN
            // 
            this.txtN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtN.BackColor = System.Drawing.Color.White;
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(715, 295);
            this.txtN.Name = "txtN";
            this.txtN.ReadOnly = true;
            this.txtN.Size = new System.Drawing.Size(73, 22);
            this.txtN.TabIndex = 7;
            // 
            // lblN
            // 
            this.lblN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblN.AutoSize = true;
            this.lblN.BackColor = System.Drawing.Color.Transparent;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.ForeColor = System.Drawing.Color.Black;
            this.lblN.Location = new System.Drawing.Point(685, 295);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(29, 16);
            this.lblN.TabIndex = 8;
            this.lblN.Text = "Nº:";
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(276, 323);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ReadOnly = true;
            this.txtBairro.Size = new System.Drawing.Size(173, 22);
            this.txtBairro.TabIndex = 8;
            // 
            // lblBairrro
            // 
            this.lblBairrro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBairrro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairrro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairrro.ForeColor = System.Drawing.Color.Black;
            this.lblBairrro.Location = new System.Drawing.Point(215, 325);
            this.lblBairrro.Name = "lblBairrro";
            this.lblBairrro.Size = new System.Drawing.Size(60, 22);
            this.lblBairrro.TabIndex = 9;
            this.lblBairrro.Text = "Bairro:";
            // 
            // lblRua
            // 
            this.lblRua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRua.BackColor = System.Drawing.Color.Transparent;
            this.lblRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.ForeColor = System.Drawing.Color.Black;
            this.lblRua.Location = new System.Drawing.Point(215, 297);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(43, 22);
            this.lblRua.TabIndex = 7;
            this.lblRua.Text = "Rua:";
            // 
            // txtRua
            // 
            this.txtRua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRua.BackColor = System.Drawing.Color.White;
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(264, 295);
            this.txtRua.Name = "txtRua";
            this.txtRua.ReadOnly = true;
            this.txtRua.Size = new System.Drawing.Size(406, 22);
            this.txtRua.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(218, 174);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(448, 22);
            this.txtNome.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(218, 134);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(136, 22);
            this.txtID.TabIndex = 0;
            // 
            // lblFoto
            // 
            this.lblFoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFoto.BackColor = System.Drawing.Color.Transparent;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.ForeColor = System.Drawing.Color.Black;
            this.lblFoto.Location = new System.Drawing.Point(15, 279);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(90, 22);
            this.lblFoto.TabIndex = 16;
            this.lblFoto.Text = "Foto";
            this.lblFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(128, 136);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(90, 22);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Card:";
            // 
            // lblFone
            // 
            this.lblFone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFone.BackColor = System.Drawing.Color.Transparent;
            this.lblFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFone.ForeColor = System.Drawing.Color.Black;
            this.lblFone.Location = new System.Drawing.Point(128, 393);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(90, 22);
            this.lblFone.TabIndex = 13;
            this.lblFone.Text = "Fone:";
            // 
            // lblEndereço
            // 
            this.lblEndereço.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEndereço.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereço.ForeColor = System.Drawing.Color.Black;
            this.lblEndereço.Location = new System.Drawing.Point(133, 297);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(90, 22);
            this.lblEndereço.TabIndex = 7;
            this.lblEndereço.Text = "Endereço:";
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.Black;
            this.lblCPF.Location = new System.Drawing.Point(128, 255);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(90, 22);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF:";
            // 
            // lblIdentidade
            // 
            this.lblIdentidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdentidade.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentidade.ForeColor = System.Drawing.Color.Black;
            this.lblIdentidade.Location = new System.Drawing.Point(128, 215);
            this.lblIdentidade.Name = "lblIdentidade";
            this.lblIdentidade.Size = new System.Drawing.Size(90, 22);
            this.lblIdentidade.TabIndex = 2;
            this.lblIdentidade.Text = "Identidade:";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(128, 176);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(90, 22);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
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
            this.msMenuCadastroNovo,
            this.msMenuCadastroVisualizar,
            this.msMenuCadastroAlterar,
            this.msMenuCadastroExcluir,
            this.msMenuCadastroSair});
            this.msMenuCadastro.Name = "msMenuCadastro";
            this.msMenuCadastro.Size = new System.Drawing.Size(66, 20);
            this.msMenuCadastro.Text = "&Cadastro";
            // 
            // msMenuCadastroNovo
            // 
            this.msMenuCadastroNovo.Name = "msMenuCadastroNovo";
            this.msMenuCadastroNovo.Size = new System.Drawing.Size(205, 22);
            this.msMenuCadastroNovo.Text = "&Novo";
            this.msMenuCadastroNovo.Click += new System.EventHandler(this.msMenuCadastroNovo_Click);
            // 
            // msMenuCadastroVisualizar
            // 
            this.msMenuCadastroVisualizar.Name = "msMenuCadastroVisualizar";
            this.msMenuCadastroVisualizar.Size = new System.Drawing.Size(205, 22);
            this.msMenuCadastroVisualizar.Text = "&Visualizar outro Cadastro";
            this.msMenuCadastroVisualizar.Click += new System.EventHandler(this.msMenuCadastroVisualizar_Click);
            // 
            // msMenuCadastroAlterar
            // 
            this.msMenuCadastroAlterar.Name = "msMenuCadastroAlterar";
            this.msMenuCadastroAlterar.Size = new System.Drawing.Size(205, 22);
            this.msMenuCadastroAlterar.Text = "&Alterar Cadastro Atual";
            this.msMenuCadastroAlterar.Click += new System.EventHandler(this.msMenuCadastroAlterar_Click);
            // 
            // msMenuCadastroExcluir
            // 
            this.msMenuCadastroExcluir.Name = "msMenuCadastroExcluir";
            this.msMenuCadastroExcluir.Size = new System.Drawing.Size(205, 22);
            this.msMenuCadastroExcluir.Text = "&Excluir Cadastro Atual";
            this.msMenuCadastroExcluir.Click += new System.EventHandler(this.msMenuCadastroExcluir_Click);
            // 
            // msMenuCadastroSair
            // 
            this.msMenuCadastroSair.Name = "msMenuCadastroSair";
            this.msMenuCadastroSair.Size = new System.Drawing.Size(205, 22);
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
            // lblDataNasc
            // 
            this.lblDataNasc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataNasc.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.ForeColor = System.Drawing.Color.Black;
            this.lblDataNasc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDataNasc.Location = new System.Drawing.Point(378, 216);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(117, 22);
            this.lblDataNasc.TabIndex = 3;
            this.lblDataNasc.Text = "Data de Nasc.:";
            // 
            // mtxtDataNasc
            // 
            this.mtxtDataNasc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataNasc.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtxtDataNasc.Location = new System.Drawing.Point(501, 213);
            this.mtxtDataNasc.Mask = "00/00/0000";
            this.mtxtDataNasc.Name = "mtxtDataNasc";
            this.mtxtDataNasc.ReadOnly = true;
            this.mtxtDataNasc.Size = new System.Drawing.Size(80, 22);
            this.mtxtDataNasc.TabIndex = 4;
            this.mtxtDataNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pctbFoto
            // 
            this.pctbFoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pctbFoto.BackColor = System.Drawing.Color.Lavender;
            this.pctbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctbFoto.Location = new System.Drawing.Point(4, 121);
            this.pctbFoto.Name = "pctbFoto";
            this.pctbFoto.Size = new System.Drawing.Size(118, 150);
            this.pctbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbFoto.TabIndex = 63;
            this.pctbFoto.TabStop = false;
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
            // gpbBolsista
            // 
            this.gpbBolsista.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpbBolsista.BackColor = System.Drawing.Color.Transparent;
            this.gpbBolsista.Controls.Add(this.rbtnNao);
            this.gpbBolsista.Controls.Add(this.rbtnSim);
            this.gpbBolsista.Enabled = false;
            this.gpbBolsista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBolsista.Location = new System.Drawing.Point(4, 430);
            this.gpbBolsista.Name = "gpbBolsista";
            this.gpbBolsista.Size = new System.Drawing.Size(115, 88);
            this.gpbBolsista.TabIndex = 18;
            this.gpbBolsista.TabStop = false;
            this.gpbBolsista.Text = "Gratuidade";
            this.gpbBolsista.Visible = false;
            // 
            // rbtnNao
            // 
            this.rbtnNao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(3, 54);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(51, 19);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.Text = "Não";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Checked = true;
            this.rbtnSim.Location = new System.Drawing.Point(3, 29);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(50, 19);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
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
            this.lblOperador.TabIndex = 84;
            this.lblOperador.Text = "Operador: ";
            // 
            // printDialogDoc
            // 
            this.printDialogDoc.UseEXDialog = true;
            // 
            // txtIdentidade
            // 
            this.txtIdentidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdentidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidade.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtIdentidade.Location = new System.Drawing.Point(218, 213);
            this.txtIdentidade.Mask = "0000000000";
            this.txtIdentidade.Name = "txtIdentidade";
            this.txtIdentidade.ReadOnly = true;
            this.txtIdentidade.RejectInputOnFirstFailure = true;
            this.txtIdentidade.Size = new System.Drawing.Size(80, 22);
            this.txtIdentidade.TabIndex = 3;
            this.txtIdentidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpbTipoOperador
            // 
            this.gpbTipoOperador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpbTipoOperador.BackColor = System.Drawing.Color.Transparent;
            this.gpbTipoOperador.Controls.Add(this.rbtnGerente);
            this.gpbTipoOperador.Controls.Add(this.rbtnOpEntradaRU);
            this.gpbTipoOperador.Controls.Add(this.rbtnOpCredito);
            this.gpbTipoOperador.Controls.Add(this.rbtnOpCadastro);
            this.gpbTipoOperador.Enabled = false;
            this.gpbTipoOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipoOperador.Location = new System.Drawing.Point(0, 307);
            this.gpbTipoOperador.Name = "gpbTipoOperador";
            this.gpbTipoOperador.Size = new System.Drawing.Size(133, 116);
            this.gpbTipoOperador.TabIndex = 17;
            this.gpbTipoOperador.TabStop = false;
            this.gpbTipoOperador.Text = "Tipo do Operador";
            // 
            // rbtnGerente
            // 
            this.rbtnGerente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnGerente.AutoSize = true;
            this.rbtnGerente.Location = new System.Drawing.Point(5, 14);
            this.rbtnGerente.Name = "rbtnGerente";
            this.rbtnGerente.Size = new System.Drawing.Size(76, 19);
            this.rbtnGerente.TabIndex = 3;
            this.rbtnGerente.Text = "Gerente";
            this.rbtnGerente.UseVisualStyleBackColor = true;
            // 
            // rbtnOpEntradaRU
            // 
            this.rbtnOpEntradaRU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnOpEntradaRU.AutoSize = true;
            this.rbtnOpEntradaRU.Location = new System.Drawing.Point(5, 89);
            this.rbtnOpEntradaRU.Name = "rbtnOpEntradaRU";
            this.rbtnOpEntradaRU.Size = new System.Drawing.Size(125, 19);
            this.rbtnOpEntradaRU.TabIndex = 2;
            this.rbtnOpEntradaRU.Text = "Op. Entrada RU";
            this.rbtnOpEntradaRU.UseVisualStyleBackColor = true;
            // 
            // rbtnOpCredito
            // 
            this.rbtnOpCredito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnOpCredito.AutoSize = true;
            this.rbtnOpCredito.Location = new System.Drawing.Point(5, 64);
            this.rbtnOpCredito.Name = "rbtnOpCredito";
            this.rbtnOpCredito.Size = new System.Drawing.Size(97, 19);
            this.rbtnOpCredito.TabIndex = 1;
            this.rbtnOpCredito.Text = "Op. Crédito";
            this.rbtnOpCredito.UseVisualStyleBackColor = true;
            // 
            // rbtnOpCadastro
            // 
            this.rbtnOpCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnOpCadastro.AutoSize = true;
            this.rbtnOpCadastro.Location = new System.Drawing.Point(5, 39);
            this.rbtnOpCadastro.Name = "rbtnOpCadastro";
            this.rbtnOpCadastro.Size = new System.Drawing.Size(108, 19);
            this.rbtnOpCadastro.TabIndex = 0;
            this.rbtnOpCadastro.Text = "Op. Cadastro";
            this.rbtnOpCadastro.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(186, 433);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(125, 435);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 22);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(434, 136);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 22);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxStatus.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Enabled = false;
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Desbloqueado",
            "Bloqueado"});
            this.cbxStatus.Location = new System.Drawing.Point(501, 133);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(115, 24);
            this.cbxStatus.TabIndex = 1;
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
            this.pctbRU.TabIndex = 94;
            this.pctbRU.TabStop = false;
            // 
            // fCadastroVisualizarOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pctbRU);
            this.Controls.Add(this.lblFormCadastro);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtIdentidade);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.mtxtDataNasc);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.mtxtFone);
            this.Controls.Add(this.mtxtCEP);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.cbxUF);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairrro);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblIdentidade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.gpbTipoOperador);
            this.Controls.Add(this.gpbBolsista);
            this.Controls.Add(this.pctbFoto);
            this.Controls.Add(this.lblFoto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCadastroVisualizarOp";
            this.Text = "Operador de Cadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fCadastro_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbFoto)).EndInit();
            this.gpbBolsista.ResumeLayout(false);
            this.gpbBolsista.PerformLayout();
            this.gpbTipoOperador.ResumeLayout(false);
            this.gpbTipoOperador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtFone;
        private System.Windows.Forms.MaskedTextBox mtxtCEP;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.Label lblFormCadastro;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairrro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblIdentidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroNovo;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroAlterar;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroVisualizar;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroExcluir;
        private System.Windows.Forms.ToolStripMenuItem msMenuImprimir;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.MaskedTextBox mtxtDataNasc;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroSair;
        private System.Windows.Forms.PictureBox pctbFoto;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.GroupBox gpbBolsista;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.PrintDialog printDialogDoc;
        private System.Windows.Forms.MaskedTextBox txtIdentidade;
        private System.Windows.Forms.GroupBox gpbTipoOperador;
        private System.Windows.Forms.RadioButton rbtnGerente;
        private System.Windows.Forms.RadioButton rbtnOpEntradaRU;
        private System.Windows.Forms.RadioButton rbtnOpCredito;
        private System.Windows.Forms.RadioButton rbtnOpCadastro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.PictureBox pctbRU;
    }
}