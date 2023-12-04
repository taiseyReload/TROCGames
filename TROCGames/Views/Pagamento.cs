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
        // Atributos globais:
        Classes.Carrinho carrinho = new Classes.Carrinho();
        int idSelecionado = 0;
        int idFicha;
        public Pagamento()
        {
            InitializeComponent();
            Classes.Carrinho carrinho = new Classes.Carrinho();
            carrinho.IdFicha = Globals.idGlobal;
            DgvListaCarrinho.DataSource = carrinho.ListarCarrinhoID_Ficha();         
            
            var r = carrinho.ListarCarrinho();
            // Mostrar o valor total:
            LblValorTotal.Text = "R$" + r.Compute("SUM(preco)", "True").ToString();           

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Classes.Carrinho carrinho = new Classes.Carrinho();
            // Confirmar se o usuário deseja remover o produto:
            var n = MessageBox.Show("Tem certeza que deseja remover o produto?", "Aviso!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (n == DialogResult.Yes)
            {
                carrinho.Id = idSelecionado;
                carrinho.ExcluirProduto();
                // Atualizar dgv:
                DgvListaCarrinho.DataSource = carrinho.ListarCarrinho();
                var r = carrinho.ListarCarrinho();
                // Atualizar o valor total:
                LblValorTotal.Text = "R$" + r.Compute("SUM(preco)", "True").ToString();
                Globals.qtdCarrinho--;
            }
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

        private void LblValorTotal_Click(object sender, EventArgs e)
        {

        }

        private void ChbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            // Ativar/desativar o botão de confirmar de acordo com o Checked:
            BtnConfirmar.Enabled = ChbPagamento.Checked;
        }

        private void btnIrCarrinho_Click(object sender, EventArgs e)
        {
            Views.Pagamento janela = new Views.Pagamento();
            janela.Show();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            // Confirmar se o usuário deseja finalizar a compra:
            var r = MessageBox.Show("Tem certeza que deseja confirmar o pagamento?", "Aviso!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                MessageBox.Show("Pagamento efetuado!", "Sucesso!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Globals.qtdCarrinho = 0;
                carrinho.FecharCompra();
                Close();
                
            }
        }

        private void DgvListaCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
