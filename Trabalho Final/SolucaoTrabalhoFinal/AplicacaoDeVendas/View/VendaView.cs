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
    public partial class VendaView : Form
    {
        public VendaView()
        {
            InitializeComponent();
        }

        private void tB_VENDABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {            
            try
            {
                this.Validate();
                this.tB_VENDABindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDProjetoFinalDataSet);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void VendaView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDProjetoFinalDataSet.TB_CARRINHO'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_CARRINHOTableAdapter.Fill(this.bDProjetoFinalDataSet.TB_CARRINHO);
            // TODO: esta linha de código carrega dados na tabela 'bDProjetoFinalDataSet.TB_PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_PRODUTOTableAdapter.Fill(this.bDProjetoFinalDataSet.TB_PRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'bDProjetoFinalDataSet1.TB_CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_CLIENTETableAdapter.Fill(this.bDProjetoFinalDataSet1.TB_CLIENTE);
            // TODO: esta linha de código carrega dados na tabela 'bDProjetoFinalDataSet.TB_PRODUTOVENDA'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_PRODUTOVENDATableAdapter.Fill(this.bDProjetoFinalDataSet.TB_PRODUTOVENDA);
            // TODO: esta linha de código carrega dados na tabela 'bDProjetoFinalDataSet.TB_FUNCIONARIO'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_FUNCIONARIOTableAdapter.Fill(this.bDProjetoFinalDataSet.TB_FUNCIONARIO);
            // TODO: esta linha de código carrega dados na tabela 'bDProjetoFinalDataSet.TB_CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_CLIENTETableAdapter.Fill(this.bDProjetoFinalDataSet.TB_CLIENTE);
            // TODO: esta linha de código carrega dados na tabela 'bDProjetoFinalDataSet.TB_VENDA'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_VENDATableAdapter.Fill(this.bDProjetoFinalDataSet.TB_VENDA);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.tB_VENDATableAdapter.FillBy(this.bDProjetoFinalDataSet.TB_VENDA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByProdutoVendaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tB_PRODUTOVENDATableAdapter.FillByProdutoVenda(this.bDProjetoFinalDataSet.TB_PRODUTOVENDA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tB_PRODUTOVENDATableAdapter.Fill(this.bDProjetoFinalDataSet.TB_PRODUTOVENDA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tB_VENDATableAdapter.Fill(this.bDProjetoFinalDataSet.TB_VENDA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tB_VENDATableAdapter.Fill(this.bDProjetoFinalDataSet.TB_VENDA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pesquisarNomeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tB_CLIENTETableAdapter.PesquisarNome(this.bDProjetoFinalDataSet.TB_CLIENTE, pesquisarNomeToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }        

        private void cLI_NOMETextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvCliente.Visible = true;
            dgvFuncionario.Visible = false;
        }

        private void pesquisarNomeToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tB_FUNCIONARIOTableAdapter.PesquisarNome(this.bDProjetoFinalDataSet.TB_FUNCIONARIO, pesquisarNomeToolStripTextBox1.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                txtControleEstoque.Visible = true;
                if (Convert.ToInt32(txtQuantidade.Text) > Convert.ToInt32(txtControleEstoque.Text))
                {
                    txtControleEstoque.Visible = false;
                    System.Windows.Forms.MessageBox.Show("Quantidade maior que o estoque");
                    return;
                }
                else
                {
                    dgvCarrinho.Visible = true;
                    txtControleEstoque.Visible = false;

                    txtCodProduto.Visible = true;
                    this.tB_CARRINHOTableAdapter.addProduto(Convert.ToInt32(txtCodProduto.Text), txtControleNomeProduto.Text, Convert.ToInt32(txtQuantidade.Text), Convert.ToDouble(txtValor.Text));
                    txtCodProduto.Visible = false;
                    txtQuantidade.Text = "";
                    txtValor.Text = "";
                    txtNomeProduto.Text = "";
                    this.tB_CARRINHOTableAdapter.Fill(this.bDProjetoFinalDataSet.TB_CARRINHO);
                }                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {            

            try
            {
                if (txtCliente.Text == "" || txtFuncionario.Text == "")
                {
                    System.Windows.Forms.MessageBox.Show("Nome do Cliente ou do Funcionario não pode ser nulo!");
                    return;
                }
                else
                {
                    txtCodCliente.Visible = true;
                    txtCodFuncionario.Visible = true;
                    this.tB_VENDATableAdapter.addVenda(txtDataVenda.Text, Convert.ToInt32(txtCodCliente.Text), Convert.ToInt32(txtCodFuncionario.Text));
                    txtCodCliente.Visible = false;
                    txtCodFuncionario.Visible = false;
                    this.tB_PRODUTOVENDATableAdapter.addItensDoCarrinho();
                    this.tB_PRODUTOTableAdapter.UpdateQuery();
                    this.tB_CARRINHOTableAdapter.zerarCarrinho();
                    this.tB_VENDATableAdapter.Fill(this.bDProjetoFinalDataSet.TB_VENDA);
                    this.tB_CARRINHOTableAdapter.Fill(this.bDProjetoFinalDataSet.TB_CARRINHO);
                    this.tB_PRODUTOTableAdapter.Fill(this.bDProjetoFinalDataSet.TB_PRODUTO);
                    this.tB_PRODUTOVENDATableAdapter.Fill(this.bDProjetoFinalDataSet.TB_PRODUTOVENDA);
                    dgvCarrinho.Visible = false;

                    txtCliente.Text = "";
                    txtFuncionario.Text = "";
                }                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {            
            try
            {
                txtControleVenda.Visible = true;
                this.tB_PRODUTOTableAdapter.addEstoquePelaVenda(Convert.ToInt32(txtControleVenda.Text));
                this.tB_PRODUTOVENDATableAdapter.excluirProdutosDaVenda(Convert.ToInt32(txtControleVenda.Text));
                this.tB_VENDATableAdapter.excluirVenda(Convert.ToInt32(txtControleVenda.Text));
                txtControleVenda.Visible = false;
                this.tB_VENDATableAdapter.Fill(this.bDProjetoFinalDataSet.TB_VENDA);
                this.tB_PRODUTOVENDATableAdapter.Fill(this.bDProjetoFinalDataSet.TB_PRODUTOVENDA);
                this.tB_PRODUTOTableAdapter.Fill(this.bDProjetoFinalDataSet.TB_PRODUTO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluirItens_Click(object sender, EventArgs e)
        {
            try
            {
                txtControleProdutoVenda.Visible = true;
                this.tB_PRODUTOTableAdapter.addEstoque(Convert.ToInt32(txtControleProdutoVenda.Text));
                this.tB_PRODUTOVENDATableAdapter.excluirProdVen(Convert.ToInt32(txtControleProdutoVenda.Text));                
                txtControleProdutoVenda.Visible = false;
                this.tB_VENDATableAdapter.Fill(this.bDProjetoFinalDataSet.TB_VENDA);
                this.tB_PRODUTOVENDATableAdapter.Fill(this.bDProjetoFinalDataSet.TB_PRODUTOVENDA);
                this.tB_PRODUTOTableAdapter.Fill(this.bDProjetoFinalDataSet.TB_PRODUTO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void txtNomeFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvFuncionario.Visible = true;
            dgvCliente.Visible = false;            
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvCliente.Visible = true;
            dgvFuncionario.Visible = false;
            try
            {
                this.tB_CLIENTETableAdapter.PesquisarNome(this.bDProjetoFinalDataSet.TB_CLIENTE, "%" + txtCliente.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            //this.tB_CLIENTETableAdapter.Fill(this.bDProjetoFinalDataSet1.TB_CLIENTE);
        }

        private void txtFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvFuncionario.Visible = true;
            dgvCliente.Visible = false;
            try
            {
                this.tB_FUNCIONARIOTableAdapter.PesquisarNome(this.bDProjetoFinalDataSet.TB_FUNCIONARIO, "%" + txtFuncionario.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            //this.tB_FUNCIONARIOTableAdapter.Fill(this.bDProjetoFinalDataSet.TB_FUNCIONARIO);
        }

        private void dgvFuncionario_Click(object sender, EventArgs e)
        {
            txtNomeFuncionario.Visible = true;
            txtFuncionario.Text = txtNomeFuncionario.Text;
            txtNomeFuncionario.Visible = false;
        }

        private void dgvCliente_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Visible = true;
            txtCliente.Text = txtNomeCliente.Text;
            txtNomeCliente.Visible = false;
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            try
            {
                txtControleCarrinho.Visible = true;
                this.tB_CARRINHOTableAdapter.delProduto(Convert.ToInt32(txtControleCarrinho.Text));
                txtControleCarrinho.Visible = false;
                this.tB_CARRINHOTableAdapter.Fill(this.bDProjetoFinalDataSet.TB_CARRINHO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void txtDataVenda_ValueChanged(object sender, EventArgs e)
        {
            dgvCliente.Visible = false;
            dgvFuncionario.Visible = false;
        }

        private void dgvProduto_Click(object sender, EventArgs e)
        {
            txtControleNomeProduto.Visible = true;
            txtNomeProduto.Text = txtControleNomeProduto.Text;
            txtControleNomeProduto.Visible = false;
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
