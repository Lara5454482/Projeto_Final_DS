namespace Projeto_Final.Formularios
{
    partial class FrmDetalhes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProjetos = new System.Windows.Forms.ComboBox();
            this.dataGridViewAlunos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione um Projeto:";
            // 
            // comboBoxProjetos
            // 
            this.comboBoxProjetos.FormattingEnabled = true;
            this.comboBoxProjetos.Location = new System.Drawing.Point(44, 72);
            this.comboBoxProjetos.Name = "comboBoxProjetos";
            this.comboBoxProjetos.Size = new System.Drawing.Size(300, 21);
            this.comboBoxProjetos.TabIndex = 1;
            this.comboBoxProjetos.SelectedIndexChanged += new System.EventHandler(this.comboBoxProjetos_SelectedIndexChanged);
            // 
            // dataGridViewAlunos
            // 
            this.dataGridViewAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlunos.Location = new System.Drawing.Point(51, 132);
            this.dataGridViewAlunos.Name = "dataGridViewAlunos";
            this.dataGridViewAlunos.Size = new System.Drawing.Size(688, 266);
            this.dataGridViewAlunos.TabIndex = 2;
            // 
            // FrmDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewAlunos);
            this.Controls.Add(this.comboBoxProjetos);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetalhes";
            this.Text = "Detalhes do Projeto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProjetos;
        private System.Windows.Forms.DataGridView dataGridViewAlunos;
    }
}
