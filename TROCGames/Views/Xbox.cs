using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TROCGames.Views
{
    public partial class Xbox : Form
    {
        // Atributos globais:
        int idSelecionado = 0;
        int contador = 0;
        int idFicha = 0;
        Classes.Produto produto = new Classes.Produto();
        Classes.Carrinho carrinho = new Classes.Carrinho();
        Classes.Categoria categoria = new Classes.Categoria();
        public Xbox()
        {
            InitializeComponent();
            var r = categoria.ListarTudo();
            // Preencher o DGV com as informações do banco:
            foreach (DataRow linha in r.Rows)
            {
                CmbCategoriaXbox.Items.Add(linha.ItemArray[0].ToString() + " - " +
                    linha.ItemArray[1].ToString()); ;

            }
            DgvJogosXbox.DataSource = produto.ListarXbox();

            // Gerar a ficha do usuário a partir do último id inserido:
            var f = carrinho.UltimaFicha().Rows[0][0];
            idFicha = int.Parse(f.ToString());
        }

        private void Xbox_Load(object sender, EventArgs e)
        {

        }

        private void BtnExitXbox_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void BtnPagarXbox_Click(object sender, EventArgs e)
        {
            Views.Pagamento janela = new Views.Pagamento();
            janela.Show();
        }

        private void CmbCategoriaXbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Listar de acordo com a opção selecionada pelo usuário:
            Classes.Produto produto = new Classes.Produto();
            if (CmbCategoriaXbox.Text == "1 - Consoles")
            {
                DgvJogosXbox.DataSource = produto.ListarConsolesXbox();
            }
            else if (CmbCategoriaXbox.Text == "2 - Jogos")
            {
                DgvJogosXbox.DataSource = produto.ListarJogosXbox();
            }
            else if (CmbCategoriaXbox.Text == "3 - Acessórios")
            {
                DgvJogosXbox.DataSource = produto.ListarAcessoriosXbox();
            }
            else
            {
                DgvJogosXbox.DataSource = produto.ListarXbox();
            }
        }

        private void BtnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            Classes.Carrinho carrinho = new Classes.Carrinho();
            // Adicionar produtos no contador do carrinho:
            BtnAdicionarCarrinho.Enabled = false;
            contador++;
            // Obter a linha clicada:
            int linhaSelecionada = DgvJogosXbox.CurrentCell.RowIndex;
            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = DgvJogosXbox.Rows[linhaSelecionada];
            // Obter os valores dos campos:
            carrinho.IdFicha = idFicha;
            carrinho.Quantidade = 1;
            carrinho.IdProdutos = (int)linha.Cells[0].Value;
            carrinho.AdicionarProduto();
            // Permitir clicar no carinho apenas se o contador estiver com pelo menos 1 produto:
            if (contador > 0)
            {
                BtnPagarXbox.Enabled = true;
            }
            lblQtdCarrinho.Text = contador.ToString();
        }

        private void DgvJogosXbox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Carrinho carrinho = new Classes.Carrinho();
            // Inverter o Enabled:
            BtnAdicionarCarrinho.Enabled = true;

            // Obter a linha clicada:
            int linhaSelecionada = DgvJogosXbox.CurrentCell.RowIndex;

            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = DgvJogosXbox.Rows[linhaSelecionada];

            // Salvar o id do usuário na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }
    }
}
