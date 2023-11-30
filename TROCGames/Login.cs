using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TROCGames
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
    }
}
