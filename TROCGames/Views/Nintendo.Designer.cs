namespace TROCGames.Views
{
    partial class Nintendo
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
            this.DgvJogosNintendo = new System.Windows.Forms.DataGridView();
            this.GrbCarrinhoNintendo = new System.Windows.Forms.GroupBox();
            this.BtnAdicionarCarrinho = new System.Windows.Forms.Button();
            this.BtnPagarNintendo = new System.Windows.Forms.Button();
            this.GrbCategoriaNintendo = new System.Windows.Forms.GroupBox();
            this.CmbCategoriaNintendo = new System.Windows.Forms.ComboBox();
            this.BtnNintendoIcon = new System.Windows.Forms.PictureBox();
            this.BtnExitNintendo = new System.Windows.Forms.PictureBox();
            this.lblQtdCarrinho = new System.Windows.Forms.Label();
            this.lblNItens = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJogosNintendo)).BeginInit();
            this.GrbCarrinhoNintendo.SuspendLayout();
            this.GrbCategoriaNintendo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNintendoIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExitNintendo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvJogosNintendo
            // 
            this.DgvJogosNintendo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvJogosNintendo.BackgroundColor = System.Drawing.Color.Black;
            this.DgvJogosNintendo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJogosNintendo.Location = new System.Drawing.Point(58, 73);
            this.DgvJogosNintendo.Name = "DgvJogosNintendo";
            this.DgvJogosNintendo.Size = new System.Drawing.Size(390, 304);
            this.DgvJogosNintendo.TabIndex = 19;
            this.DgvJogosNintendo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvJogosNintendo_CellClick);
            // 
            // GrbCarrinhoNintendo
            // 
            this.GrbCarrinhoNintendo.Controls.Add(this.BtnAdicionarCarrinho);
            this.GrbCarrinhoNintendo.Controls.Add(this.BtnPagarNintendo);
            this.GrbCarrinhoNintendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCarrinhoNintendo.ForeColor = System.Drawing.Color.Red;
            this.GrbCarrinhoNintendo.Location = new System.Drawing.Point(58, 455);
            this.GrbCarrinhoNintendo.Name = "GrbCarrinhoNintendo";
            this.GrbCarrinhoNintendo.Size = new System.Drawing.Size(390, 143);
            this.GrbCarrinhoNintendo.TabIndex = 21;
            this.GrbCarrinhoNintendo.TabStop = false;
            this.GrbCarrinhoNintendo.Text = "Adicionar ao carrinho e pagar";
            // 
            // BtnAdicionarCarrinho
            // 
            this.BtnAdicionarCarrinho.BackColor = System.Drawing.Color.Red;
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
            // BtnPagarNintendo
            // 
            this.BtnPagarNintendo.BackColor = System.Drawing.Color.Red;
            this.BtnPagarNintendo.Enabled = false;
            this.BtnPagarNintendo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagarNintendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagarNintendo.ForeColor = System.Drawing.Color.White;
            this.BtnPagarNintendo.Location = new System.Drawing.Point(7, 80);
            this.BtnPagarNintendo.Name = "BtnPagarNintendo";
            this.BtnPagarNintendo.Size = new System.Drawing.Size(377, 51);
            this.BtnPagarNintendo.TabIndex = 0;
            this.BtnPagarNintendo.Text = "Pagar";
            this.BtnPagarNintendo.UseVisualStyleBackColor = false;
            this.BtnPagarNintendo.Click += new System.EventHandler(this.BtnPagarNintendo_Click);
            // 
            // GrbCategoriaNintendo
            // 
            this.GrbCategoriaNintendo.Controls.Add(this.CmbCategoriaNintendo);
            this.GrbCategoriaNintendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCategoriaNintendo.ForeColor = System.Drawing.Color.Red;
            this.GrbCategoriaNintendo.Location = new System.Drawing.Point(58, 383);
            this.GrbCategoriaNintendo.Name = "GrbCategoriaNintendo";
            this.GrbCategoriaNintendo.Size = new System.Drawing.Size(390, 66);
            this.GrbCategoriaNintendo.TabIndex = 20;
            this.GrbCategoriaNintendo.TabStop = false;
            this.GrbCategoriaNintendo.Text = "Selecione a categoria";
            // 
            // CmbCategoriaNintendo
            // 
            this.CmbCategoriaNintendo.FormattingEnabled = true;
            this.CmbCategoriaNintendo.Location = new System.Drawing.Point(6, 23);
            this.CmbCategoriaNintendo.Name = "CmbCategoriaNintendo";
            this.CmbCategoriaNintendo.Size = new System.Drawing.Size(377, 26);
            this.CmbCategoriaNintendo.TabIndex = 0;
            this.CmbCategoriaNintendo.SelectedIndexChanged += new System.EventHandler(this.CmbCategoriaNintendo_SelectedIndexChanged);
            // 
            // BtnNintendoIcon
            // 
            this.BtnNintendoIcon.Image = global::TROCGames.Properties.Resources.nintendo_logo_1_1__1_;
            this.BtnNintendoIcon.Location = new System.Drawing.Point(141, -16);
            this.BtnNintendoIcon.Name = "BtnNintendoIcon";
            this.BtnNintendoIcon.Size = new System.Drawing.Size(203, 104);
            this.BtnNintendoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnNintendoIcon.TabIndex = 23;
            this.BtnNintendoIcon.TabStop = false;
            // 
            // BtnExitNintendo
            // 
            this.BtnExitNintendo.Image = global::TROCGames.Properties.Resources.Prancheta_15;
            this.BtnExitNintendo.Location = new System.Drawing.Point(437, -7);
            this.BtnExitNintendo.Name = "BtnExitNintendo";
            this.BtnExitNintendo.Size = new System.Drawing.Size(82, 86);
            this.BtnExitNintendo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnExitNintendo.TabIndex = 18;
            this.BtnExitNintendo.TabStop = false;
            this.BtnExitNintendo.Click += new System.EventHandler(this.BtnExitNintendo_Click);
            // 
            // lblQtdCarrinho
            // 
            this.lblQtdCarrinho.AutoSize = true;
            this.lblQtdCarrinho.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQtdCarrinho.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdCarrinho.ForeColor = System.Drawing.Color.Red;
            this.lblQtdCarrinho.Location = new System.Drawing.Point(442, 606);
            this.lblQtdCarrinho.Name = "lblQtdCarrinho";
            this.lblQtdCarrinho.Size = new System.Drawing.Size(21, 23);
            this.lblQtdCarrinho.TabIndex = 25;
            this.lblQtdCarrinho.Text = "0";
            // 
            // lblNItens
            // 
            this.lblNItens.AutoSize = true;
            this.lblNItens.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNItens.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNItens.ForeColor = System.Drawing.Color.Red;
            this.lblNItens.Location = new System.Drawing.Point(232, 606);
            this.lblNItens.Name = "lblNItens";
            this.lblNItens.Size = new System.Drawing.Size(210, 23);
            this.lblNItens.TabIndex = 24;
            this.lblNItens.Text = "Produtos no Carrinho:";
            // 
            // Nintendo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(507, 638);
            this.Controls.Add(this.lblQtdCarrinho);
            this.Controls.Add(this.lblNItens);
            this.Controls.Add(this.DgvJogosNintendo);
            this.Controls.Add(this.BtnNintendoIcon);
            this.Controls.Add(this.GrbCarrinhoNintendo);
            this.Controls.Add(this.GrbCategoriaNintendo);
            this.Controls.Add(this.BtnExitNintendo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nintendo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nintendo";
            ((System.ComponentModel.ISupportInitialize)(this.DgvJogosNintendo)).EndInit();
            this.GrbCarrinhoNintendo.ResumeLayout(false);
            this.GrbCategoriaNintendo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnNintendoIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExitNintendo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvJogosNintendo;
        private System.Windows.Forms.PictureBox BtnNintendoIcon;
        private System.Windows.Forms.GroupBox GrbCarrinhoNintendo;
        private System.Windows.Forms.Button BtnPagarNintendo;
        private System.Windows.Forms.GroupBox GrbCategoriaNintendo;
        private System.Windows.Forms.ComboBox CmbCategoriaNintendo;
        private System.Windows.Forms.PictureBox BtnExitNintendo;
        private System.Windows.Forms.Button BtnAdicionarCarrinho;
        private System.Windows.Forms.Label lblQtdCarrinho;
        private System.Windows.Forms.Label lblNItens;
    }
}