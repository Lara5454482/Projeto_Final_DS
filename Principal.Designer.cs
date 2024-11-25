
namespace Projeto_Final
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.rEGISTROToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 12, 0, 12);
            this.menuStrip1.Size = new System.Drawing.Size(568, 49);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 25);
            // 
            // rEGISTROToolStripMenuItem
            // 
            this.rEGISTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salasToolStripMenuItem,
            this.projetosToolStripMenuItem});
            this.rEGISTROToolStripMenuItem.Name = "rEGISTROToolStripMenuItem";
            this.rEGISTROToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.rEGISTROToolStripMenuItem.Text = "Cadastrar";
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.salasToolStripMenuItem.Text = "Alunos";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrarToolStripMenuItem,
            this.cadastrarNovoUsuárioToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // cadastrarNovoUsuárioToolStripMenuItem
            // 
            this.cadastrarNovoUsuárioToolStripMenuItem.Name = "cadastrarNovoUsuárioToolStripMenuItem";
            this.cadastrarNovoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.cadastrarNovoUsuárioToolStripMenuItem.Text = "Gerenciar Usuários (Admin)";
            // 
            // entrarToolStripMenuItem
            // 
            this.entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            this.entrarToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.entrarToolStripMenuItem.Text = "Cadastrar Novo Usuário";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 295);
            this.dataGridView1.TabIndex = 19;
            // 
            // projetosToolStripMenuItem
            // 
            this.projetosToolStripMenuItem.Name = "projetosToolStripMenuItem";
            this.projetosToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.projetosToolStripMenuItem.Text = "Projetos";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rEGISTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}