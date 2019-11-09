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
    public partial class FormGrupos : Form
    {
        public FormGrupos()
        {
            InitializeComponent();
        }

        private void gruposBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gruposBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);

        }

        private void FormGrupos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dSEstadosECidades.Grupos'. Você pode movê-la ou removê-la conforme necessário.
            this.gruposTableAdapter.Fill(this.dSEstadosECidades.Grupos);

        }
    }
}
