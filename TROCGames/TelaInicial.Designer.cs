namespace TROCGames
{
    partial class TelaInicial
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
            this.pcbTrocGames = new System.Windows.Forms.PictureBox();
            this.lblRecuperarCarrinho = new System.Windows.Forms.Label();
            this.lblIdCarrinho = new System.Windows.Forms.Label();
            this.txbIdCarrinho = new System.Windows.Forms.TextBox();
            this.btnRecuperarCarrinho = new System.Windows.Forms.Button();
            this.btnCriarNovoCarrinho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTrocGames)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbTrocGames
            // 
            this.pcbTrocGames.Image = global::TROCGames.Properties.Resources.Prancheta_1__7_;
            this.pcbTrocGames.Location = new System.Drawing.Point(162, 27);
            this.pcbTrocGames.Name = "pcbTrocGames";
            this.pcbTrocGames.Size = new System.Drawing.Size(163, 88);
            this.pcbTrocGames.TabIndex = 15;
            this.pcbTrocGames.TabStop = false;
            // 
            // lblRecuperarCarrinho
            // 
            this.lblRecuperarCarrinho.AutoSize = true;
            this.lblRecuperarCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperarCarrinho.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblRecuperarCarrinho.Location = new System.Drawing.Point(42, 134);
            this.lblRecuperarCarrinho.Name = "lblRecuperarCarrinho";
            this.lblRecuperarCarrinho.Size = new System.Drawing.Size(437, 29);
            this.lblRecuperarCarrinho.TabIndex = 16;
            this.lblRecuperarCarrinho.Text = "Recuperar ou criar um novo carrinho";
            // 
            // lblIdCarrinho
            // 
            this.lblIdCarrinho.AutoSize = true;
            this.lblIdCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCarrinho.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblIdCarrinho.Location = new System.Drawing.Point(86, 256);
            this.lblIdCarrinho.Name = "lblIdCarrinho";
            this.lblIdCarrinho.Size = new System.Drawing.Size(152, 25);
            this.lblIdCarrinho.TabIndex = 17;
            this.lblIdCarrinho.Text = "ID do carrinho:";
            // 
            // txbIdCarrinho
            // 
            this.txbIdCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdCarrinho.Location = new System.Drawing.Point(269, 250);
            this.txbIdCarrinho.Name = "txbIdCarrinho";
            this.txbIdCarrinho.Size = new System.Drawing.Size(100, 31);
            this.txbIdCarrinho.TabIndex = 18;
            // 
            // btnRecuperarCarrinho
            // 
            this.btnRecuperarCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperarCarrinho.Location = new System.Drawing.Point(72, 391);
            this.btnRecuperarCarrinho.Name = "btnRecuperarCarrinho";
            this.btnRecuperarCarrinho.Size = new System.Drawing.Size(127, 60);
            this.btnRecuperarCarrinho.TabIndex = 19;
            this.btnRecuperarCarrinho.Text = "Recuperar carrinho";
            this.btnRecuperarCarrinho.UseVisualStyleBackColor = true;
            this.btnRecuperarCarrinho.Click += new System.EventHandler(this.btnRecuperarCarrinho_Click);
            // 
            // btnCriarNovoCarrinho
            // 
            this.btnCriarNovoCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarNovoCarrinho.Location = new System.Drawing.Point(322, 391);
            this.btnCriarNovoCarrinho.Name = "btnCriarNovoCarrinho";
            this.btnCriarNovoCarrinho.Size = new System.Drawing.Size(127, 60);
            this.btnCriarNovoCarrinho.TabIndex = 20;
            this.btnCriarNovoCarrinho.Text = "Criar novo carrinho";
            this.btnCriarNovoCarrinho.UseVisualStyleBackColor = true;
            this.btnCriarNovoCarrinho.Click += new System.EventHandler(this.btnCriarNovoCarrinho_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(514, 503);
            this.Controls.Add(this.btnCriarNovoCarrinho);
            this.Controls.Add(this.btnRecuperarCarrinho);
            this.Controls.Add(this.txbIdCarrinho);
            this.Controls.Add(this.lblIdCarrinho);
            this.Controls.Add(this.lblRecuperarCarrinho);
            this.Controls.Add(this.pcbTrocGames);
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaInicial";
            this.Activated += new System.EventHandler(this.TelaInicial_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pcbTrocGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbTrocGames;
        private System.Windows.Forms.Label lblRecuperarCarrinho;
        private System.Windows.Forms.Label lblIdCarrinho;
        private System.Windows.Forms.TextBox txbIdCarrinho;
        private System.Windows.Forms.Button btnRecuperarCarrinho;
        private System.Windows.Forms.Button btnCriarNovoCarrinho;
    }
}