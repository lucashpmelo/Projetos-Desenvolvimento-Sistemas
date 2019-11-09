namespace ADO_NETProject01
{
    partial class FormNotasEntrada
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
            this.btnGravarNota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGravarNota
            // 
            this.btnGravarNota.Location = new System.Drawing.Point(497, 72);
            this.btnGravarNota.Name = "btnGravarNota";
            this.btnGravarNota.Size = new System.Drawing.Size(75, 23);
            this.btnGravarNota.TabIndex = 0;
            this.btnGravarNota.Text = "Gravar";
            this.btnGravarNota.UseVisualStyleBackColor = true;
            this.btnGravarNota.Click += new System.EventHandler(this.btnGravarNota_Click);
            // 
            // FormNotasEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGravarNota);
            this.Name = "FormNotasEntrada";
            this.Text = "NotasEntradaCRUD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGravarNota;
    }
}