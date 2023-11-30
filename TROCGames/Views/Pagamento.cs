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

namespace TROCGames.Views
{
    public partial class Pagamento : Form
    {
        Classes.Carrinho carrinho = new Classes.Carrinho();
        int idSelecionado = 0;
        public Pagamento()
        {
            InitializeComponent();
            DgvListaCarrinho.DataSource = carrinho.ListarCarrinho();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Classes.Carrinho carrinho = new Classes.Carrinho();
            carrinho.Id = idSelecionado;
            carrinho.ExcluirProduto();
            //atualizar dgv:
            DgvListaCarrinho.DataSource = carrinho.ListarCarrinho();
           
        }

        private void DgvListaCarrinho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnExcluir.Enabled = true;

            // Obter a linha clicada:
            int linhaSelecionada = DgvListaCarrinho.CurrentCell.RowIndex;

            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = DgvListaCarrinho.Rows[linhaSelecionada];

            // Salvar o id do usuário na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;

            

        }
    }
}
