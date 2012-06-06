namespace Ru
{
    partial class fCreditoCreditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCreditoCreditar));
            this.cbxPeriodo = new System.Windows.Forms.ComboBox();
            this.mtxtFone = new System.Windows.Forms.MaskedTextBox();
            this.lblFormCadastro = new System.Windows.Forms.Label();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFone = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msMenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroVisualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroSair = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.pctbFoto = new System.Windows.Forms.PictureBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.gpbBolsista = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblValorASerCreditado = new System.Windows.Forms.Label();
            this.btnCreditar = new System.Windows.Forms.Button();
            this.lblOperador = new System.Windows.Forms.Label();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.printDialogDoc = new System.Windows.Forms.PrintDialog();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblRS = new System.Windows.Forms.Label();
            this.lblRS1 = new System.Windows.Forms.Label();
            this.txtValorASerCreditado = new System.Windows.Forms.TextBox();
            this.gpbTipoOperador = new System.Windows.Forms.GroupBox();
            this.rbtnGerente = new System.Windows.Forms.RadioButton();
            this.rbtnOpEntradaRU = new System.Windows.Forms.RadioButton();
            this.rbtnOpCredito = new System.Windows.Forms.RadioButton();
            this.rbtnOpCadastro = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnDebitar = new System.Windows.Forms.Button();
            this.lblValorASerDebitado = new System.Windows.Forms.Label();
            this.lblDebitador = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblAstObs = new System.Windows.Forms.Label();
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
            // cbxPeriodo
            // 
            this.cbxPeriodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxPeriodo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPeriodo.Enabled = false;
            this.cbxPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPeriodo.FormattingEnabled = true;
            this.cbxPeriodo.Items.AddRange(new object[] {
            "1º",
            "2º",
            "3º",
            "4º",
            "5º",
            "6º",
            "7º",
            "8º",
            "9º",
            "10º",
            "11º",
            "12º",
            "Pós-Graduação",
            "Mestrado",
            "Doutorado",
            "Pós-Doutorado"});
            this.cbxPeriodo.Location = new System.Drawing.Point(221, 329);
            this.cbxPeriodo.Name = "cbxPeriodo";
            this.cbxPeriodo.Size = new System.Drawing.Size(172, 24);
            this.cbxPeriodo.TabIndex = 6;
            this.cbxPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbxPeriodo_SelectedIndexChanged);
            // 
            // mtxtFone
            // 
            this.mtxtFone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtFone.Location = new System.Drawing.Point(221, 368);
            this.mtxtFone.Mask = "(00)0000-0000";
            this.mtxtFone.Name = "mtxtFone";
            this.mtxtFone.ReadOnly = true;
            this.mtxtFone.Size = new System.Drawing.Size(100, 22);
            this.mtxtFone.TabIndex = 9;
            // 
            // lblFormCadastro
            // 
            this.lblFormCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFormCadastro.AutoSize = true;
            this.lblFormCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblFormCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormCadastro.Location = new System.Drawing.Point(346, 26);
            this.lblFormCadastro.Name = "lblFormCadastro";
            this.lblFormCadastro.Size = new System.Drawing.Size(107, 24);
            this.lblFormCadastro.TabIndex = 0;
            this.lblFormCadastro.Text = "Creditador";
            // 
            // cbxCurso
            // 
            this.cbxCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCurso.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCurso.Enabled = false;
            this.cbxCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Items.AddRange(new object[] {
            "Administração",
            "Administração UAST",
            "Agronomia",
            "Agronomia UAG",
            "Agronomia UAST",
            "Bacharelado em Ciência da Computação",
            "Bacharelado em Ciência da Computação UAG",
            "Bacharelado em Ciências Biológicas",
            "Bacharelado em Ciências Biológicas UAST",
            "Bacharelado em Ciências Econômicas",
            "Bacharelado em Ciências Econômicas UAST",
            "Bacharelado em Ciências Sociais",
            "Bacharelado em Gastronomia e Segurança Alimentar",
            "Bacharelado em Sistemas de Informação",
            "Bacharelado em Sistemas de Informação UAST",
            "Economia Doméstica",
            "Engenharia Agrícola e Ambiental",
            "Engenharia de Alimentos UAG",
            "Engenharia de Pesca",
            "Engenharia de Pesca UAST",
            "Engenharia Florestal",
            "Licenciatura em Ciências Agrícolas",
            "Licenciatura em Computação",
            "Licenciatura em Educação Física",
            "Licenciatura em Física",
            "Licenciatura em História",
            "Licenciatura em Letras (Português e Espanhol)",
            "Licenciatura em Letras Português/Inglês UAG",
            "Licenciatura em Letras UAST",
            "Licenciatura em Matemática",
            "Licenciatura em Pedagogia",
            "Licenciatura em Pedagogia UAG",
            "Licenciatura em Química",
            "Licenciatura em Química UAST",
            "Licenciatura Plena em Ciências Biológicas",
            "Medicina Veterinária",
            "Medicina Veterinária UAG",
            "Zootecnia",
            "Zootecnia UAG",
            "Zootecnia UAST"});
            this.cbxCurso.Location = new System.Drawing.Point(221, 293);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(353, 24);
            this.cbxCurso.TabIndex = 5;
            this.cbxCurso.SelectedIndexChanged += new System.EventHandler(this.cbxCurso_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(221, 217);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(448, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(221, 177);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(136, 22);
            this.txtID.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(131, 179);
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
            this.lblFone.Location = new System.Drawing.Point(131, 369);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(90, 22);
            this.lblFone.TabIndex = 8;
            this.lblFone.Text = "Fone:";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.ForeColor = System.Drawing.Color.Black;
            this.lblPeriodo.Location = new System.Drawing.Point(131, 332);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(90, 22);
            this.lblPeriodo.TabIndex = 6;
            this.lblPeriodo.Text = "Período:";
            this.lblPeriodo.Click += new System.EventHandler(this.lblPeriodo_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.Color.Black;
            this.lblCurso.Location = new System.Drawing.Point(131, 294);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(90, 22);
            this.lblCurso.TabIndex = 5;
            this.lblCurso.Text = "Curso:";
            this.lblCurso.Click += new System.EventHandler(this.lblCurso_Click);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(131, 219);
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
            this.msMenu.TabIndex = 61;
            this.msMenu.Text = "Menu";
            // 
            // msMenuCadastro
            // 
            this.msMenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuCadastroVisualizar,
            this.msMenuCadastroAlterar,
            this.msMenuCadastroSair});
            this.msMenuCadastro.Name = "msMenuCadastro";
            this.msMenuCadastro.Size = new System.Drawing.Size(58, 20);
            this.msMenuCadastro.Text = "&Crédito";
            // 
            // msMenuCadastroVisualizar
            // 
            this.msMenuCadastroVisualizar.Name = "msMenuCadastroVisualizar";
            this.msMenuCadastroVisualizar.Size = new System.Drawing.Size(213, 22);
            this.msMenuCadastroVisualizar.Text = "&Visualizar Outro Saldo";
            this.msMenuCadastroVisualizar.Click += new System.EventHandler(this.msMenuCadastroVisualizar_Click);
            // 
            // msMenuCadastroAlterar
            // 
            this.msMenuCadastroAlterar.Name = "msMenuCadastroAlterar";
            this.msMenuCadastroAlterar.Size = new System.Drawing.Size(213, 22);
            this.msMenuCadastroAlterar.Text = "&Creditar em Outro Usuário";
            this.msMenuCadastroAlterar.Click += new System.EventHandler(this.msMenuCadastroAlterar_Click);
            // 
            // msMenuCadastroSair
            // 
            this.msMenuCadastroSair.Name = "msMenuCadastroSair";
            this.msMenuCadastroSair.Size = new System.Drawing.Size(213, 22);
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
            this.gpbBolsista.Location = new System.Drawing.Point(9, 307);
            this.gpbBolsista.Name = "gpbBolsista";
            this.gpbBolsista.Size = new System.Drawing.Size(115, 88);
            this.gpbBolsista.TabIndex = 12;
            this.gpbBolsista.TabStop = false;
            this.gpbBolsista.Text = "Gratuidade";
            // 
            // rbtnNao
            // 
            this.rbtnNao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Checked = true;
            this.rbtnNao.Location = new System.Drawing.Point(3, 54);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(51, 19);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "Não";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(3, 29);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(50, 19);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // lblSaldo
            // 
            this.lblSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Black;
            this.lblSaldo.Location = new System.Drawing.Point(131, 429);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(90, 22);
            this.lblSaldo.TabIndex = 10;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblValorASerCreditado
            // 
            this.lblValorASerCreditado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorASerCreditado.BackColor = System.Drawing.Color.Transparent;
            this.lblValorASerCreditado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorASerCreditado.ForeColor = System.Drawing.Color.Black;
            this.lblValorASerCreditado.Location = new System.Drawing.Point(215, 124);
            this.lblValorASerCreditado.Name = "lblValorASerCreditado";
            this.lblValorASerCreditado.Size = new System.Drawing.Size(164, 22);
            this.lblValorASerCreditado.TabIndex = 0;
            this.lblValorASerCreditado.Text = "Valor a ser creditado:";
            // 
            // btnCreditar
            // 
            this.btnCreditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreditar.Location = new System.Drawing.Point(481, 120);
            this.btnCreditar.Name = "btnCreditar";
            this.btnCreditar.Size = new System.Drawing.Size(75, 23);
            this.btnCreditar.TabIndex = 1;
            this.btnCreditar.Text = "&Creditar";
            this.btnCreditar.UseVisualStyleBackColor = true;
            this.btnCreditar.Click += new System.EventHandler(this.btnCreditar_Click);
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
            // mtxtCPF
            // 
            this.mtxtCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCPF.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtxtCPF.Location = new System.Drawing.Point(221, 255);
            this.mtxtCPF.Mask = "000,000,000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.ReadOnly = true;
            this.mtxtCPF.RejectInputOnFirstFailure = true;
            this.mtxtCPF.Size = new System.Drawing.Size(100, 22);
            this.mtxtCPF.TabIndex = 2;
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.Black;
            this.lblCPF.Location = new System.Drawing.Point(131, 257);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(90, 22);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // printDialogDoc
            // 
            this.printDialogDoc.UseEXDialog = true;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSaldo.BackColor = System.Drawing.Color.White;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(221, 427);
            this.txtSaldo.MaxLength = 6;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(86, 22);
            this.txtSaldo.TabIndex = 11;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSaldo.FontChanged += new System.EventHandler(this.txtSaldo_FontChanged);
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            // 
            // lblRS
            // 
            this.lblRS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRS.AutoSize = true;
            this.lblRS.BackColor = System.Drawing.Color.White;
            this.lblRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRS.Location = new System.Drawing.Point(375, 124);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(25, 16);
            this.lblRS.TabIndex = 85;
            this.lblRS.Text = "R$";
            // 
            // lblRS1
            // 
            this.lblRS1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRS1.AutoSize = true;
            this.lblRS1.BackColor = System.Drawing.Color.White;
            this.lblRS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRS1.Location = new System.Drawing.Point(227, 430);
            this.lblRS1.Name = "lblRS1";
            this.lblRS1.Size = new System.Drawing.Size(25, 16);
            this.lblRS1.TabIndex = 86;
            this.lblRS1.Text = "R$";
            // 
            // txtValorASerCreditado
            // 
            this.txtValorASerCreditado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorASerCreditado.BackColor = System.Drawing.Color.White;
            this.txtValorASerCreditado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorASerCreditado.Location = new System.Drawing.Point(401, 121);
            this.txtValorASerCreditado.MaxLength = 5;
            this.txtValorASerCreditado.Name = "txtValorASerCreditado";
            this.txtValorASerCreditado.Size = new System.Drawing.Size(73, 22);
            this.txtValorASerCreditado.TabIndex = 0;
            this.txtValorASerCreditado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorASerCreditado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorASerCreditado_KeyDown);
            this.txtValorASerCreditado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorASerCreditado_KeyPress);
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
            this.gpbTipoOperador.TabIndex = 87;
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
            this.txtEmail.Location = new System.Drawing.Point(221, 398);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 89;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(130, 400);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 22);
            this.lblEmail.TabIndex = 88;
            this.lblEmail.Text = "E-mail:";
            // 
            // btnDebitar
            // 
            this.btnDebitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDebitar.Location = new System.Drawing.Point(481, 120);
            this.btnDebitar.Name = "btnDebitar";
            this.btnDebitar.Size = new System.Drawing.Size(75, 23);
            this.btnDebitar.TabIndex = 92;
            this.btnDebitar.Text = "&Debitar";
            this.btnDebitar.UseVisualStyleBackColor = true;
            this.btnDebitar.Click += new System.EventHandler(this.btnDebitar_Click);
            // 
            // lblValorASerDebitado
            // 
            this.lblValorASerDebitado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorASerDebitado.BackColor = System.Drawing.Color.Transparent;
            this.lblValorASerDebitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorASerDebitado.ForeColor = System.Drawing.Color.Black;
            this.lblValorASerDebitado.Location = new System.Drawing.Point(215, 124);
            this.lblValorASerDebitado.Name = "lblValorASerDebitado";
            this.lblValorASerDebitado.Size = new System.Drawing.Size(164, 22);
            this.lblValorASerDebitado.TabIndex = 90;
            this.lblValorASerDebitado.Text = "Valor a ser debitado";
            // 
            // lblDebitador
            // 
            this.lblDebitador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDebitador.AutoSize = true;
            this.lblDebitador.BackColor = System.Drawing.Color.Transparent;
            this.lblDebitador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebitador.Location = new System.Drawing.Point(348, 26);
            this.lblDebitador.Name = "lblDebitador";
            this.lblDebitador.Size = new System.Drawing.Size(100, 24);
            this.lblDebitador.TabIndex = 91;
            this.lblDebitador.Text = "Debitador";
            // 
            // txtObs
            // 
            this.txtObs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtObs.Location = new System.Drawing.Point(385, 353);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(218, 219);
            this.txtObs.TabIndex = 93;
            this.txtObs.Text = "";
            // 
            // lblObs
            // 
            this.lblObs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblObs.BackColor = System.Drawing.Color.Transparent;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.Color.Black;
            this.lblObs.Location = new System.Drawing.Point(423, 312);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(146, 38);
            this.lblObs.TabIndex = 94;
            this.lblObs.Text = "Motivo de retirada de crédito";
            this.lblObs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAstObs
            // 
            this.lblAstObs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAstObs.AutoSize = true;
            this.lblAstObs.BackColor = System.Drawing.Color.Transparent;
            this.lblAstObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstObs.ForeColor = System.Drawing.Color.Red;
            this.lblAstObs.Location = new System.Drawing.Point(569, 312);
            this.lblAstObs.Name = "lblAstObs";
            this.lblAstObs.Size = new System.Drawing.Size(0, 24);
            this.lblAstObs.TabIndex = 95;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(423, 178);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 22);
            this.lblStatus.TabIndex = 97;
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
            this.cbxStatus.Location = new System.Drawing.Point(490, 175);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(115, 24);
            this.cbxStatus.TabIndex = 96;
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
            this.pctbRU.TabIndex = 98;
            this.pctbRU.TabStop = false;
            // 
            // fCreditoCreditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pctbRU);
            this.Controls.Add(this.gpbTipoOperador);
            this.Controls.Add(this.pctbFoto);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.btnDebitar);
            this.Controls.Add(this.lblValorASerDebitado);
            this.Controls.Add(this.lblDebitador);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblRS);
            this.Controls.Add(this.txtValorASerCreditado);
            this.Controls.Add(this.lblRS1);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.btnCreditar);
            this.Controls.Add(this.lblValorASerCreditado);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.cbxPeriodo);
            this.Controls.Add(this.mtxtFone);
            this.Controls.Add(this.lblFormCadastro);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.gpbBolsista);
            this.Controls.Add(this.lblAstObs);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtObs);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCreditoCreditar";
            this.Text = "Operador de Crédito";
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

        private System.Windows.Forms.ComboBox cbxPeriodo;
        private System.Windows.Forms.MaskedTextBox mtxtFone;
        private System.Windows.Forms.Label lblFormCadastro;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroAlterar;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroVisualizar;
        private System.Windows.Forms.ToolStripMenuItem msMenuImprimir;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroSair;
        private System.Windows.Forms.PictureBox pctbFoto;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.GroupBox gpbBolsista;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblValorASerCreditado;
        private System.Windows.Forms.Button btnCreditar;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.PrintDialog printDialogDoc;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblRS;
        private System.Windows.Forms.Label lblRS1;
        private System.Windows.Forms.TextBox txtValorASerCreditado;
        private System.Windows.Forms.GroupBox gpbTipoOperador;
        private System.Windows.Forms.RadioButton rbtnGerente;
        private System.Windows.Forms.RadioButton rbtnOpEntradaRU;
        private System.Windows.Forms.RadioButton rbtnOpCredito;
        private System.Windows.Forms.RadioButton rbtnOpCadastro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnDebitar;
        private System.Windows.Forms.Label lblValorASerDebitado;
        private System.Windows.Forms.Label lblDebitador;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblAstObs;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.PictureBox pctbRU;
    }
}