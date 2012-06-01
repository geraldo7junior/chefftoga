namespace Ru
{
    partial class fStatus
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
            this.txtTodosStatus = new System.Windows.Forms.RichTextBox();
            this.btnBloquear = new System.Windows.Forms.Button();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.lblInforme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTodosStatus
            // 
            this.txtTodosStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTodosStatus.Location = new System.Drawing.Point(-2, 27);
            this.txtTodosStatus.Name = "txtTodosStatus";
            this.txtTodosStatus.Size = new System.Drawing.Size(287, 183);
            this.txtTodosStatus.TabIndex = 0;
            this.txtTodosStatus.Text = "";
            // 
            // btnBloquear
            // 
            this.btnBloquear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBloquear.Location = new System.Drawing.Point(100, 220);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(75, 23);
            this.btnBloquear.TabIndex = 1;
            this.btnBloquear.Text = "&Bloquear";
            this.btnBloquear.UseVisualStyleBackColor = true;
            this.btnBloquear.Click += new System.EventHandler(this.btnBloquear_Click);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDesbloquear.Location = new System.Drawing.Point(100, 231);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(75, 23);
            this.btnDesbloquear.TabIndex = 2;
            this.btnDesbloquear.Text = "&Desbloquear";
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // lblInforme
            // 
            this.lblInforme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInforme.AutoSize = true;
            this.lblInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInforme.Location = new System.Drawing.Point(0, 4);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(35, 13);
            this.lblInforme.TabIndex = 3;
            this.lblInforme.Text = "label1";
            // 
            // fStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblInforme);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.btnBloquear);
            this.Controls.Add(this.txtTodosStatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alteração de Status";
            this.Load += new System.EventHandler(this.fStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTodosStatus;
        private System.Windows.Forms.Button btnBloquear;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Label lblInforme;
    }
}