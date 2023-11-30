namespace TROCGames.View
{
    partial class Playstation
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
            this.DgvJogosPlaystation = new System.Windows.Forms.DataGridView();
            this.GrbCategoriaPlaystation = new System.Windows.Forms.GroupBox();
            this.CmbCategoriaPlaystation = new System.Windows.Forms.ComboBox();
            this.GrbCarrinhoPlaystation = new System.Windows.Forms.GroupBox();
            this.BtnAdicionarCarrinho = new System.Windows.Forms.Button();
            this.BtnPagarPlaystation = new System.Windows.Forms.Button();
            this.LblTituloPlaystation = new System.Windows.Forms.Label();
            this.BtnPlaystation = new System.Windows.Forms.PictureBox();
            this.BtnExitPlaystation = new System.Windows.Forms.PictureBox();
            this.lblNItens = new System.Windows.Forms.Label();
            this.lblQtdCarrinho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJogosPlaystation)).BeginInit();
            this.GrbCategoriaPlaystation.SuspendLayout();
            this.GrbCarrinhoPlaystation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlaystation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExitPlaystation)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvJogosPlaystation
            // 
            this.DgvJogosPlaystation.AllowUserToAddRows = false;
            this.DgvJogosPlaystation.AllowUserToDeleteRows = false;
            this.DgvJogosPlaystation.AllowUserToResizeColumns = false;
            this.DgvJogosPlaystation.AllowUserToResizeRows = false;
            this.DgvJogosPlaystation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvJogosPlaystation.BackgroundColor = System.Drawing.Color.Black;
            this.DgvJogosPlaystation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJogosPlaystation.Location = new System.Drawing.Point(36, 64);
            this.DgvJogosPlaystation.Name = "DgvJogosPlaystation";
            this.DgvJogosPlaystation.Size = new System.Drawing.Size(427, 304);
            this.DgvJogosPlaystation.TabIndex = 1;
            this.DgvJogosPlaystation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvJogosPlaystation_CellClick);
            this.DgvJogosPlaystation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvJogosPlaystation_CellContentClick);
            // 
            // GrbCategoriaPlaystation
            // 
            this.GrbCategoriaPlaystation.Controls.Add(this.CmbCategoriaPlaystation);
            this.GrbCategoriaPlaystation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCategoriaPlaystation.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.GrbCategoriaPlaystation.Location = new System.Drawing.Point(57, 374);
            this.GrbCategoriaPlaystation.Name = "GrbCategoriaPlaystation";
            this.GrbCategoriaPlaystation.Size = new System.Drawing.Size(390, 66);
            this.GrbCategoriaPlaystation.TabIndex = 2;
            this.GrbCategoriaPlaystation.TabStop = false;
            this.GrbCategoriaPlaystation.Text = "Selecione a categoria";
            // 
            // CmbCategoriaPlaystation
            // 
            this.CmbCategoriaPlaystation.FormattingEnabled = true;
            this.CmbCategoriaPlaystation.Location = new System.Drawing.Point(6, 23);
            this.CmbCategoriaPlaystation.Name = "CmbCategoriaPlaystation";
            this.CmbCategoriaPlaystation.Size = new System.Drawing.Size(377, 26);
            this.CmbCategoriaPlaystation.TabIndex = 0;
            this.CmbCategoriaPlaystation.SelectedIndexChanged += new System.EventHandler(this.CmCategoriaPlaystation_SelectedIndexChanged);
            // 
            // GrbCarrinhoPlaystation
            // 
            this.GrbCarrinhoPlaystation.Controls.Add(this.BtnAdicionarCarrinho);
            this.GrbCarrinhoPlaystation.Controls.Add(this.BtnPagarPlaystation);
            this.GrbCarrinhoPlaystation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCarrinhoPlaystation.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.GrbCarrinhoPlaystation.Location = new System.Drawing.Point(57, 446);
            this.GrbCarrinhoPlaystation.Name = "GrbCarrinhoPlaystation";
            this.GrbCarrinhoPlaystation.Size = new System.Drawing.Size(390, 143);
            this.GrbCarrinhoPlaystation.TabIndex = 3;
            this.GrbCarrinhoPlaystation.TabStop = false;
            this.GrbCarrinhoPlaystation.Text = "Adicionar ao Carrinho e pagar";
            // 
            // BtnAdicionarCarrinho
            // 
            this.BtnAdicionarCarrinho.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAdicionarCarrinho.Enabled = false;
            this.BtnAdicionarCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionarCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionarCarrinho.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnAdicionarCarrinho.Location = new System.Drawing.Point(6, 23);
            this.BtnAdicionarCarrinho.Name = "BtnAdicionarCarrinho";
            this.BtnAdicionarCarrinho.Size = new System.Drawing.Size(377, 51);
            this.BtnAdicionarCarrinho.TabIndex = 1;
            this.BtnAdicionarCarrinho.Text = "Adicionar";
            this.BtnAdicionarCarrinho.UseVisualStyleBackColor = false;
            this.BtnAdicionarCarrinho.Click += new System.EventHandler(this.BtnAdicionarCarrinho_Click);
            // 
            // BtnPagarPlaystation
            // 
            this.BtnPagarPlaystation.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnPagarPlaystation.Enabled = false;
            this.BtnPagarPlaystation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagarPlaystation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagarPlaystation.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnPagarPlaystation.Location = new System.Drawing.Point(7, 80);
            this.BtnPagarPlaystation.Name = "BtnPagarPlaystation";
            this.BtnPagarPlaystation.Size = new System.Drawing.Size(377, 51);
            this.BtnPagarPlaystation.TabIndex = 0;
            this.BtnPagarPlaystation.Text = "Pagar";
            this.BtnPagarPlaystation.UseVisualStyleBackColor = false;
            this.BtnPagarPlaystation.Click += new System.EventHandler(this.BtnPagarPlaystation_Click);
            // 
            // LblTituloPlaystation
            // 
            this.LblTituloPlaystation.AutoSize = true;
            this.LblTituloPlaystation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTituloPlaystation.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloPlaystation.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LblTituloPlaystation.Location = new System.Drawing.Point(152, 6);
            this.LblTituloPlaystation.Name = "LblTituloPlaystation";
            this.LblTituloPlaystation.Size = new System.Drawing.Size(266, 55);
            this.LblTituloPlaystation.TabIndex = 4;
            this.LblTituloPlaystation.Text = "PlayStation";
            // 
            // BtnPlaystation
            // 
            this.BtnPlaystation.Image = global::TROCGames.Properties.Resources.Prancheta_12;
            this.BtnPlaystation.Location = new System.Drawing.Point(77, -7);
            this.BtnPlaystation.Name = "BtnPlaystation";
            this.BtnPlaystation.Size = new System.Drawing.Size(87, 94);
            this.BtnPlaystation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnPlaystation.TabIndex = 11;
            this.BtnPlaystation.TabStop = false;
            // 
            // BtnExitPlaystation
            // 
            this.BtnExitPlaystation.Image = global::TROCGames.Properties.Resources.Prancheta_13;
            this.BtnExitPlaystation.Location = new System.Drawing.Point(435, -7);
            this.BtnExitPlaystation.Name = "BtnExitPlaystation";
            this.BtnExitPlaystation.Size = new System.Drawing.Size(82, 86);
            this.BtnExitPlaystation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnExitPlaystation.TabIndex = 0;
            this.BtnExitPlaystation.TabStop = false;
            this.BtnExitPlaystation.Click += new System.EventHandler(this.BtnExitPlaystation_Click);
            // 
            // lblNItens
            // 
            this.lblNItens.AutoSize = true;
            this.lblNItens.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNItens.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNItens.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNItens.Location = new System.Drawing.Point(230, 606);
            this.lblNItens.Name = "lblNItens";
            this.lblNItens.Size = new System.Drawing.Size(210, 23);
            this.lblNItens.TabIndex = 12;
            this.lblNItens.Text = "Produtos no Carrinho:";
            // 
            // lblQtdCarrinho
            // 
            this.lblQtdCarrinho.AutoSize = true;
            this.lblQtdCarrinho.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQtdCarrinho.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdCarrinho.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblQtdCarrinho.Location = new System.Drawing.Point(440, 606);
            this.lblQtdCarrinho.Name = "lblQtdCarrinho";
            this.lblQtdCarrinho.Size = new System.Drawing.Size(21, 23);
            this.lblQtdCarrinho.TabIndex = 13;
            this.lblQtdCarrinho.Text = "0";
            this.lblQtdCarrinho.Click += new System.EventHandler(this.lblQtdCarrinho_Click);
            // 
            // Playstation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(507, 638);
            this.Controls.Add(this.lblQtdCarrinho);
            this.Controls.Add(this.lblNItens);
            this.Controls.Add(this.DgvJogosPlaystation);
            this.Controls.Add(this.BtnPlaystation);
            this.Controls.Add(this.LblTituloPlaystation);
            this.Controls.Add(this.GrbCarrinhoPlaystation);
            this.Controls.Add(this.GrbCategoriaPlaystation);
            this.Controls.Add(this.BtnExitPlaystation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Playstation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SS";
            this.Load += new System.EventHandler(this.Playstation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvJogosPlaystation)).EndInit();
            this.GrbCategoriaPlaystation.ResumeLayout(false);
            this.GrbCarrinhoPlaystation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlaystation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExitPlaystation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnExitPlaystation;
        private System.Windows.Forms.DataGridView DgvJogosPlaystation;
        private System.Windows.Forms.GroupBox GrbCategoriaPlaystation;
        private System.Windows.Forms.ComboBox CmbCategoriaPlaystation;
        private System.Windows.Forms.GroupBox GrbCarrinhoPlaystation;
        private System.Windows.Forms.Button BtnPagarPlaystation;
        private System.Windows.Forms.Label LblTituloPlaystation;
        private System.Windows.Forms.PictureBox BtnPlaystation;
        private System.Windows.Forms.Button BtnAdicionarCarrinho;
        private System.Windows.Forms.Label lblNItens;
        private System.Windows.Forms.Label lblQtdCarrinho;
    }
}