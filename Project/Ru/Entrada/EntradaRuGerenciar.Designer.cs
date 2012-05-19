namespace Ru
{
    partial class fEntradaRuGerenciar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEntradaRuGerenciar));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msMenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroVisualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuCadastroSair = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pctbRU = new System.Windows.Forms.PictureBox();
            this.pctbBoasVindas = new System.Windows.Forms.PictureBox();
            this.lblBSI = new System.Windows.Forms.Label();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBoasVindas)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuCadastro});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msMenu.Size = new System.Drawing.Size(1370, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "Menu";
            this.msMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msMenu_ItemClicked);
            // 
            // msMenuCadastro
            // 
            this.msMenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuCadastroVisualizar,
            this.msMenuCadastroSair});
            this.msMenuCadastro.Name = "msMenuCadastro";
            this.msMenuCadastro.Size = new System.Drawing.Size(59, 20);
            this.msMenuCadastro.Text = "&Opções";
            // 
            // msMenuCadastroVisualizar
            // 
            this.msMenuCadastroVisualizar.Name = "msMenuCadastroVisualizar";
            this.msMenuCadastroVisualizar.Size = new System.Drawing.Size(167, 22);
            this.msMenuCadastroVisualizar.Text = "&Autorizar por CPF";
            this.msMenuCadastroVisualizar.Click += new System.EventHandler(this.msMenuCadastroVisualizar_Click);
            // 
            // msMenuCadastroSair
            // 
            this.msMenuCadastroSair.Name = "msMenuCadastroSair";
            this.msMenuCadastroSair.Size = new System.Drawing.Size(155, 22);
            this.msMenuCadastroSair.Text = "&Encerrar Sessão";
            this.msMenuCadastroSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.lblBemVindo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.Color.Red;
            this.lblBemVindo.Location = new System.Drawing.Point(465, 84);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(502, 26);
            this.lblBemVindo.TabIndex = 4;
            this.lblBemVindo.Text = "Olá Operador de Autorização! Bem vindo ao sistema RU!";
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(1157, 729);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(201, 12);
            this.lblCopyright.TabIndex = 18;
            this.lblCopyright.Text = "Copyright © BSI UFRPE 2011.2";
            // 
            // pctbRU
            // 
            this.pctbRU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbRU.BackColor = System.Drawing.Color.Transparent;
            this.pctbRU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctbRU.BackgroundImage")));
            this.pctbRU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctbRU.Location = new System.Drawing.Point(1168, 27);
            this.pctbRU.Name = "pctbRU";
            this.pctbRU.Size = new System.Drawing.Size(180, 194);
            this.pctbRU.TabIndex = 63;
            this.pctbRU.TabStop = false;
            // 
            // pctbBoasVindas
            // 
            this.pctbBoasVindas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbBoasVindas.BackColor = System.Drawing.Color.Transparent;
            this.pctbBoasVindas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctbBoasVindas.BackgroundImage")));
            this.pctbBoasVindas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctbBoasVindas.Location = new System.Drawing.Point(584, 165);
            this.pctbBoasVindas.Name = "pctbBoasVindas";
            this.pctbBoasVindas.Size = new System.Drawing.Size(279, 226);
            this.pctbBoasVindas.TabIndex = 64;
            this.pctbBoasVindas.TabStop = false;
            // 
            // lblBSI
            // 
            this.lblBSI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBSI.AutoSize = true;
            this.lblBSI.BackColor = System.Drawing.Color.Lavender;
            this.lblBSI.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBSI.Location = new System.Drawing.Point(700, 244);
            this.lblBSI.Name = "lblBSI";
            this.lblBSI.Size = new System.Drawing.Size(28, 13);
            this.lblBSI.TabIndex = 65;
            this.lblBSI.Text = "BSI";
            // 
            // fEntradaRuGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.lblBSI);
            this.Controls.Add(this.pctbBoasVindas);
            this.Controls.Add(this.pctbRU);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.msMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.msMenu;
            this.Name = "fEntradaRuGerenciar";
            this.Text = "Operador de Autorização";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fCadastroGerenciar_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBoasVindas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroVisualizar;
        private System.Windows.Forms.ToolStripMenuItem msMenuCadastroSair;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.PictureBox pctbRU;
        private System.Windows.Forms.PictureBox pctbBoasVindas;
        private System.Windows.Forms.Label lblBSI;





    }
}