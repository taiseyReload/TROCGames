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
using static System.Windows.Forms.LinkLabel;

namespace TROCGames.View
{
    public partial class Playstation : Form
    {
        // Atributos globais:
        int idSelecionado = 0;
        int contador = 0;
        int idFicha = 0;
        Classes.Produto produto = new Classes.Produto();
        Classes.Categoria categoria = new Classes.Categoria();
        Classes.Carrinho carrinho = new Classes.Carrinho();
        public Playstation()
        {
            InitializeComponent();           
            var r = categoria.ListarTudo();
            // Preencher o DGV com as informações do banco:
            foreach (DataRow linha in r.Rows)
            {
                CmbCategoriaPlaystation.Items.Add(linha.ItemArray[0].ToString() + " - " + 
                    linha.ItemArray[1].ToString()); ;

            }
            DgvJogosPlaystation.DataSource = produto.ListarPlaystation();

            // Gerar a ficha do usuário a partir do último id inserido:
            var f = carrinho.UltimaFicha().Rows[0][0];
            idFicha = int.Parse(f.ToString());
        }

        private void BtnExitPlaystation_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Playstation_Load(object sender, EventArgs e)
        {

        }

        private void BtnPagarPlaystation_Click(object sender, EventArgs e)
        {
            Views.Pagamento janela = new Views.Pagamento();
            janela.Show();
        }

        private void DgvJogosPlaystation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void DgvJogosPlaystation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Carrinho carrinho = new Classes.Carrinho();
            // Inverter o Enabled:
            BtnAdicionarCarrinho.Enabled = true;

            // Obter a linha clicada:
            int linhaSelecionada = DgvJogosPlaystation.CurrentCell.RowIndex;

            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = DgvJogosPlaystation.Rows[linhaSelecionada];

            // Salvar o id do usuário na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void CmCategoriaPlaystation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Listar de acordo com a opção selecionada pelo usuário:
            Classes.Produto produto = new Classes.Produto();
            if (CmbCategoriaPlaystation.Text == "1 - Consoles")
            {
                DgvJogosPlaystation.DataSource = produto.ListarConsolesPlaystation();
            }
            else if (CmbCategoriaPlaystation.Text == "2 - Jogos")
            {
                DgvJogosPlaystation.DataSource = produto.ListarJogosPlaystation();
            }
            else if(CmbCategoriaPlaystation.Text == "3 - Acessórios")
            {
                DgvJogosPlaystation.DataSource = produto.ListarAcessoriosPlaystation();
            }
            else
            {
                DgvJogosPlaystation.DataSource = produto.ListarPlaystation();
            }
        }

        private void lblQtdCarrinho_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            Classes.Carrinho carrinho = new Classes.Carrinho();
            // Adicionar produtos no contador do carrinho:
            BtnAdicionarCarrinho.Enabled = false;
            contador++;
            // Obter a linha clicada:
            int linhaSelecionada = DgvJogosPlaystation.CurrentCell.RowIndex;
            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = DgvJogosPlaystation.Rows[linhaSelecionada];
            // Obter os valores dos campos:
            carrinho.IdFicha = idFicha;
            carrinho.Quantidade = 1;
            carrinho.IdProdutos = (int)linha.Cells[0].Value;
            carrinho.AdicionarProduto();
            // Permitir clicar no carinho apenas se o contador estiver com pelo menos 1 produto:
            if (contador > 0)
            {
                BtnPagarPlaystation.Enabled = true;
            }
            lblQtdCarrinho.Text = contador.ToString();

        }
    }
}
