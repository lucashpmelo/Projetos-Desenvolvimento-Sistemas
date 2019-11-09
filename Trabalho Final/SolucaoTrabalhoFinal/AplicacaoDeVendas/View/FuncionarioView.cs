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
    public partial class FuncionarioView : Form
    {
        public FuncionarioView()
        {
            InitializeComponent();
        }

        private void tB_FUNCIONARIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {            
            try
            {
                this.Validate();
                this.tB_FUNCIONARIOBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDProjetoFinalDataSet);
                txtNome.Enabled = false;
                txtCPF.Enabled = false;
                txtRG.Enabled = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FuncionarioView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDProjetoFinalDataSet.TB_FUNCIONARIO'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_FUNCIONARIOTableAdapter.Fill(this.bDProjetoFinalDataSet.TB_FUNCIONARIO);

        }

        private void habilitarEdicao(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtRG.Enabled = true;
        }

        private void pesquisarNomeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tB_FUNCIONARIOTableAdapter.PesquisarNome(this.bDProjetoFinalDataSet.TB_FUNCIONARIO, pesquisarNomeToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pesquisarNomeToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.tB_FUNCIONARIOTableAdapter.PesquisarNome(this.bDProjetoFinalDataSet.TB_FUNCIONARIO, pesquisarNomeToolStripTextBox.Text + "%");
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
