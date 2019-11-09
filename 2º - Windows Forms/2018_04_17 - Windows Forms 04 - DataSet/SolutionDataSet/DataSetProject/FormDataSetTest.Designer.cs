namespace DataSetProject
{
    partial class FormDataSetTest
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
            this.btnCriarDataSet = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnControle = new System.Windows.Forms.Button();
            this.tcResultados = new System.Windows.Forms.TabControl();
            this.tpXML = new System.Windows.Forms.TabPage();
            this.tpComboEGrid = new System.Windows.Forms.TabPage();
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgCidades = new System.Windows.Forms.DataGridView();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.tcResultados.SuspendLayout();
            this.tpXML.SuspendLayout();
            this.tpComboEGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarDataSet
            // 
            this.btnCriarDataSet.Location = new System.Drawing.Point(42, 12);
            this.btnCriarDataSet.Name = "btnCriarDataSet";
            this.btnCriarDataSet.Size = new System.Drawing.Size(99, 23);
            this.btnCriarDataSet.TabIndex = 0;
            this.btnCriarDataSet.Text = "Criar DataSet";
            this.btnCriarDataSet.UseVisualStyleBackColor = true;
            this.btnCriarDataSet.Click += new System.EventHandler(this.btnCriarDataSet_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(158, 12);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(99, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir dados";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(273, 12);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(99, 23);
            this.btnVisualizar.TabIndex = 2;
            this.btnVisualizar.Text = "Visualizar XML";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnControle
            // 
            this.btnControle.Location = new System.Drawing.Point(390, 12);
            this.btnControle.Name = "btnControle";
            this.btnControle.Size = new System.Drawing.Size(99, 23);
            this.btnControle.TabIndex = 3;
            this.btnControle.Text = "Controle Visuais";
            this.btnControle.UseVisualStyleBackColor = true;
            this.btnControle.Click += new System.EventHandler(this.btnControle_Click);
            // 
            // tcResultados
            // 
            this.tcResultados.Controls.Add(this.tpXML);
            this.tcResultados.Controls.Add(this.tpComboEGrid);
            this.tcResultados.Location = new System.Drawing.Point(42, 63);
            this.tcResultados.Name = "tcResultados";
            this.tcResultados.SelectedIndex = 0;
            this.tcResultados.Size = new System.Drawing.Size(447, 241);
            this.tcResultados.TabIndex = 4;
            // 
            // tpXML
            // 
            this.tpXML.Controls.Add(this.txtXML);
            this.tpXML.Location = new System.Drawing.Point(4, 22);
            this.tpXML.Name = "tpXML";
            this.tpXML.Padding = new System.Windows.Forms.Padding(3);
            this.tpXML.Size = new System.Drawing.Size(439, 215);
            this.tpXML.TabIndex = 0;
            this.tpXML.Text = "Dados em XML";
            this.tpXML.UseVisualStyleBackColor = true;
            // 
            // tpComboEGrid
            // 
            this.tpComboEGrid.Controls.Add(this.dgCidades);
            this.tpComboEGrid.Controls.Add(this.label1);
            this.tpComboEGrid.Controls.Add(this.cbEstados);
            this.tpComboEGrid.Location = new System.Drawing.Point(4, 22);
            this.tpComboEGrid.Name = "tpComboEGrid";
            this.tpComboEGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tpComboEGrid.Size = new System.Drawing.Size(439, 215);
            this.tpComboEGrid.TabIndex = 1;
            this.tpComboEGrid.Text = "Dados em Controles";
            this.tpComboEGrid.UseVisualStyleBackColor = true;
            // 
            // cbEstados
            // 
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Location = new System.Drawing.Point(61, 3);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(372, 21);
            this.cbEstados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estados:";
            // 
            // dgCidades
            // 
            this.dgCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCidades.Location = new System.Drawing.Point(10, 33);
            this.dgCidades.Name = "dgCidades";
            this.dgCidades.Size = new System.Drawing.Size(423, 150);
            this.dgCidades.TabIndex = 2;
            // 
            // txtXML
            // 
            this.txtXML.Location = new System.Drawing.Point(7, 7);
            this.txtXML.Multiline = true;
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(426, 202);
            this.txtXML.TabIndex = 0;
            // 
            // FormDataSetTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 309);
            this.Controls.Add(this.tcResultados);
            this.Controls.Add(this.btnControle);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnCriarDataSet);
            this.Name = "FormDataSetTest";
            this.Text = "Teste com DataSet e seus componentes";
            this.tcResultados.ResumeLayout(false);
            this.tpXML.ResumeLayout(false);
            this.tpXML.PerformLayout();
            this.tpComboEGrid.ResumeLayout(false);
            this.tpComboEGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarDataSet;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnControle;
        private System.Windows.Forms.TabControl tcResultados;
        private System.Windows.Forms.TabPage tpXML;
        private System.Windows.Forms.TabPage tpComboEGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstados;
        private System.Windows.Forms.DataGridView dgCidades;
        private System.Windows.Forms.TextBox txtXML;
    }
}