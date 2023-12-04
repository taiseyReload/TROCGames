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
    public partial class Nintendo : Form
    {
        // Atributos globais:
        int idSelecionado = 0;
        int idFicha = 0;
        int totalCarrinho = Globals.qtdCarrinho;
        Classes.Produto produto = new Classes.Produto();
        Classes.Carrinho carrinho = new Classes.Carrinho();
        Classes.Categoria categoria = new Classes.Categoria();
        public Nintendo()
        {
            InitializeComponent();
            var r = categoria.ListarTudo();
            // Preencher o DGV com as informações do banco:
            foreach (DataRow linha in r.Rows)
            {
                CmbCategoriaNintendo.Items.Add(linha.ItemArray[0].ToString() + " - " +
                    linha.ItemArray[1].ToString()); ;

            }
            DgvJogosNintendo.DataSource = produto.ListarNintendo();
            idFicha = Globals.idGlobal;
            
        }

        private void BtnExitNintendo_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void BtnPagarNintendo_Click(object sender, EventArgs e)
        {
            Views.Pagamento janela = new Views.Pagamento();
            janela.Show();
        }

        private void BtnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            Classes.Carrinho carrinho = new Classes.Carrinho();
            // Adicionar produtos no contador do carrinho:
            BtnAdicionarCarrinho.Enabled = false;
            Globals.qtdCarrinho++;
            // Obter a linha clicada:
            int linhaSelecionada = DgvJogosNintendo.CurrentCell.RowIndex;
            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = DgvJogosNintendo.Rows[linhaSelecionada];
            // Obter os valores dos campos:
            carrinho.IdFicha = idFicha;
            carrinho.Quantidade = 1;
            carrinho.IdProdutos = (int)linha.Cells[0].Value;
            carrinho.AdicionarProduto();
            // Permitir clicar no carinho apenas se o contador estiver com pelo menos 1 produto:
            if (Globals.qtdCarrinho > 0)
            {
                BtnPagarNintendo.Enabled = true;
            }
            lblQtdCarrinho.Text = Globals.qtdCarrinho.ToString();

        }

        private void DgvJogosNintendo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Carrinho carrinho = new Classes.Carrinho();
            // Inverter o Enabled:
            BtnAdicionarCarrinho.Enabled = true;

            // Obter a linha clicada:
            int linhaSelecionada = DgvJogosNintendo.CurrentCell.RowIndex;

            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = DgvJogosNintendo.Rows[linhaSelecionada];

            // Salvar o id do usuário na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void CmbCategoriaNintendo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Listar de acordo com a opção selecionada pelo usuário:
            Classes.Produto produto = new Classes.Produto();
            if (CmbCategoriaNintendo.Text == "1 - Consoles")
            {
                DgvJogosNintendo.DataSource = produto.ListarConsolesNintendo();
            }
            else if (CmbCategoriaNintendo.Text == "2 - Jogos")
            {
                DgvJogosNintendo.DataSource = produto.ListarJogosNintendo();
            }
            else if (CmbCategoriaNintendo.Text == "3 - Acessórios")
            {
                DgvJogosNintendo.DataSource = produto.ListarAcessoriosNintendo();
            }
            else
            {
                DgvJogosNintendo.DataSource = produto.ListarNintendo();
            }
        }

        private void btnIrCarrinho_Click(object sender, EventArgs e)
        {
            Views.Pagamento janela = new Views.Pagamento();
            janela.Show();
        }

        private void Nintendo_Activated(object sender, EventArgs e)
        {
            lblQtdCarrinho.Text = Globals.qtdCarrinho.ToString();
        }
    }
}
