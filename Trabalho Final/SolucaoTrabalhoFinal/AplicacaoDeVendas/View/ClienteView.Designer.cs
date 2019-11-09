namespace AplicacaoDeVendas
{
    partial class ClienteView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cLI_NOMELabel;
            System.Windows.Forms.Label cLI_RGLabel;
            System.Windows.Forms.Label cLI_CPFLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteView));
            this.tB_CLIENTEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tB_CLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDProjetoFinalDataSet = new AplicacaoDeVendas.BDProjetoFinalDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tB_CLIENTEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.tB_CLIENTEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.pesquisarNomeToolStrip = new System.Windows.Forms.ToolStrip();
            this.pesquisarNomeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.pesquisarNomeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pesquisarNomeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tB_CLIENTETableAdapter = new AplicacaoDeVendas.BDProjetoFinalDataSetTableAdapters.TB_CLIENTETableAdapter();
            this.tableAdapterManager = new AplicacaoDeVendas.BDProjetoFinalDataSetTableAdapters.TableAdapterManager();
            this.btnVoltar = new System.Windows.Forms.Button();
            cLI_NOMELabel = new System.Windows.Forms.Label();
            cLI_RGLabel = new System.Windows.Forms.Label();
            cLI_CPFLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tB_CLIENTEBindingNavigator)).BeginInit();
            this.tB_CLIENTEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tB_CLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDProjetoFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_CLIENTEDataGridView)).BeginInit();
            this.pesquisarNomeToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cLI_NOMELabel
            // 
            cLI_NOMELabel.AutoSize = true;
            cLI_NOMELabel.Location = new System.Drawing.Point(12, 309);
            cLI_NOMELabel.Name = "cLI_NOMELabel";
            cLI_NOMELabel.Size = new System.Drawing.Size(38, 13);
            cLI_NOMELabel.TabIndex = 3;
            cLI_NOMELabel.Text = "Nome:";
            // 
            // cLI_RGLabel
            // 
            cLI_RGLabel.AutoSize = true;
            cLI_RGLabel.Location = new System.Drawing.Point(12, 361);
            cLI_RGLabel.Name = "cLI_RGLabel";
            cLI_RGLabel.Size = new System.Drawing.Size(26, 13);
            cLI_RGLabel.TabIndex = 7;
            cLI_RGLabel.Text = "RG:";
            // 
            // cLI_CPFLabel
            // 
            cLI_CPFLabel.AutoSize = true;
            cLI_CPFLabel.Location = new System.Drawing.Point(12, 335);
            cLI_CPFLabel.Name = "cLI_CPFLabel";
            cLI_CPFLabel.Size = new System.Drawing.Size(30, 13);
            cLI_CPFLabel.TabIndex = 8;
            cLI_CPFLabel.Text = "CPF:";
            // 
            // tB_CLIENTEBindingNavigator
            // 
            this.tB_CLIENTEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tB_CLIENTEBindingNavigator.BindingSource = this.tB_CLIENTEBindingSource;
            this.tB_CLIENTEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tB_CLIENTEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tB_CLIENTEBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tB_CLIENTEBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tB_CLIENTEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tB_CLIENTEBindingNavigatorSaveItem});
            this.tB_CLIENTEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tB_CLIENTEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tB_CLIENTEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tB_CLIENTEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tB_CLIENTEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tB_CLIENTEBindingNavigator.Name = "tB_CLIENTEBindingNavigator";
            this.tB_CLIENTEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tB_CLIENTEBindingNavigator.Size = new System.Drawing.Size(271, 25);
            this.tB_CLIENTEBindingNavigator.TabIndex = 0;
            this.tB_CLIENTEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.habilitarEdicao);
            // 
            // tB_CLIENTEBindingSource
            // 
            this.tB_CLIENTEBindingSource.DataMember = "TB_CLIENTE";
            this.tB_CLIENTEBindingSource.DataSource = this.bDProjetoFinalDataSet;
            // 
            // bDProjetoFinalDataSet
            // 
            this.bDProjetoFinalDataSet.DataSetName = "BDProjetoFinalDataSet";
            this.bDProjetoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tB_CLIENTEBindingNavigatorSaveItem
            // 
            this.tB_CLIENTEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tB_CLIENTEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tB_CLIENTEBindingNavigatorSaveItem.Image")));
            this.tB_CLIENTEBindingNavigatorSaveItem.Name = "tB_CLIENTEBindingNavigatorSaveItem";
            this.tB_CLIENTEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tB_CLIENTEBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tB_CLIENTEBindingNavigatorSaveItem.Click += new System.EventHandler(this.tB_CLIENTEBindingNavigatorSaveItem_Click);
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_CLIENTEBindingSource, "CLI_NOME", true));
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(56, 306);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(243, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtRG
            // 
            this.txtRG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_CLIENTEBindingSource, "CLI_RG", true));
            this.txtRG.Enabled = false;
            this.txtRG.Location = new System.Drawing.Point(56, 358);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(138, 20);
            this.txtRG.TabIndex = 8;
            // 
            // tB_CLIENTEDataGridView
            // 
            this.tB_CLIENTEDataGridView.AllowUserToAddRows = false;
            this.tB_CLIENTEDataGridView.AllowUserToDeleteRows = false;
            this.tB_CLIENTEDataGridView.AutoGenerateColumns = false;
            this.tB_CLIENTEDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tB_CLIENTEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tB_CLIENTEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tB_CLIENTEDataGridView.DataSource = this.tB_CLIENTEBindingSource;
            this.tB_CLIENTEDataGridView.Location = new System.Drawing.Point(0, 28);
            this.tB_CLIENTEDataGridView.Name = "tB_CLIENTEDataGridView";
            this.tB_CLIENTEDataGridView.ReadOnly = true;
            this.tB_CLIENTEDataGridView.Size = new System.Drawing.Size(406, 267);
            this.tB_CLIENTEDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CLI_CODIGO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CLI_NOME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CLI_CPF";
            this.dataGridViewTextBoxColumn3.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 52;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CLI_RG";
            this.dataGridViewTextBoxColumn4.HeaderText = "RG";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 48;
            // 
            // txtCPF
            // 
            this.txtCPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_CLIENTEBindingSource, "CLI_CPF", true));
            this.txtCPF.Enabled = false;
            this.txtCPF.Location = new System.Drawing.Point(56, 332);
            this.txtCPF.Mask = "###.###.###-##";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(138, 20);
            this.txtCPF.TabIndex = 9;
            // 
            // pesquisarNomeToolStrip
            // 
            this.pesquisarNomeToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.pesquisarNomeToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.pesquisarNomeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarNomeToolStripLabel,
            this.pesquisarNomeToolStripTextBox,
            this.pesquisarNomeToolStripButton});
            this.pesquisarNomeToolStrip.Location = new System.Drawing.Point(271, 0);
            this.pesquisarNomeToolStrip.Name = "pesquisarNomeToolStrip";
            this.pesquisarNomeToolStrip.Size = new System.Drawing.Size(194, 25);
            this.pesquisarNomeToolStrip.TabIndex = 10;
            this.pesquisarNomeToolStrip.Text = "pesquisarNomeToolStrip";
            // 
            // pesquisarNomeToolStripLabel
            // 
            this.pesquisarNomeToolStripLabel.Name = "pesquisarNomeToolStripLabel";
            this.pesquisarNomeToolStripLabel.Size = new System.Drawing.Size(43, 22);
            this.pesquisarNomeToolStripLabel.Text = "Nome:";
            // 
            // pesquisarNomeToolStripTextBox
            // 
            this.pesquisarNomeToolStripTextBox.Name = "pesquisarNomeToolStripTextBox";
            this.pesquisarNomeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.pesquisarNomeToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pesquisarNomeToolStripTextBox_KeyPress);
            // 
            // pesquisarNomeToolStripButton
            // 
            this.pesquisarNomeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pesquisarNomeToolStripButton.Name = "pesquisarNomeToolStripButton";
            this.pesquisarNomeToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.pesquisarNomeToolStripButton.Text = "Buscar";
            this.pesquisarNomeToolStripButton.Click += new System.EventHandler(this.pesquisarNomeToolStripButton_Click);
            // 
            // tB_CLIENTETableAdapter
            // 
            this.tB_CLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TB_CARRINHOTableAdapter = null;
            this.tableAdapterManager.TB_CLIENTETableAdapter = this.tB_CLIENTETableAdapter;
            this.tableAdapterManager.TB_FUNCIONARIOTableAdapter = null;
            this.tableAdapterManager.TB_PRODUTOTableAdapter = null;
            this.tableAdapterManager.TB_PRODUTOVENDATableAdapter = null;
            this.tableAdapterManager.TB_VENDATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AplicacaoDeVendas.BDProjetoFinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(579, 350);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 28);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "<< Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 385);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pesquisarNomeToolStrip);
            this.Controls.Add(cLI_CPFLabel);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.tB_CLIENTEDataGridView);
            this.Controls.Add(cLI_NOMELabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(cLI_RGLabel);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.tB_CLIENTEBindingNavigator);
            this.Name = "ClienteView";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.ClienteView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tB_CLIENTEBindingNavigator)).EndInit();
            this.tB_CLIENTEBindingNavigator.ResumeLayout(false);
            this.tB_CLIENTEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tB_CLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDProjetoFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_CLIENTEDataGridView)).EndInit();
            this.pesquisarNomeToolStrip.ResumeLayout(false);
            this.pesquisarNomeToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDProjetoFinalDataSet bDProjetoFinalDataSet;
        private System.Windows.Forms.BindingSource tB_CLIENTEBindingSource;
        private BDProjetoFinalDataSetTableAdapters.TB_CLIENTETableAdapter tB_CLIENTETableAdapter;
        private BDProjetoFinalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tB_CLIENTEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tB_CLIENTEBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.DataGridView tB_CLIENTEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.ToolStrip pesquisarNomeToolStrip;
        private System.Windows.Forms.ToolStripLabel pesquisarNomeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox pesquisarNomeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton pesquisarNomeToolStripButton;
        private System.Windows.Forms.Button btnVoltar;
    }
}

