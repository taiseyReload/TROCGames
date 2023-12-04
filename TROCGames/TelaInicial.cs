using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TROCGames.Classes;

namespace TROCGames
{
    public partial class TelaInicial : Form
    {
        Classes.Carrinho carrinho = new Classes.Carrinho();

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void TelaInicial_Activated(object sender, EventArgs e)
        {

        }

        private void btnCriarNovoCarrinho_Click(object sender, EventArgs e)
        {
            
            Login janela = new Login(0);
            janela.Show();
        }

        private void btnRecuperarCarrinho_Click(object sender, EventArgs e)
        {
            
            
            Login janela = new Login(int.Parse(txbIdCarrinho.Text));
            janela.Show();
        }
    }
}
