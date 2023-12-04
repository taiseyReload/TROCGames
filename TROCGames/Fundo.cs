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
    public partial class Fundo : Form
    {
        public Fundo()
        {
            InitializeComponent();
        }
        private void Fundo_Activated(object sender, EventArgs e)
        {
            //INSTANCIAR A JANELA DE LOGIN
            TelaInicial janela = new TelaInicial();
            //MOSTRAR JANELA 
            janela.ShowDialog();
            //FECHAR TUDO AO FECHAR A LOGIN
            Application.Exit();
        }

        private void Fundo_Load(object sender, EventArgs e)
        {

        }
    }
}
