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
    public partial class FormEstados : Form
    {
        public FormEstados()
        {
            InitializeComponent();
        }

        private void estadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);

        }

        private void FormEstados_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dSEstadosECidades.Estados'. Você pode movê-la ou removê-la conforme necessário.
            this.estadosTableAdapter.Fill(this.dSEstadosECidades.Estados);

        }
    }
}
