using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoDeVendas.View
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            /*ClienteView cli = new ClienteView();
            Hide();
            cli.Show();*/

            this.Hide();
            Form cli = new ClienteView();
            cli.Closed += (s, args) => this.Close();
            cli.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            /*FuncionarioView fun = new FuncionarioView();
            Hide();
            fun.Show();*/

            this.Hide();
            Form fun = new FuncionarioView();
            fun.Closed += (s, args) => this.Close();
            fun.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            /*ProdutoView pro = new ProdutoView();
            Hide();
            pro.Show();*/

            this.Hide();
            Form pro = new ProdutoView();
            pro.Closed += (s, args) => this.Close();
            pro.Show();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            /*VendaView ven = new VendaView();
            Hide();
            ven.Show();*/

            this.Hide();
            Form ven = new VendaView();
            ven.Closed += (s, args) => this.Close();
            ven.Show();
        }
    }
}
