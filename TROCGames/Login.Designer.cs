namespace TROCGames
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GbEscolha = new System.Windows.Forms.GroupBox();
            this.BtnNintendo = new System.Windows.Forms.PictureBox();
            this.BtnXbox = new System.Windows.Forms.PictureBox();
            this.BtnPlaystation = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GbEscolha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNintendo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnXbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlaystation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GbEscolha
            // 
            this.GbEscolha.Controls.Add(this.BtnNintendo);
            this.GbEscolha.Controls.Add(this.BtnXbox);
            this.GbEscolha.Controls.Add(this.BtnPlaystation);
            this.GbEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEscolha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GbEscolha.Location = new System.Drawing.Point(62, 126);
            this.GbEscolha.Name = "GbEscolha";
            this.GbEscolha.Size = new System.Drawing.Size(304, 254);
            this.GbEscolha.TabIndex = 11;
            this.GbEscolha.TabStop = false;
            this.GbEscolha.Text = "Qual plataforma você deseja?";
            // 
            // BtnNintendo
            // 
            this.BtnNintendo.Image = global::TROCGames.Properties.Resources.nintendo_logo_1_1__1_;
            this.BtnNintendo.Location = new System.Drawing.Point(69, 180);
            this.BtnNintendo.Name = "BtnNintendo";
            this.BtnNintendo.Size = new System.Drawing.Size(187, 42);
            this.BtnNintendo.TabIndex = 8;
            this.BtnNintendo.TabStop = false;
            this.BtnNintendo.Click += new System.EventHandler(this.BtnNintendo_Click);
            // 
            // BtnXbox
            // 
            this.BtnXbox.Image = global::TROCGames.Properties.Resources.Prancheta_2;
            this.BtnXbox.Location = new System.Drawing.Point(146, 25);
            this.BtnXbox.Name = "BtnXbox";
            this.BtnXbox.Size = new System.Drawing.Size(136, 182);
            this.BtnXbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnXbox.TabIndex = 6;
            this.BtnXbox.TabStop = false;
            this.BtnXbox.Click += new System.EventHandler(this.BtnXbox_Click);
            // 
            // BtnPlaystation
            // 
            this.BtnPlaystation.Image = global::TROCGames.Properties.Resources.Prancheta_12;
            this.BtnPlaystation.Location = new System.Drawing.Point(6, 42);
            this.BtnPlaystation.Name = "BtnPlaystation";
            this.BtnPlaystation.Size = new System.Drawing.Size(174, 146);
            this.BtnPlaystation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnPlaystation.TabIndex = 10;
            this.BtnPlaystation.TabStop = false;
            this.BtnPlaystation.Click += new System.EventHandler(this.BtnPlaystation_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblTitulo.Location = new System.Drawing.Point(124, 86);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(174, 37);
            this.LblTitulo.TabIndex = 12;
            this.LblTitulo.Text = "Bem Vindo";
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Image = global::TROCGames.Properties.Resources.Prancheta_16;
            this.BtnExit.Location = new System.Drawing.Point(345, -5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(94, 108);
            this.BtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnExit.TabIndex = 15;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TROCGames.Properties.Resources.Prancheta_1__7_;
            this.pictureBox2.Location = new System.Drawing.Point(127, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 88);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(433, 441);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.GbEscolha);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.GbEscolha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnNintendo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnXbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlaystation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox BtnXbox;
        private System.Windows.Forms.PictureBox BtnNintendo;
        private System.Windows.Forms.PictureBox BtnPlaystation;
        private System.Windows.Forms.GroupBox GbEscolha;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox BtnExit;
    }
}

