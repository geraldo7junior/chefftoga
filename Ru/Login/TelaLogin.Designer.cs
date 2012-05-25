namespace Ru
{
    partial class fTelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTelaLogin));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mtbLogin = new System.Windows.Forms.MaskedTextBox();
            this.lblErroLogar = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pctbRU = new System.Windows.Forms.PictureBox();
            this.lblCheffToga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRU)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(484, 424);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "&Sair";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // mtbLogin
            // 
            this.mtbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbLogin.BackColor = System.Drawing.Color.White;
            this.mtbLogin.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtbLogin.Location = new System.Drawing.Point(457, 310);
            this.mtbLogin.Mask = "000,000,000-00";
            this.mtbLogin.Name = "mtbLogin";
            this.mtbLogin.Size = new System.Drawing.Size(100, 20);
            this.mtbLogin.TabIndex = 9;
            this.mtbLogin.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbLogin_MaskInputRejected);
            // 
            // lblErroLogar
            // 
            this.lblErroLogar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErroLogar.AutoSize = true;
            this.lblErroLogar.BackColor = System.Drawing.Color.Transparent;
            this.lblErroLogar.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroLogar.ForeColor = System.Drawing.Color.Red;
            this.lblErroLogar.Location = new System.Drawing.Point(396, 257);
            this.lblErroLogar.Name = "lblErroLogar";
            this.lblErroLogar.Size = new System.Drawing.Size(0, 11);
            this.lblErroLogar.TabIndex = 13;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(457, 357);
            this.txtSenha.MaxLength = 6;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 10;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(453, 333);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(51, 21);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "&Senha";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEntrar.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(419, 424);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(59, 23);
            this.btnEntrar.TabIndex = 12;
            this.btnEntrar.Text = "&Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(453, 286);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(44, 21);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "&Login";
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(1122, 729);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(201, 12);
            this.lblCopyright.TabIndex = 17;
            this.lblCopyright.Text = "Copyright © BSI UFRPE 2011.2";
            // 
            // pctbRU
            // 
            this.pctbRU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbRU.BackColor = System.Drawing.Color.Transparent;
            this.pctbRU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctbRU.BackgroundImage")));
            this.pctbRU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctbRU.Location = new System.Drawing.Point(372, 181);
            this.pctbRU.Name = "pctbRU";
            this.pctbRU.Size = new System.Drawing.Size(502, 457);
            this.pctbRU.TabIndex = 64;
            this.pctbRU.TabStop = false;
            // 
            // lblCheffToga
            // 
            this.lblCheffToga.AutoSize = true;
            this.lblCheffToga.BackColor = System.Drawing.Color.Transparent;
            this.lblCheffToga.Font = new System.Drawing.Font("Freestyle Script", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheffToga.ForeColor = System.Drawing.Color.Maroon;
            this.lblCheffToga.Location = new System.Drawing.Point(514, 9);
            this.lblCheffToga.Name = "lblCheffToga";
            this.lblCheffToga.Size = new System.Drawing.Size(338, 112);
            this.lblCheffToga.TabIndex = 65;
            this.lblCheffToga.Text = "Cheff Toga";
            // 
            // fTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.lblCheffToga);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.mtbLogin);
            this.Controls.Add(this.lblErroLogar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pctbRU);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fTelaLogin";
            this.Text = "Tela de Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fTelaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbRU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox mtbLogin;
        private System.Windows.Forms.Label lblErroLogar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.PictureBox pctbRU;
        private System.Windows.Forms.Label lblCheffToga;
    }
}