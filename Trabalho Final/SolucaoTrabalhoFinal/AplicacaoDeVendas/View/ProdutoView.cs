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
    public partial class ProdutoView : Form
    {
        public ProdutoView()
        {
            InitializeComponent();
        }

        private void tB_PRODUTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {            
            try
            {
                this.Validate();
                this.tB_PRODUTOBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDProjetoFinalDataSet);
                txtProduto.Enabled = false;
                txtQuantidade.Enabled = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ProdutoView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDProjetoFinalDataSet.TB_PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_PRODUTOTableAdapter.Fill(this.bDProjetoFinalDataSet.TB_PRODUTO);

        }

        private void pesquisarProdutoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tB_PRODUTOTableAdapter.PesquisarProduto(this.bDProjetoFinalDataSet.TB_PRODUTO, pesquisarProdutoToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void habilitarEdicao(object sender, EventArgs e)
        {
            txtProduto.Enabled = true;
            txtQuantidade.Enabled = true;
        }

        private void pesquisarProdutoToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.tB_PRODUTOTableAdapter.PesquisarProduto(this.bDProjetoFinalDataSet.TB_PRODUTO, pesquisarProdutoToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //this.tB_PRODUTOTableAdapter.UpdateQuery(3, 1, 1);
                //this.tB_PRODUTOTableAdapter.Fill(this.bDProjetoFinalDataSet.TB_PRODUTO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form men = new MenuView();
            men.Closed += (s, args) => this.Close();
            men.Show();
        }
    }
}
