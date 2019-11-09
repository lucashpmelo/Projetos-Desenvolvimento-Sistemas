using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetTipadoProject.Forms
{
    public partial class FormNotasDeEntrada : Form
    {
        public FormNotasDeEntrada()
        {
            InitializeComponent();
        }

        private void notasDeEntradaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notasDeEntradaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);

        }

        private void FormNotasDeEntrada_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dSEstadosECidades.ProdutosNotaDeEntrada'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosNotaDeEntradaTableAdapter.Fill(this.dSEstadosECidades.ProdutosNotaDeEntrada);
            // TODO: esta linha de código carrega dados na tabela 'dSEstadosECidades.ProdutosNotaDeEntrada'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosNotaDeEntradaTableAdapter.Fill(this.dSEstadosECidades.ProdutosNotaDeEntrada);
            // TODO: esta linha de código carrega dados na tabela 'dSEstadosECidades.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.dSEstadosECidades.Fornecedores);
            // TODO: esta linha de código carrega dados na tabela 'dSEstadosECidades.NotasDeEntrada'. Você pode movê-la ou removê-la conforme necessário.
            this.notasDeEntradaTableAdapter.Fill(this.dSEstadosECidades.NotasDeEntrada);

            ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).DataSource = this.dSEstadosECidades.Produtos;
            ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).DisplayMember = this.dSEstadosECidades.Produtos.descricaoColumn.ColumnName;
            ((DataGridViewComboBoxColumn)dgvProdutos.Columns[0]).ValueMember = this.dSEstadosECidades.Produtos.idprodutoColumn.ColumnName;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.notasDeEntradaTableAdapter.FillBy(this.dSEstadosECidades.NotasDeEntrada);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
