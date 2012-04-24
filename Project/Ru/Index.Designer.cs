namespace Ru
{
    partial class fIndex
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fIndex));
            this.lblAp = new System.Windows.Forms.Label();
            this.progressBarAp = new System.Windows.Forms.ProgressBar();
            this.timerAp = new System.Windows.Forms.Timer(this.components);
            this.pctbCarregando = new System.Windows.Forms.PictureBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctbCarregando)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAp
            // 
            this.lblAp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAp.AutoSize = true;
            this.lblAp.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAp.Location = new System.Drawing.Point(173, 56);
            this.lblAp.Name = "lblAp";
            this.lblAp.Size = new System.Drawing.Size(24, 18);
            this.lblAp.TabIndex = 0;
            this.lblAp.Text = "Ap";
            // 
            // progressBarAp
            // 
            this.progressBarAp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarAp.Location = new System.Drawing.Point(166, 103);
            this.progressBarAp.Maximum = 130;
            this.progressBarAp.Name = "progressBarAp";
            this.progressBarAp.Size = new System.Drawing.Size(173, 19);
            this.progressBarAp.TabIndex = 1;
            // 
            // timerAp
            // 
            this.timerAp.Enabled = true;
            this.timerAp.Tick += new System.EventHandler(this.timerAp_Tick);
            // 
            // pctbCarregando
            // 
            this.pctbCarregando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbCarregando.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctbCarregando.BackgroundImage")));
            this.pctbCarregando.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctbCarregando.Location = new System.Drawing.Point(12, 44);
            this.pctbCarregando.Name = "pctbCarregando";
            this.pctbCarregando.Size = new System.Drawing.Size(126, 118);
            this.pctbCarregando.TabIndex = 2;
            this.pctbCarregando.TabStop = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(9, 185);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(201, 12);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "Copyright © BSI UFRPE 2011.2";
            // 
            // fIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(417, 207);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.pctbCarregando);
            this.Controls.Add(this.progressBarAp);
            this.Controls.Add(this.lblAp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BSI-2011.2";
            ((System.ComponentModel.ISupportInitialize)(this.pctbCarregando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAp;
        private System.Windows.Forms.ProgressBar progressBarAp;
        private System.Windows.Forms.Timer timerAp;
        private System.Windows.Forms.PictureBox pctbCarregando;
        private System.Windows.Forms.Label lblCopyright;

    }
}

