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
using TROCGames.Views;

namespace TROCGames
{
    public partial class Login : Form
    {
        // Atributos globais:
        Classes.Carrinho carrinho = new Classes.Carrinho();
        int idFicha;
        public Login(int id)
        {
            InitializeComponent();
            // Verificar se o usuário deseja recuperar o ID de um carrinho antigo ou criar um novo:
           if (id == 0) 
            { 
            var f = carrinho.UltimaFicha().Rows[0][0];
            idFicha = int.Parse(f.ToString());
            Globals.idGlobal = idFicha;
            lblNId.Text = Globals.idGlobal.ToString();
            }
           else
            {
                Globals.idGlobal = id;
                lblNId.Text = Globals.idGlobal.ToString();
                idFicha = id;
            }

        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPlaystation_Click(object sender, EventArgs e)
        {
            View.Playstation janela = new View.Playstation();
            janela.Show();
        }

        private void BtnXbox_Click(object sender, EventArgs e)
        {
            Views.Xbox janela = new Views.Xbox();
                janela.Show();
        }

        private void BtnNintendo_Click(object sender, EventArgs e)
        {
            Views.Nintendo janela = new Views.Nintendo();
            janela.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnIrCarrinho_Click(object sender, EventArgs e)
        {
            Views.Pagamento janela = new Views.Pagamento();
            janela.Show();
        }
    }
}
