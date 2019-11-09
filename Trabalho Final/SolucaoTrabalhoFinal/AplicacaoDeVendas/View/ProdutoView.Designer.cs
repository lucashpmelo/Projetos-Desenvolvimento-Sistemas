namespace AplicacaoDeVendas.View
{
    partial class ProdutoView
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
            System.Windows.Forms.Label pRO_DESCRICAOLabel;
            System.Windows.Forms.Label pRO_ESTOQUELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoView));
            this.bDProjetoFinalDataSet = new AplicacaoDeVendas.BDProjetoFinalDataSet();
            this.tB_PRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_PRODUTOTableAdapter = new AplicacaoDeVendas.BDProjetoFinalDataSetTableAdapters.TB_PRODUTOTableAdapter();
            this.tableAdapterManager = new AplicacaoDeVendas.BDProjetoFinalDataSetTableAdapters.TableAdapterManager();
            this.tB_PRODUTOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tB_PRODUTOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.tB_PRODUTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesquisarProdutoToolStrip = new System.Windows.Forms.ToolStrip();
            this.pesquisarProdutoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.pesquisarProdutoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pesquisarProdutoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            pRO_DESCRICAOLabel = new System.Windows.Forms.Label();
            pRO_ESTOQUELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDProjetoFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_PRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_PRODUTOBindingNavigator)).BeginInit();
            this.tB_PRODUTOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tB_PRODUTODataGridView)).BeginInit();
            this.pesquisarProdutoToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pRO_DESCRICAOLabel
            // 
            pRO_DESCRICAOLabel.AutoSize = true;
            pRO_DESCRICAOLabel.Location = new System.Drawing.Point(3, 281);
            pRO_DESCRICAOLabel.Name = "pRO_DESCRICAOLabel";
            pRO_DESCRICAOLabel.Size = new System.Drawing.Size(47, 13);
            pRO_DESCRICAOLabel.TabIndex = 3;
            pRO_DESCRICAOLabel.Text = "Produto:";
            // 
            // pRO_ESTOQUELabel
            // 
            pRO_ESTOQUELabel.AutoSize = true;
            pRO_ESTOQUELabel.Location = new System.Drawing.Point(3, 307);
            pRO_ESTOQUELabel.Name = "pRO_ESTOQUELabel";
            pRO_ESTOQUELabel.Size = new System.Drawing.Size(65, 13);
            pRO_ESTOQUELabel.TabIndex = 5;
            pRO_ESTOQUELabel.Text = "Quantidade:";
            // 
            // bDProjetoFinalDataSet
            // 
            this.bDProjetoFinalDataSet.DataSetName = "BDProjetoFinalDataSet";
            this.bDProjetoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_PRODUTOBindingSource
            // 
            this.tB_PRODUTOBindingSource.DataMember = "TB_PRODUTO";
            this.tB_PRODUTOBindingSource.DataSource = this.bDProjetoFinalDataSet;
            // 
            // tB_PRODUTOTableAdapter
            // 
            this.tB_PRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TB_CARRINHOTableAdapter = null;
            this.tableAdapterManager.TB_CLIENTETableAdapter = null;
            this.tableAdapterManager.TB_FUNCIONARIOTableAdapter = null;
            this.tableAdapterManager.TB_PRODUTOTableAdapter = this.tB_PRODUTOTableAdapter;
            this.tableAdapterManager.TB_PRODUTOVENDATableAdapter = null;
            this.tableAdapterManager.TB_VENDATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AplicacaoDeVendas.BDProjetoFinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tB_PRODUTOBindingNavigator
            // 
            this.tB_PRODUTOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tB_PRODUTOBindingNavigator.BindingSource = this.tB_PRODUTOBindingSource;
            this.tB_PRODUTOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tB_PRODUTOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tB_PRODUTOBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tB_PRODUTOBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tB_PRODUTOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tB_PRODUTOBindingNavigatorSaveItem});
            this.tB_PRODUTOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tB_PRODUTOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tB_PRODUTOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tB_PRODUTOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tB_PRODUTOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tB_PRODUTOBindingNavigator.Name = "tB_PRODUTOBindingNavigator";
            this.tB_PRODUTOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tB_PRODUTOBindingNavigator.Size = new System.Drawing.Size(271, 25);
            this.tB_PRODUTOBindingNavigator.TabIndex = 0;
            this.tB_PRODUTOBindingNavigator.Text = "bindingNavigator1";
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
            // tB_PRODUTOBindingNavigatorSaveItem
            // 
            this.tB_PRODUTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tB_PRODUTOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tB_PRODUTOBindingNavigatorSaveItem.Image")));
            this.tB_PRODUTOBindingNavigatorSaveItem.Name = "tB_PRODUTOBindingNavigatorSaveItem";
            this.tB_PRODUTOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tB_PRODUTOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tB_PRODUTOBindingNavigatorSaveItem.Click += new System.EventHandler(this.tB_PRODUTOBindingNavigatorSaveItem_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_PRODUTOBindingSource, "PRO_DESCRICAO", true));
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(107, 278);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(164, 20);
            this.txtProduto.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_PRODUTOBindingSource, "PRO_ESTOQUE", true));
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(107, 304);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(44, 20);
            this.txtQuantidade.TabIndex = 6;
            // 
            // tB_PRODUTODataGridView
            // 
            this.tB_PRODUTODataGridView.AllowUserToAddRows = false;
            this.tB_PRODUTODataGridView.AllowUserToDeleteRows = false;
            this.tB_PRODUTODataGridView.AutoGenerateColumns = false;
            this.tB_PRODUTODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tB_PRODUTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tB_PRODUTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tB_PRODUTODataGridView.DataSource = this.tB_PRODUTOBindingSource;
            this.tB_PRODUTODataGridView.Location = new System.Drawing.Point(0, 28);
            this.tB_PRODUTODataGridView.Name = "tB_PRODUTODataGridView";
            this.tB_PRODUTODataGridView.ReadOnly = true;
            this.tB_PRODUTODataGridView.Size = new System.Drawing.Size(348, 220);
            this.tB_PRODUTODataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PRO_CODIGO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PRO_DESCRICAO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRO_ESTOQUE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 71;
            // 
            // pesquisarProdutoToolStrip
            // 
            this.pesquisarProdutoToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.pesquisarProdutoToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.pesquisarProdutoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarProdutoToolStripLabel,
            this.pesquisarProdutoToolStripTextBox,
            this.pesquisarProdutoToolStripButton});
            this.pesquisarProdutoToolStrip.Location = new System.Drawing.Point(271, 0);
            this.pesquisarProdutoToolStrip.Name = "pesquisarProdutoToolStrip";
            this.pesquisarProdutoToolStrip.Size = new System.Drawing.Size(201, 25);
            this.pesquisarProdutoToolStrip.TabIndex = 7;
            this.pesquisarProdutoToolStrip.Text = "pesquisarProdutoToolStrip";
            // 
            // pesquisarProdutoToolStripLabel
            // 
            this.pesquisarProdutoToolStripLabel.Name = "pesquisarProdutoToolStripLabel";
            this.pesquisarProdutoToolStripLabel.Size = new System.Drawing.Size(50, 22);
            this.pesquisarProdutoToolStripLabel.Text = "Produto";
            // 
            // pesquisarProdutoToolStripTextBox
            // 
            this.pesquisarProdutoToolStripTextBox.Name = "pesquisarProdutoToolStripTextBox";
            this.pesquisarProdutoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.pesquisarProdutoToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pesquisarProdutoToolStripTextBox_KeyPress);
            // 
            // pesquisarProdutoToolStripButton
            // 
            this.pesquisarProdutoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pesquisarProdutoToolStripButton.Name = "pesquisarProdutoToolStripButton";
            this.pesquisarProdutoToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.pesquisarProdutoToolStripButton.Text = "Buscar";
            this.pesquisarProdutoToolStripButton.Click += new System.EventHandler(this.pesquisarProdutoToolStripButton_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(483, 299);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 28);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "<< Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 332);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pesquisarProdutoToolStrip);
            this.Controls.Add(this.tB_PRODUTODataGridView);
            this.Controls.Add(pRO_DESCRICAOLabel);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(pRO_ESTOQUELabel);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.tB_PRODUTOBindingNavigator);
            this.Name = "ProdutoView";
            this.Text = "ProdutoView";
            this.Load += new System.EventHandler(this.ProdutoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDProjetoFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_PRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_PRODUTOBindingNavigator)).EndInit();
            this.tB_PRODUTOBindingNavigator.ResumeLayout(false);
            this.tB_PRODUTOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tB_PRODUTODataGridView)).EndInit();
            this.pesquisarProdutoToolStrip.ResumeLayout(false);
            this.pesquisarProdutoToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDProjetoFinalDataSet bDProjetoFinalDataSet;
        private System.Windows.Forms.BindingSource tB_PRODUTOBindingSource;
        private BDProjetoFinalDataSetTableAdapters.TB_PRODUTOTableAdapter tB_PRODUTOTableAdapter;
        private BDProjetoFinalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tB_PRODUTOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tB_PRODUTOBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DataGridView tB_PRODUTODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStrip pesquisarProdutoToolStrip;
        private System.Windows.Forms.ToolStripLabel pesquisarProdutoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox pesquisarProdutoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton pesquisarProdutoToolStripButton;
        private System.Windows.Forms.Button btnVoltar;
    }
}