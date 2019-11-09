using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NETProject01
{
    public partial class FormNotasEntrada : Form
    {
        private DAL_NotaEntrada dal = new DAL_NotaEntrada();
        private DAL_Fornecedor dalFornecedor = new DAL_Fornecedor();        
        private NotaEntrada notaAtual;

        public FormNotasEntrada()
        {
            InitializeComponent();
            InicializaComboBoxs();
            GetAllNotas();
        }

        private void InicializaComboBoxs()
        {
            cbxFornecedor.Items.Clear();
            cbxProduto.Items.Clear();
            foreach (Fornecedor fornecedor in this.dalFornecedor.GetAllAsIList())
            {
                cbxFornecedor.Items.Add(fornecedor);
            }

            
            foreach (Produto produto in this.dalProduto.GetAllAsIList())
            {
                 cbxProduto.Items.Add(produto);
            }
            
        }

        private void GetAllNotas()
        {
            dgvNotasEntrada.DataSource = dal.GetAllAsDataTable();
        }

        private void btnGravarNota_Click(object sender, EventArgs e)
        {
            dal.Save(new NotaEntrada()
            {
                Id = string.IsNullOrEmpty(txtIDNota.Text) ?
                    (long?)null :
                    Convert.ToInt64(txtIDNota.Text),
                Numero = txtNumero.Text,
                DataEmissao = Convert.ToDateTime(dtpEmissao.Value),
                DataEntrada = Convert.ToDateTime(dtpEntrada.Value),
                FornecedorNota = (Fornecedor)cbxFornecedor.
                    SelectedItem
            });
            MessageBox.Show("Manutenção realizada com sucesso");
            ClearControls();
        }
    }
}
