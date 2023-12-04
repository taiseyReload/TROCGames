namespace TROCGames.Views
{
    partial class Pagamento
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
            this.DgvListaCarrinho = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.LblTituloCarrinho = new System.Windows.Forms.Label();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.ChbPagamento = new System.Windows.Forms.CheckBox();
            this.LblValorTotal = new System.Windows.Forms.Label();
            this.GrbPagamento = new System.Windows.Forms.GroupBox();
            this.PbIconPagamento = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCarrinho)).BeginInit();
            this.GrbPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbIconPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListaCarrinho
            // 
            this.DgvListaCarrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListaCarrinho.BackgroundColor = System.Drawing.Color.Black;
            this.DgvListaCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaCarrinho.Location = new System.Drawing.Point(39, 123);
            this.DgvListaCarrinho.Name = "DgvListaCarrinho";
            this.DgvListaCarrinho.Size = new System.Drawing.Size(455, 304);
            this.DgvListaCarrinho.TabIndex = 2;
            this.DgvListaCarrinho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaCarrinho_CellClick);
            this.DgvListaCarrinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaCarrinho_CellContentClick);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(217, 24);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(203, 35);
            this.BtnExcluir.TabIndex = 9;
            this.BtnExcluir.Text = "Excluir produto";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // LblTituloCarrinho
            // 
            this.LblTituloCarrinho.AutoSize = true;
            this.LblTituloCarrinho.BackColor = System.Drawing.Color.Black;
            this.LblTituloCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloCarrinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblTituloCarrinho.Location = new System.Drawing.Point(149, 78);
            this.LblTituloCarrinho.Name = "LblTituloCarrinho";
            this.LblTituloCarrinho.Size = new System.Drawing.Size(224, 42);
            this.LblTituloCarrinho.TabIndex = 10;
            this.LblTituloCarrinho.Text = "CARRINHO";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnConfirmar.Enabled = false;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.Location = new System.Drawing.Point(217, 69);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(203, 44);
            this.BtnConfirmar.TabIndex = 13;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // ChbPagamento
            // 
            this.ChbPagamento.AutoSize = true;
            this.ChbPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ChbPagamento.Location = new System.Drawing.Point(217, 119);
            this.ChbPagamento.Name = "ChbPagamento";
            this.ChbPagamento.Size = new System.Drawing.Size(204, 22);
            this.ChbPagamento.TabIndex = 12;
            this.ChbPagamento.Text = "PAGAMENTO RECEBIDO";
            this.ChbPagamento.UseVisualStyleBackColor = true;
            this.ChbPagamento.CheckedChanged += new System.EventHandler(this.ChbPagamento_CheckedChanged);
            // 
            // LblValorTotal
            // 
            this.LblValorTotal.AutoSize = true;
            this.LblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblValorTotal.Location = new System.Drawing.Point(6, 59);
            this.LblValorTotal.Name = "LblValorTotal";
            this.LblValorTotal.Size = new System.Drawing.Size(116, 31);
            this.LblValorTotal.TabIndex = 11;
            this.LblValorTotal.Text = "R$ 00,0";
            this.LblValorTotal.Click += new System.EventHandler(this.LblValorTotal_Click);
            // 
            // GrbPagamento
            // 
            this.GrbPagamento.Controls.Add(this.BtnConfirmar);
            this.GrbPagamento.Controls.Add(this.ChbPagamento);
            this.GrbPagamento.Controls.Add(this.LblValorTotal);
            this.GrbPagamento.Controls.Add(this.BtnExcluir);
            this.GrbPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbPagamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrbPagamento.Location = new System.Drawing.Point(39, 443);
            this.GrbPagamento.Name = "GrbPagamento";
            this.GrbPagamento.Size = new System.Drawing.Size(455, 156);
            this.GrbPagamento.TabIndex = 14;
            this.GrbPagamento.TabStop = false;
            this.GrbPagamento.Text = "PAGAMENTO";
            // 
            // PbIconPagamento
            // 
            this.PbIconPagamento.Image = global::TROCGames.Properties.Resources.Prancheta_1__7_;
            this.PbIconPagamento.Location = new System.Drawing.Point(173, -1);
            this.PbIconPagamento.Name = "PbIconPagamento";
            this.PbIconPagamento.Size = new System.Drawing.Size(163, 88);
            this.PbIconPagamento.TabIndex = 17;
            this.PbIconPagamento.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.Image = global::TROCGames.Properties.Resources.Prancheta_16;
            this.BtnExit.Location = new System.Drawing.Point(464, -1);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(77, 88);
            this.BtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnExit.TabIndex = 16;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(541, 638);
            this.Controls.Add(this.LblTituloCarrinho);
            this.Controls.Add(this.PbIconPagamento);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.GrbPagamento);
            this.Controls.Add(this.DgvListaCarrinho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCarrinho)).EndInit();
            this.GrbPagamento.ResumeLayout(false);
            this.GrbPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbIconPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaCarrinho;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Label LblTituloCarrinho;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.CheckBox ChbPagamento;
        private System.Windows.Forms.Label LblValorTotal;
        private System.Windows.Forms.GroupBox GrbPagamento;
        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.PictureBox PbIconPagamento;
    }
}