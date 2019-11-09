namespace DataSetTipadoProject.Forms
{
    partial class FormNotasDeEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idnotadeentraLabel;
            System.Windows.Forms.Label idfornecedorLabel;
            System.Windows.Forms.Label numerodanotaLabel;
            System.Windows.Forms.Label datadeemissaoLabel;
            System.Windows.Forms.Label datadeentradaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotasDeEntrada));
            this.dSEstadosECidades = new DataSetTipadoProject.DataSets.DSEstadosECidades();
            this.notasDeEntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasDeEntradaTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.NotasDeEntradaTableAdapter();
            this.tableAdapterManager = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager();
            this.fornecedoresTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.FornecedoresTableAdapter();
            this.notasDeEntradaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.notasDeEntradaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idnotadeentraLabel1 = new System.Windows.Forms.Label();
            this.idfornecedorComboBox = new System.Windows.Forms.ComboBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numerodanotaTextBox = new System.Windows.Forms.TextBox();
            this.datadeemissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datadeentradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.precocustacompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadecompradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosNotaDeEntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.produtosNotaDeEntradaTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.ProdutosNotaDeEntradaTableAdapter();
            idnotadeentraLabel = new System.Windows.Forms.Label();
            idfornecedorLabel = new System.Windows.Forms.Label();
            numerodanotaLabel = new System.Windows.Forms.Label();
            datadeemissaoLabel = new System.Windows.Forms.Label();
            datadeentradaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeEntradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeEntradaBindingNavigator)).BeginInit();
            this.notasDeEntradaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaDeEntradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idnotadeentraLabel
            // 
            idnotadeentraLabel.AutoSize = true;
            idnotadeentraLabel.Location = new System.Drawing.Point(54, 47);
            idnotadeentraLabel.Name = "idnotadeentraLabel";
            idnotadeentraLabel.Size = new System.Drawing.Size(75, 13);
            idnotadeentraLabel.TabIndex = 1;
            idnotadeentraLabel.Text = "idnotadeentra:";
            // 
            // idfornecedorLabel
            // 
            idfornecedorLabel.AutoSize = true;
            idfornecedorLabel.Location = new System.Drawing.Point(54, 76);
            idfornecedorLabel.Name = "idfornecedorLabel";
            idfornecedorLabel.Size = new System.Drawing.Size(69, 13);
            idfornecedorLabel.TabIndex = 3;
            idfornecedorLabel.Text = "idfornecedor:";
            // 
            // numerodanotaLabel
            // 
            numerodanotaLabel.AutoSize = true;
            numerodanotaLabel.Location = new System.Drawing.Point(54, 103);
            numerodanotaLabel.Name = "numerodanotaLabel";
            numerodanotaLabel.Size = new System.Drawing.Size(78, 13);
            numerodanotaLabel.TabIndex = 5;
            numerodanotaLabel.Text = "numerodanota:";
            // 
            // datadeemissaoLabel
            // 
            datadeemissaoLabel.AutoSize = true;
            datadeemissaoLabel.Location = new System.Drawing.Point(54, 130);
            datadeemissaoLabel.Name = "datadeemissaoLabel";
            datadeemissaoLabel.Size = new System.Drawing.Size(81, 13);
            datadeemissaoLabel.TabIndex = 7;
            datadeemissaoLabel.Text = "datadeemissao:";
            // 
            // datadeentradaLabel
            // 
            datadeentradaLabel.AutoSize = true;
            datadeentradaLabel.Location = new System.Drawing.Point(54, 156);
            datadeentradaLabel.Name = "datadeentradaLabel";
            datadeentradaLabel.Size = new System.Drawing.Size(79, 13);
            datadeentradaLabel.TabIndex = 9;
            datadeentradaLabel.Text = "datadeentrada:";
            // 
            // dSEstadosECidades
            // 
            this.dSEstadosECidades.DataSetName = "DSEstadosECidades";
            this.dSEstadosECidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasDeEntradaBindingSource
            // 
            this.notasDeEntradaBindingSource.DataMember = "NotasDeEntrada";
            this.notasDeEntradaBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // notasDeEntradaTableAdapter
            // 
            this.notasDeEntradaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CidadesTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.EstadosTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = this.fornecedoresTableAdapter;
            this.tableAdapterManager.GruposTableAdapter = null;
            this.tableAdapterManager.NotasDeEntradaTableAdapter = this.notasDeEntradaTableAdapter;
            this.tableAdapterManager.ProdutosNotaDeEntradaTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // notasDeEntradaBindingNavigator
            // 
            this.notasDeEntradaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.notasDeEntradaBindingNavigator.BindingSource = this.notasDeEntradaBindingSource;
            this.notasDeEntradaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.notasDeEntradaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.notasDeEntradaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.notasDeEntradaBindingNavigatorSaveItem});
            this.notasDeEntradaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.notasDeEntradaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.notasDeEntradaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.notasDeEntradaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.notasDeEntradaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.notasDeEntradaBindingNavigator.Name = "notasDeEntradaBindingNavigator";
            this.notasDeEntradaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.notasDeEntradaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.notasDeEntradaBindingNavigator.TabIndex = 0;
            this.notasDeEntradaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
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
            // notasDeEntradaBindingNavigatorSaveItem
            // 
            this.notasDeEntradaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notasDeEntradaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("notasDeEntradaBindingNavigatorSaveItem.Image")));
            this.notasDeEntradaBindingNavigatorSaveItem.Name = "notasDeEntradaBindingNavigatorSaveItem";
            this.notasDeEntradaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.notasDeEntradaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.notasDeEntradaBindingNavigatorSaveItem.Click += new System.EventHandler(this.notasDeEntradaBindingNavigatorSaveItem_Click);
            // 
            // idnotadeentraLabel1
            // 
            this.idnotadeentraLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasDeEntradaBindingSource, "idnotadeentra", true));
            this.idnotadeentraLabel1.Location = new System.Drawing.Point(141, 47);
            this.idnotadeentraLabel1.Name = "idnotadeentraLabel1";
            this.idnotadeentraLabel1.Size = new System.Drawing.Size(200, 23);
            this.idnotadeentraLabel1.TabIndex = 2;
            this.idnotadeentraLabel1.Text = "label1";
            // 
            // idfornecedorComboBox
            // 
            this.idfornecedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.notasDeEntradaBindingSource, "idfornecedor", true));
            this.idfornecedorComboBox.DataSource = this.fornecedoresBindingSource;
            this.idfornecedorComboBox.DisplayMember = "nome";
            this.idfornecedorComboBox.FormattingEnabled = true;
            this.idfornecedorComboBox.Location = new System.Drawing.Point(141, 73);
            this.idfornecedorComboBox.Name = "idfornecedorComboBox";
            this.idfornecedorComboBox.Size = new System.Drawing.Size(200, 21);
            this.idfornecedorComboBox.TabIndex = 4;
            this.idfornecedorComboBox.ValueMember = "idfornecedor";
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // numerodanotaTextBox
            // 
            this.numerodanotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasDeEntradaBindingSource, "numerodanota", true));
            this.numerodanotaTextBox.Location = new System.Drawing.Point(141, 100);
            this.numerodanotaTextBox.Name = "numerodanotaTextBox";
            this.numerodanotaTextBox.Size = new System.Drawing.Size(200, 20);
            this.numerodanotaTextBox.TabIndex = 6;
            // 
            // datadeemissaoDateTimePicker
            // 
            this.datadeemissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasDeEntradaBindingSource, "datadeemissao", true));
            this.datadeemissaoDateTimePicker.Location = new System.Drawing.Point(141, 126);
            this.datadeemissaoDateTimePicker.Name = "datadeemissaoDateTimePicker";
            this.datadeemissaoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datadeemissaoDateTimePicker.TabIndex = 8;
            // 
            // datadeentradaDateTimePicker
            // 
            this.datadeentradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasDeEntradaBindingSource, "datadeentrada", true));
            this.datadeentradaDateTimePicker.Location = new System.Drawing.Point(141, 152);
            this.datadeentradaDateTimePicker.Name = "datadeentradaDateTimePicker";
            this.datadeentradaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datadeentradaDateTimePicker.TabIndex = 10;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByToolStrip.TabIndex = 11;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProdutos);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Location = new System.Drawing.Point(57, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 202);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodutoDataGridViewTextBoxColumn,
            this.precocustacompraDataGridViewTextBoxColumn,
            this.quantidadecompradaDataGridViewTextBoxColumn});
            this.dgvProdutos.DataSource = this.produtosNotaDeEntradaBindingSource;
            this.dgvProdutos.Location = new System.Drawing.Point(6, 44);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(345, 150);
            this.dgvProdutos.TabIndex = 1;
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "idproduto";
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            this.idprodutoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idprodutoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // precocustacompraDataGridViewTextBoxColumn
            // 
            this.precocustacompraDataGridViewTextBoxColumn.DataPropertyName = "precocustacompra";
            this.precocustacompraDataGridViewTextBoxColumn.HeaderText = "Custo";
            this.precocustacompraDataGridViewTextBoxColumn.Name = "precocustacompraDataGridViewTextBoxColumn";
            // 
            // quantidadecompradaDataGridViewTextBoxColumn
            // 
            this.quantidadecompradaDataGridViewTextBoxColumn.DataPropertyName = "quantidadecomprada";
            this.quantidadecompradaDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadecompradaDataGridViewTextBoxColumn.Name = "quantidadecompradaDataGridViewTextBoxColumn";
            // 
            // produtosNotaDeEntradaBindingSource
            // 
            this.produtosNotaDeEntradaBindingSource.DataMember = "FK_ProdutosNotaDeEntrada_ToNotasDeEntrada";
            this.produtosNotaDeEntradaBindingSource.DataSource = this.notasDeEntradaBindingSource;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(352, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem1.Text = "de {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Mover último";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // produtosNotaDeEntradaTableAdapter
            // 
            this.produtosNotaDeEntradaTableAdapter.ClearBeforeFill = true;
            // 
            // FormNotasDeEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(idnotadeentraLabel);
            this.Controls.Add(this.idnotadeentraLabel1);
            this.Controls.Add(idfornecedorLabel);
            this.Controls.Add(this.idfornecedorComboBox);
            this.Controls.Add(numerodanotaLabel);
            this.Controls.Add(this.numerodanotaTextBox);
            this.Controls.Add(datadeemissaoLabel);
            this.Controls.Add(this.datadeemissaoDateTimePicker);
            this.Controls.Add(datadeentradaLabel);
            this.Controls.Add(this.datadeentradaDateTimePicker);
            this.Controls.Add(this.notasDeEntradaBindingNavigator);
            this.Name = "FormNotasDeEntrada";
            this.Text = "FormNotasDeEntrada";
            this.Load += new System.EventHandler(this.FormNotasDeEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeEntradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeEntradaBindingNavigator)).EndInit();
            this.notasDeEntradaBindingNavigator.ResumeLayout(false);
            this.notasDeEntradaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaDeEntradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.DSEstadosECidades dSEstadosECidades;
        private System.Windows.Forms.BindingSource notasDeEntradaBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.NotasDeEntradaTableAdapter notasDeEntradaTableAdapter;
        private DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator notasDeEntradaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton notasDeEntradaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idnotadeentraLabel1;
        private System.Windows.Forms.ComboBox idfornecedorComboBox;
        private System.Windows.Forms.TextBox numerodanotaTextBox;
        private System.Windows.Forms.DateTimePicker datadeemissaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker datadeentradaDateTimePicker;
        private DataSets.DSEstadosECidadesTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingSource produtosNotaDeEntradaBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.ProdutosNotaDeEntradaTableAdapter produtosNotaDeEntradaTableAdapter;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewComboBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precocustacompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadecompradaDataGridViewTextBoxColumn;
    }
}