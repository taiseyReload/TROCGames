namespace TROCGames.Views
{
    partial class Xbox
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
            this.DgvJogosXbox = new System.Windows.Forms.DataGridView();
            this.LblTituloXbox = new System.Windows.Forms.Label();
            this.GrbCarrinhoXbox = new System.Windows.Forms.GroupBox();
            this.BtnAdicionarCarrinho = new System.Windows.Forms.Button();
            this.BtnPagarXbox = new System.Windows.Forms.Button();
            this.GrbCategoriaXbox = new System.Windows.Forms.GroupBox();
            this.CmbCategoriaXbox = new System.Windows.Forms.ComboBox();
            this.lblQtdCarrinho = new System.Windows.Forms.Label();
            this.lblNItens = new System.Windows.Forms.Label();
            this.btnIrCarrinho = new System.Windows.Forms.PictureBox();
            this.BtnXboxIcon = new System.Windows.Forms.PictureBox();
            this.BtnExitXbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJogosXbox)).BeginInit();
            this.GrbCarrinhoXbox.SuspendLayout();
            this.GrbCategoriaXbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnIrCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnXboxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExitXbox)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvJogosXbox
            // 
            this.DgvJogosXbox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvJogosXbox.BackgroundColor = System.Drawing.Color.Black;
            this.DgvJogosXbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJogosXbox.Location = new System.Drawing.Point(54, 73);
            this.DgvJogosXbox.Name = "DgvJogosXbox";
            this.DgvJogosXbox.Size = new System.Drawing.Size(390, 304);
            this.DgvJogosXbox.TabIndex = 13;
            this.DgvJogosXbox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvJogosXbox_CellClick);
            // 
            // LblTituloXbox
            // 
            this.LblTituloXbox.AutoSize = true;
            this.LblTituloXbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTituloXbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloXbox.ForeColor = System.Drawing.Color.LawnGreen;
            this.LblTituloXbox.Location = new System.Drawing.Point(220, 9);
            this.LblTituloXbox.Name = "LblTituloXbox";
            this.LblTituloXbox.Size = new System.Drawing.Size(134, 55);
            this.LblTituloXbox.TabIndex = 16;
            this.LblTituloXbox.Text = "Xbox";
            // 
            // GrbCarrinhoXbox
            // 
            this.GrbCarrinhoXbox.Controls.Add(this.BtnAdicionarCarrinho);
            this.GrbCarrinhoXbox.Controls.Add(this.BtnPagarXbox);
            this.GrbCarrinhoXbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCarrinhoXbox.ForeColor = System.Drawing.Color.LawnGreen;
            this.GrbCarrinhoXbox.Location = new System.Drawing.Point(54, 455);
            this.GrbCarrinhoXbox.Name = "GrbCarrinhoXbox";
            this.GrbCarrinhoXbox.Size = new System.Drawing.Size(390, 142);
            this.GrbCarrinhoXbox.TabIndex = 15;
            this.GrbCarrinhoXbox.TabStop = false;
            this.GrbCarrinhoXbox.Text = "Adicionar ao carrinho e pagar";
            // 
            // BtnAdicionarCarrinho
            // 
            this.BtnAdicionarCarrinho.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnAdicionarCarrinho.Enabled = false;
            this.BtnAdicionarCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionarCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionarCarrinho.ForeColor = System.Drawing.Color.White;
            this.BtnAdicionarCarrinho.Location = new System.Drawing.Point(7, 23);
            this.BtnAdicionarCarrinho.Name = "BtnAdicionarCarrinho";
            this.BtnAdicionarCarrinho.Size = new System.Drawing.Size(377, 51);
            this.BtnAdicionarCarrinho.TabIndex = 1;
            this.BtnAdicionarCarrinho.Text = "Adicionar";
            this.BtnAdicionarCarrinho.UseVisualStyleBackColor = false;
            this.BtnAdicionarCarrinho.Click += new System.EventHandler(this.BtnAdicionarCarrinho_Click);
            // 
            // BtnPagarXbox
            // 
            this.BtnPagarXbox.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnPagarXbox.Enabled = false;
            this.BtnPagarXbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagarXbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagarXbox.ForeColor = System.Drawing.Color.White;
            this.BtnPagarXbox.Location = new System.Drawing.Point(7, 80);
            this.BtnPagarXbox.Name = "BtnPagarXbox";
            this.BtnPagarXbox.Size = new System.Drawing.Size(377, 51);
            this.BtnPagarXbox.TabIndex = 0;
            this.BtnPagarXbox.Text = "Pagar";
            this.BtnPagarXbox.UseVisualStyleBackColor = false;
            this.BtnPagarXbox.Click += new System.EventHandler(this.BtnPagarXbox_Click);
            // 
            // GrbCategoriaXbox
            // 
            this.GrbCategoriaXbox.Controls.Add(this.CmbCategoriaXbox);
            this.GrbCategoriaXbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCategoriaXbox.ForeColor = System.Drawing.Color.LawnGreen;
            this.GrbCategoriaXbox.Location = new System.Drawing.Point(54, 383);
            this.GrbCategoriaXbox.Name = "GrbCategoriaXbox";
            this.GrbCategoriaXbox.Size = new System.Drawing.Size(390, 66);
            this.GrbCategoriaXbox.TabIndex = 14;
            this.GrbCategoriaXbox.TabStop = false;
            this.GrbCategoriaXbox.Text = "Selecione a categoria";
            // 
            // CmbCategoriaXbox
            // 
            this.CmbCategoriaXbox.FormattingEnabled = true;
            this.CmbCategoriaXbox.Location = new System.Drawing.Point(6, 23);
            this.CmbCategoriaXbox.Name = "CmbCategoriaXbox";
            this.CmbCategoriaXbox.Size = new System.Drawing.Size(377, 26);
            this.CmbCategoriaXbox.TabIndex = 0;
            this.CmbCategoriaXbox.SelectedIndexChanged += new System.EventHandler(this.CmbCategoriaXbox_SelectedIndexChanged);
            // 
            // lblQtdCarrinho
            // 
            this.lblQtdCarrinho.AutoSize = true;
            this.lblQtdCarrinho.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQtdCarrinho.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdCarrinho.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblQtdCarrinho.Location = new System.Drawing.Point(362, 606);
            this.lblQtdCarrinho.Name = "lblQtdCarrinho";
            this.lblQtdCarrinho.Size = new System.Drawing.Size(21, 23);
            this.lblQtdCarrinho.TabIndex = 27;
            this.lblQtdCarrinho.Text = "0";
            // 
            // lblNItens
            // 
            this.lblNItens.AutoSize = true;
            this.lblNItens.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNItens.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNItens.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblNItens.Location = new System.Drawing.Point(152, 606);
            this.lblNItens.Name = "lblNItens";
            this.lblNItens.Size = new System.Drawing.Size(210, 23);
            this.lblNItens.TabIndex = 26;
            this.lblNItens.Text = "Produtos no Carrinho:";
            // 
            // btnIrCarrinho
            // 
            this.btnIrCarrinho.Image = global::TROCGames.Properties.Resources.Xbox;
            this.btnIrCarrinho.Location = new System.Drawing.Point(-2, 1);
            this.btnIrCarrinho.Name = "btnIrCarrinho";
            this.btnIrCarrinho.Size = new System.Drawing.Size(75, 66);
            this.btnIrCarrinho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnIrCarrinho.TabIndex = 28;
            this.btnIrCarrinho.TabStop = false;
            // 
            // BtnXboxIcon
            // 
            this.BtnXboxIcon.Image = global::TROCGames.Properties.Resources.Prancheta_2;
            this.BtnXboxIcon.Location = new System.Drawing.Point(124, -39);
            this.BtnXboxIcon.Name = "BtnXboxIcon";
            this.BtnXboxIcon.Size = new System.Drawing.Size(107, 164);
            this.BtnXboxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnXboxIcon.TabIndex = 17;
            this.BtnXboxIcon.TabStop = false;
            // 
            // BtnExitXbox
            // 
            this.BtnExitXbox.Image = global::TROCGames.Properties.Resources.Prancheta_14;
            this.BtnExitXbox.Location = new System.Drawing.Point(433, -7);
            this.BtnExitXbox.Name = "BtnExitXbox";
            this.BtnExitXbox.Size = new System.Drawing.Size(82, 86);
            this.BtnExitXbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnExitXbox.TabIndex = 12;
            this.BtnExitXbox.TabStop = false;
            this.BtnExitXbox.Click += new System.EventHandler(this.BtnExitXbox_Click);
            // 
            // Xbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(507, 638);
            this.Controls.Add(this.btnIrCarrinho);
            this.Controls.Add(this.lblQtdCarrinho);
            this.Controls.Add(this.lblNItens);
            this.Controls.Add(this.DgvJogosXbox);
            this.Controls.Add(this.BtnXboxIcon);
            this.Controls.Add(this.LblTituloXbox);
            this.Controls.Add(this.GrbCarrinhoXbox);
            this.Controls.Add(this.GrbCategoriaXbox);
            this.Controls.Add(this.BtnExitXbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Xbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xbox";
            this.Load += new System.EventHandler(this.Xbox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvJogosXbox)).EndInit();
            this.GrbCarrinhoXbox.ResumeLayout(false);
            this.GrbCategoriaXbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnIrCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnXboxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExitXbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvJogosXbox;
        private System.Windows.Forms.PictureBox BtnXboxIcon;
        private System.Windows.Forms.Label LblTituloXbox;
        private System.Windows.Forms.GroupBox GrbCarrinhoXbox;
        private System.Windows.Forms.Button BtnPagarXbox;
        private System.Windows.Forms.GroupBox GrbCategoriaXbox;
        private System.Windows.Forms.ComboBox CmbCategoriaXbox;
        private System.Windows.Forms.PictureBox BtnExitXbox;
        private System.Windows.Forms.Button BtnAdicionarCarrinho;
        private System.Windows.Forms.Label lblQtdCarrinho;
        private System.Windows.Forms.Label lblNItens;
        private System.Windows.Forms.PictureBox btnIrCarrinho;
    }
}