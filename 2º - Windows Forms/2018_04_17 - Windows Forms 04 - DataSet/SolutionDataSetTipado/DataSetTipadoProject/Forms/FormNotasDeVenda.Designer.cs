namespace DataSetTipadoProject.Forms
{
    partial class FormNotasDeVenda
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
            System.Windows.Forms.Label idnotadevendaLabel;
            System.Windows.Forms.Label idclienteLabel;
            System.Windows.Forms.Label numerodanotaLabel;
            System.Windows.Forms.Label datadavendaLabel;
            System.Windows.Forms.Label notafechadaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotasDeVenda));
            this.gbxDadosDaNota = new System.Windows.Forms.GroupBox();
            this.idnotadevendaLabel1 = new System.Windows.Forms.Label();
            this.notasDeVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSEstadosECidades = new DataSetTipadoProject.DataSets.DSEstadosECidades();
            this.idclienteComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numerodanotaTextBox = new System.Windows.Forms.TextBox();
            this.datadavendaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notafechadaTextBox = new System.Windows.Forms.TextBox();
            this.notasDeVendaTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.NotasDeVendaTableAdapter();
            this.tableAdapterManager = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager();
            this.clientesTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.ClientesTableAdapter();
            this.produtosNotaDeSaidaTableAdapter = new DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.ProdutosNotaDeSaidaTableAdapter();
            this.notasDeVendaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.notasDeVendaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbxProdutosDaNota = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosNotaDeSaidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bnbAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bnbRemove = new System.Windows.Forms.ToolStripButton();
            this.bnbFirst = new System.Windows.Forms.ToolStripButton();
            this.bnbPrior = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bnbNext = new System.Windows.Forms.ToolStripButton();
            this.bnbLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bnbEdit = new System.Windows.Forms.ToolStripButton();
            this.bnbSave = new System.Windows.Forms.ToolStripButton();
            this.bnbFecharNota = new System.Windows.Forms.ToolStripButton();
            idnotadevendaLabel = new System.Windows.Forms.Label();
            idclienteLabel = new System.Windows.Forms.Label();
            numerodanotaLabel = new System.Windows.Forms.Label();
            datadavendaLabel = new System.Windows.Forms.Label();
            notafechadaLabel = new System.Windows.Forms.Label();
            this.gbxDadosDaNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeVendaBindingNavigator)).BeginInit();
            this.notasDeVendaBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxProdutosDaNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaDeSaidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // idnotadevendaLabel
            // 
            idnotadevendaLabel.AutoSize = true;
            idnotadevendaLabel.Location = new System.Drawing.Point(51, 17);
            idnotadevendaLabel.Name = "idnotadevendaLabel";
            idnotadevendaLabel.Size = new System.Drawing.Size(81, 13);
            idnotadevendaLabel.TabIndex = 0;
            idnotadevendaLabel.Text = "idnotadevenda:";
            // 
            // idclienteLabel
            // 
            idclienteLabel.AutoSize = true;
            idclienteLabel.Location = new System.Drawing.Point(51, 46);
            idclienteLabel.Name = "idclienteLabel";
            idclienteLabel.Size = new System.Drawing.Size(49, 13);
            idclienteLabel.TabIndex = 2;
            idclienteLabel.Text = "idcliente:";
            // 
            // numerodanotaLabel
            // 
            numerodanotaLabel.AutoSize = true;
            numerodanotaLabel.Location = new System.Drawing.Point(51, 73);
            numerodanotaLabel.Name = "numerodanotaLabel";
            numerodanotaLabel.Size = new System.Drawing.Size(78, 13);
            numerodanotaLabel.TabIndex = 4;
            numerodanotaLabel.Text = "numerodanota:";
            // 
            // datadavendaLabel
            // 
            datadavendaLabel.AutoSize = true;
            datadavendaLabel.Location = new System.Drawing.Point(51, 100);
            datadavendaLabel.Name = "datadavendaLabel";
            datadavendaLabel.Size = new System.Drawing.Size(73, 13);
            datadavendaLabel.TabIndex = 6;
            datadavendaLabel.Text = "datadavenda:";
            // 
            // notafechadaLabel
            // 
            notafechadaLabel.AutoSize = true;
            notafechadaLabel.Location = new System.Drawing.Point(51, 125);
            notafechadaLabel.Name = "notafechadaLabel";
            notafechadaLabel.Size = new System.Drawing.Size(70, 13);
            notafechadaLabel.TabIndex = 8;
            notafechadaLabel.Text = "notafechada:";
            // 
            // gbxDadosDaNota
            // 
            this.gbxDadosDaNota.Controls.Add(idnotadevendaLabel);
            this.gbxDadosDaNota.Controls.Add(this.idnotadevendaLabel1);
            this.gbxDadosDaNota.Controls.Add(idclienteLabel);
            this.gbxDadosDaNota.Controls.Add(this.idclienteComboBox);
            this.gbxDadosDaNota.Controls.Add(numerodanotaLabel);
            this.gbxDadosDaNota.Controls.Add(this.numerodanotaTextBox);
            this.gbxDadosDaNota.Controls.Add(datadavendaLabel);
            this.gbxDadosDaNota.Controls.Add(this.datadavendaDateTimePicker);
            this.gbxDadosDaNota.Controls.Add(notafechadaLabel);
            this.gbxDadosDaNota.Controls.Add(this.notafechadaTextBox);
            this.gbxDadosDaNota.Enabled = false;
            this.gbxDadosDaNota.Location = new System.Drawing.Point(12, 28);
            this.gbxDadosDaNota.Name = "gbxDadosDaNota";
            this.gbxDadosDaNota.Size = new System.Drawing.Size(358, 162);
            this.gbxDadosDaNota.TabIndex = 0;
            this.gbxDadosDaNota.TabStop = false;
            this.gbxDadosDaNota.Text = "Dados da Nota";
            // 
            // idnotadevendaLabel1
            // 
            this.idnotadevendaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasDeVendaBindingSource, "idnotadevenda", true));
            this.idnotadevendaLabel1.Location = new System.Drawing.Point(138, 17);
            this.idnotadevendaLabel1.Name = "idnotadevendaLabel1";
            this.idnotadevendaLabel1.Size = new System.Drawing.Size(200, 23);
            this.idnotadevendaLabel1.TabIndex = 1;
            this.idnotadevendaLabel1.Text = "label1";
            // 
            // notasDeVendaBindingSource
            // 
            this.notasDeVendaBindingSource.DataMember = "NotasDeVenda";
            this.notasDeVendaBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // dSEstadosECidades
            // 
            this.dSEstadosECidades.DataSetName = "DSEstadosECidades";
            this.dSEstadosECidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idclienteComboBox
            // 
            this.idclienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.notasDeVendaBindingSource, "idcliente", true));
            this.idclienteComboBox.DataSource = this.clientesBindingSource;
            this.idclienteComboBox.DisplayMember = "nome";
            this.idclienteComboBox.FormattingEnabled = true;
            this.idclienteComboBox.Location = new System.Drawing.Point(138, 43);
            this.idclienteComboBox.Name = "idclienteComboBox";
            this.idclienteComboBox.Size = new System.Drawing.Size(200, 21);
            this.idclienteComboBox.TabIndex = 3;
            this.idclienteComboBox.ValueMember = "idcliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dSEstadosECidades;
            // 
            // numerodanotaTextBox
            // 
            this.numerodanotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasDeVendaBindingSource, "numerodanota", true));
            this.numerodanotaTextBox.Location = new System.Drawing.Point(138, 70);
            this.numerodanotaTextBox.Name = "numerodanotaTextBox";
            this.numerodanotaTextBox.Size = new System.Drawing.Size(200, 20);
            this.numerodanotaTextBox.TabIndex = 5;
            // 
            // datadavendaDateTimePicker
            // 
            this.datadavendaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasDeVendaBindingSource, "datadavenda", true));
            this.datadavendaDateTimePicker.Location = new System.Drawing.Point(138, 96);
            this.datadavendaDateTimePicker.Name = "datadavendaDateTimePicker";
            this.datadavendaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datadavendaDateTimePicker.TabIndex = 7;
            // 
            // notafechadaTextBox
            // 
            this.notafechadaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasDeVendaBindingSource, "notafechada", true));
            this.notafechadaTextBox.Location = new System.Drawing.Point(138, 122);
            this.notafechadaTextBox.Name = "notafechadaTextBox";
            this.notafechadaTextBox.Size = new System.Drawing.Size(200, 20);
            this.notafechadaTextBox.TabIndex = 9;
            // 
            // notasDeVendaTableAdapter
            // 
            this.notasDeVendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CidadesTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.EstadosTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.GruposTableAdapter = null;
            this.tableAdapterManager.NotasDeEntradaTableAdapter = null;
            this.tableAdapterManager.NotasDeVendaTableAdapter = this.notasDeVendaTableAdapter;
            this.tableAdapterManager.ProdutosNotaDeEntradaTableAdapter = null;
            this.tableAdapterManager.ProdutosNotaDeSaidaTableAdapter = this.produtosNotaDeSaidaTableAdapter;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataSetTipadoProject.DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // produtosNotaDeSaidaTableAdapter
            // 
            this.produtosNotaDeSaidaTableAdapter.ClearBeforeFill = true;
            // 
            // notasDeVendaBindingNavigator
            // 
            this.notasDeVendaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.notasDeVendaBindingNavigator.BindingSource = this.notasDeVendaBindingSource;
            this.notasDeVendaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.notasDeVendaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.notasDeVendaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.notasDeVendaBindingNavigatorSaveItem});
            this.notasDeVendaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.notasDeVendaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.notasDeVendaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.notasDeVendaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.notasDeVendaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.notasDeVendaBindingNavigator.Name = "notasDeVendaBindingNavigator";
            this.notasDeVendaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.notasDeVendaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.notasDeVendaBindingNavigator.TabIndex = 1;
            this.notasDeVendaBindingNavigator.Text = "bindingNavigator1";
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
            // notasDeVendaBindingNavigatorSaveItem
            // 
            this.notasDeVendaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notasDeVendaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("notasDeVendaBindingNavigatorSaveItem.Image")));
            this.notasDeVendaBindingNavigatorSaveItem.Name = "notasDeVendaBindingNavigatorSaveItem";
            this.notasDeVendaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.notasDeVendaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.notasDeVendaBindingNavigatorSaveItem.Click += new System.EventHandler(this.notasDeVendaBindingNavigatorSaveItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbxProdutosDaNota);
            this.groupBox2.Controls.Add(this.bindingNavigator1);
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 287);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos da Nota";
            // 
            // gbxProdutosDaNota
            // 
            this.gbxProdutosDaNota.AutoGenerateColumns = false;
            this.gbxProdutosDaNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gbxProdutosDaNota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gbxProdutosDaNota.DataSource = this.produtosNotaDeSaidaBindingSource;
            this.gbxProdutosDaNota.Enabled = false;
            this.gbxProdutosDaNota.Location = new System.Drawing.Point(8, 47);
            this.gbxProdutosDaNota.Name = "gbxProdutosDaNota";
            this.gbxProdutosDaNota.Size = new System.Drawing.Size(344, 220);
            this.gbxProdutosDaNota.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idproduto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precodevenda";
            this.dataGridViewTextBoxColumn4.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // produtosNotaDeSaidaBindingSource
            // 
            this.produtosNotaDeSaidaBindingSource.DataMember = "FK_ProdutosNotaDeSaida_ToNotasDeVenda";
            this.produtosNotaDeSaidaBindingSource.DataSource = this.notasDeVendaBindingSource;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bnbAdd;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bnbRemove;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnbFirst,
            this.bnbPrior,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bnbNext,
            this.bnbLast,
            this.bindingNavigatorSeparator5,
            this.bnbAdd,
            this.bnbRemove,
            this.bnbEdit,
            this.bnbSave,
            this.bnbFecharNota});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = this.bnbFirst;
            this.bindingNavigator1.MoveLastItem = this.bnbLast;
            this.bindingNavigator1.MoveNextItem = this.bnbNext;
            this.bindingNavigator1.MovePreviousItem = this.bnbPrior;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(352, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bnbAdd
            // 
            this.bnbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbAdd.Image = ((System.Drawing.Image)(resources.GetObject("bnbAdd.Image")));
            this.bnbAdd.Name = "bnbAdd";
            this.bnbAdd.RightToLeftAutoMirrorImage = true;
            this.bnbAdd.Size = new System.Drawing.Size(23, 22);
            this.bnbAdd.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem1.Text = "de {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Número total de itens";
            // 
            // bnbRemove
            // 
            this.bnbRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbRemove.Image = ((System.Drawing.Image)(resources.GetObject("bnbRemove.Image")));
            this.bnbRemove.Name = "bnbRemove";
            this.bnbRemove.RightToLeftAutoMirrorImage = true;
            this.bnbRemove.Size = new System.Drawing.Size(23, 22);
            this.bnbRemove.Text = "Excluir";
            // 
            // bnbFirst
            // 
            this.bnbFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbFirst.Image = ((System.Drawing.Image)(resources.GetObject("bnbFirst.Image")));
            this.bnbFirst.Name = "bnbFirst";
            this.bnbFirst.RightToLeftAutoMirrorImage = true;
            this.bnbFirst.Size = new System.Drawing.Size(23, 22);
            this.bnbFirst.Text = "Mover primeiro";
            // 
            // bnbPrior
            // 
            this.bnbPrior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbPrior.Image = ((System.Drawing.Image)(resources.GetObject("bnbPrior.Image")));
            this.bnbPrior.Name = "bnbPrior";
            this.bnbPrior.RightToLeftAutoMirrorImage = true;
            this.bnbPrior.Size = new System.Drawing.Size(23, 22);
            this.bnbPrior.Text = "Mover anterior";
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
            // bnbNext
            // 
            this.bnbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbNext.Image = ((System.Drawing.Image)(resources.GetObject("bnbNext.Image")));
            this.bnbNext.Name = "bnbNext";
            this.bnbNext.RightToLeftAutoMirrorImage = true;
            this.bnbNext.Size = new System.Drawing.Size(23, 22);
            this.bnbNext.Text = "Mover próximo";
            // 
            // bnbLast
            // 
            this.bnbLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbLast.Image = ((System.Drawing.Image)(resources.GetObject("bnbLast.Image")));
            this.bnbLast.Name = "bnbLast";
            this.bnbLast.RightToLeftAutoMirrorImage = true;
            this.bnbLast.Size = new System.Drawing.Size(23, 22);
            this.bnbLast.Text = "Mover último";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bnbEdit
            // 
            this.bnbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbEdit.Image = ((System.Drawing.Image)(resources.GetObject("bnbEdit.Image")));
            this.bnbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnbEdit.Name = "bnbEdit";
            this.bnbEdit.Size = new System.Drawing.Size(23, 22);
            this.bnbEdit.Text = "toolStripButton1";
            // 
            // bnbSave
            // 
            this.bnbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbSave.Image = ((System.Drawing.Image)(resources.GetObject("bnbSave.Image")));
            this.bnbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnbSave.Name = "bnbSave";
            this.bnbSave.Size = new System.Drawing.Size(23, 22);
            this.bnbSave.Text = "toolStripButton2";
            // 
            // bnbFecharNota
            // 
            this.bnbFecharNota.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnbFecharNota.Image = ((System.Drawing.Image)(resources.GetObject("bnbFecharNota.Image")));
            this.bnbFecharNota.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnbFecharNota.Name = "bnbFecharNota";
            this.bnbFecharNota.Size = new System.Drawing.Size(23, 22);
            this.bnbFecharNota.Text = "toolStripButton1";
            // 
            // FormNotasDeVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.notasDeVendaBindingNavigator);
            this.Controls.Add(this.gbxDadosDaNota);
            this.Name = "FormNotasDeVenda";
            this.Text = "FormNotasDeVenda";
            this.Load += new System.EventHandler(this.FormNotasDeVenda_Load);
            this.gbxDadosDaNota.ResumeLayout(false);
            this.gbxDadosDaNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadosECidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDeVendaBindingNavigator)).EndInit();
            this.notasDeVendaBindingNavigator.ResumeLayout(false);
            this.notasDeVendaBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxProdutosDaNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaDeSaidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDadosDaNota;
        private DataSets.DSEstadosECidades dSEstadosECidades;
        private System.Windows.Forms.BindingSource notasDeVendaBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.NotasDeVendaTableAdapter notasDeVendaTableAdapter;
        private DataSets.DSEstadosECidadesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator notasDeVendaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton notasDeVendaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idnotadevendaLabel1;
        private System.Windows.Forms.ComboBox idclienteComboBox;
        private System.Windows.Forms.TextBox numerodanotaTextBox;
        private System.Windows.Forms.DateTimePicker datadavendaDateTimePicker;
        private System.Windows.Forms.TextBox notafechadaTextBox;
        private DataSets.DSEstadosECidadesTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSets.DSEstadosECidadesTableAdapters.ProdutosNotaDeSaidaTableAdapter produtosNotaDeSaidaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bnbAdd;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bnbRemove;
        private System.Windows.Forms.ToolStripButton bnbFirst;
        private System.Windows.Forms.ToolStripButton bnbPrior;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bnbNext;
        private System.Windows.Forms.ToolStripButton bnbLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource produtosNotaDeSaidaBindingSource;
        private System.Windows.Forms.DataGridView gbxProdutosDaNota;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripButton bnbEdit;
        private System.Windows.Forms.ToolStripButton bnbSave;
        private System.Windows.Forms.ToolStripButton bnbFecharNota;
    }
}