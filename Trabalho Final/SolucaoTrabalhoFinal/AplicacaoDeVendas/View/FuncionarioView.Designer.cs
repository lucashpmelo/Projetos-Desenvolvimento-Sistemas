namespace AplicacaoDeVendas.View
{
    partial class FuncionarioView
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
            System.Windows.Forms.Label fUN_NOMELabel;
            System.Windows.Forms.Label fUN_RGLabel;
            System.Windows.Forms.Label fUN_CPFLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionarioView));
            this.bDProjetoFinalDataSet = new AplicacaoDeVendas.BDProjetoFinalDataSet();
            this.tB_FUNCIONARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_FUNCIONARIOTableAdapter = new AplicacaoDeVendas.BDProjetoFinalDataSetTableAdapters.TB_FUNCIONARIOTableAdapter();
            this.tableAdapterManager = new AplicacaoDeVendas.BDProjetoFinalDataSetTableAdapters.TableAdapterManager();
            this.tB_FUNCIONARIOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tB_FUNCIONARIOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.tB_FUNCIONARIODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.pesquisarNomeToolStrip = new System.Windows.Forms.ToolStrip();
            this.pesquisarNomeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.pesquisarNomeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pesquisarNomeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            fUN_NOMELabel = new System.Windows.Forms.Label();
            fUN_RGLabel = new System.Windows.Forms.Label();
            fUN_CPFLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDProjetoFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_FUNCIONARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_FUNCIONARIOBindingNavigator)).BeginInit();
            this.tB_FUNCIONARIOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tB_FUNCIONARIODataGridView)).BeginInit();
            this.pesquisarNomeToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fUN_NOMELabel
            // 
            fUN_NOMELabel.AutoSize = true;
            fUN_NOMELabel.Location = new System.Drawing.Point(12, 281);
            fUN_NOMELabel.Name = "fUN_NOMELabel";
            fUN_NOMELabel.Size = new System.Drawing.Size(38, 13);
            fUN_NOMELabel.TabIndex = 3;
            fUN_NOMELabel.Text = "Nome:";
            // 
            // fUN_RGLabel
            // 
            fUN_RGLabel.AutoSize = true;
            fUN_RGLabel.Location = new System.Drawing.Point(12, 333);
            fUN_RGLabel.Name = "fUN_RGLabel";
            fUN_RGLabel.Size = new System.Drawing.Size(26, 13);
            fUN_RGLabel.TabIndex = 7;
            fUN_RGLabel.Text = "RG:";
            // 
            // fUN_CPFLabel
            // 
            fUN_CPFLabel.AutoSize = true;
            fUN_CPFLabel.Location = new System.Drawing.Point(12, 308);
            fUN_CPFLabel.Name = "fUN_CPFLabel";
            fUN_CPFLabel.Size = new System.Drawing.Size(30, 13);
            fUN_CPFLabel.TabIndex = 8;
            fUN_CPFLabel.Text = "CPF:";
            // 
            // bDProjetoFinalDataSet
            // 
            this.bDProjetoFinalDataSet.DataSetName = "BDProjetoFinalDataSet";
            this.bDProjetoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_FUNCIONARIOBindingSource
            // 
            this.tB_FUNCIONARIOBindingSource.DataMember = "TB_FUNCIONARIO";
            this.tB_FUNCIONARIOBindingSource.DataSource = this.bDProjetoFinalDataSet;
            // 
            // tB_FUNCIONARIOTableAdapter
            // 
            this.tB_FUNCIONARIOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TB_CARRINHOTableAdapter = null;
            this.tableAdapterManager.TB_CLIENTETableAdapter = null;
            this.tableAdapterManager.TB_FUNCIONARIOTableAdapter = this.tB_FUNCIONARIOTableAdapter;
            this.tableAdapterManager.TB_PRODUTOTableAdapter = null;
            this.tableAdapterManager.TB_PRODUTOVENDATableAdapter = null;
            this.tableAdapterManager.TB_VENDATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AplicacaoDeVendas.BDProjetoFinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tB_FUNCIONARIOBindingNavigator
            // 
            this.tB_FUNCIONARIOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tB_FUNCIONARIOBindingNavigator.BindingSource = this.tB_FUNCIONARIOBindingSource;
            this.tB_FUNCIONARIOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tB_FUNCIONARIOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tB_FUNCIONARIOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tB_FUNCIONARIOBindingNavigatorSaveItem});
            this.tB_FUNCIONARIOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tB_FUNCIONARIOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tB_FUNCIONARIOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tB_FUNCIONARIOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tB_FUNCIONARIOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tB_FUNCIONARIOBindingNavigator.Name = "tB_FUNCIONARIOBindingNavigator";
            this.tB_FUNCIONARIOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tB_FUNCIONARIOBindingNavigator.Size = new System.Drawing.Size(694, 25);
            this.tB_FUNCIONARIOBindingNavigator.TabIndex = 0;
            this.tB_FUNCIONARIOBindingNavigator.Text = "bindingNavigator1";
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
            // tB_FUNCIONARIOBindingNavigatorSaveItem
            // 
            this.tB_FUNCIONARIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tB_FUNCIONARIOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tB_FUNCIONARIOBindingNavigatorSaveItem.Image")));
            this.tB_FUNCIONARIOBindingNavigatorSaveItem.Name = "tB_FUNCIONARIOBindingNavigatorSaveItem";
            this.tB_FUNCIONARIOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tB_FUNCIONARIOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tB_FUNCIONARIOBindingNavigatorSaveItem.Click += new System.EventHandler(this.tB_FUNCIONARIOBindingNavigatorSaveItem_Click);
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_FUNCIONARIOBindingSource, "FUN_NOME", true));
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(95, 278);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(219, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtRG
            // 
            this.txtRG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_FUNCIONARIOBindingSource, "FUN_RG", true));
            this.txtRG.Enabled = false;
            this.txtRG.Location = new System.Drawing.Point(95, 330);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(95, 20);
            this.txtRG.TabIndex = 8;
            // 
            // tB_FUNCIONARIODataGridView
            // 
            this.tB_FUNCIONARIODataGridView.AllowUserToAddRows = false;
            this.tB_FUNCIONARIODataGridView.AllowUserToDeleteRows = false;
            this.tB_FUNCIONARIODataGridView.AutoGenerateColumns = false;
            this.tB_FUNCIONARIODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tB_FUNCIONARIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tB_FUNCIONARIODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tB_FUNCIONARIODataGridView.DataSource = this.tB_FUNCIONARIOBindingSource;
            this.tB_FUNCIONARIODataGridView.Location = new System.Drawing.Point(0, 28);
            this.tB_FUNCIONARIODataGridView.Name = "tB_FUNCIONARIODataGridView";
            this.tB_FUNCIONARIODataGridView.ReadOnly = true;
            this.tB_FUNCIONARIODataGridView.Size = new System.Drawing.Size(448, 220);
            this.tB_FUNCIONARIODataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FUN_CODIGO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FUN_NOME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FUN_CPF";
            this.dataGridViewTextBoxColumn3.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 52;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FUN_RG";
            this.dataGridViewTextBoxColumn4.HeaderText = "RG";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 48;
            // 
            // txtCPF
            // 
            this.txtCPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_FUNCIONARIOBindingSource, "FUN_CPF", true));
            this.txtCPF.Enabled = false;
            this.txtCPF.Location = new System.Drawing.Point(95, 305);
            this.txtCPF.Mask = "###.###.###-##";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(95, 20);
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
            this.pesquisarNomeToolStrip.Location = new System.Drawing.Point(275, 0);
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
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(581, 325);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 28);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "<< Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FuncionarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 358);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pesquisarNomeToolStrip);
            this.Controls.Add(fUN_CPFLabel);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.tB_FUNCIONARIODataGridView);
            this.Controls.Add(fUN_NOMELabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(fUN_RGLabel);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.tB_FUNCIONARIOBindingNavigator);
            this.Name = "FuncionarioView";
            this.Text = "FuncionarioView";
            this.Load += new System.EventHandler(this.FuncionarioView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDProjetoFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_FUNCIONARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_FUNCIONARIOBindingNavigator)).EndInit();
            this.tB_FUNCIONARIOBindingNavigator.ResumeLayout(false);
            this.tB_FUNCIONARIOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tB_FUNCIONARIODataGridView)).EndInit();
            this.pesquisarNomeToolStrip.ResumeLayout(false);
            this.pesquisarNomeToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDProjetoFinalDataSet bDProjetoFinalDataSet;
        private System.Windows.Forms.BindingSource tB_FUNCIONARIOBindingSource;
        private BDProjetoFinalDataSetTableAdapters.TB_FUNCIONARIOTableAdapter tB_FUNCIONARIOTableAdapter;
        private BDProjetoFinalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tB_FUNCIONARIOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tB_FUNCIONARIOBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.DataGridView tB_FUNCIONARIODataGridView;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStrip pesquisarNomeToolStrip;
        private System.Windows.Forms.ToolStripLabel pesquisarNomeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox pesquisarNomeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton pesquisarNomeToolStripButton;
        private System.Windows.Forms.Button btnVoltar;
    }
}