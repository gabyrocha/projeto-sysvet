namespace wfa_ui
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.animaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.espéciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPesquisa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCadastro,
            this.mnPesquisa});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnCadastro
            // 
            this.mnCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animaisToolStripMenuItem,
            this.clientesToolStripMenuItem1,
            this.espéciesToolStripMenuItem});
            this.mnCadastro.Name = "mnCadastro";
            this.mnCadastro.Size = new System.Drawing.Size(71, 20);
            this.mnCadastro.Text = "Cadastros";
            this.mnCadastro.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // animaisToolStripMenuItem
            // 
            this.animaisToolStripMenuItem.Name = "animaisToolStripMenuItem";
            this.animaisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.animaisToolStripMenuItem.Text = "Animais";
            this.animaisToolStripMenuItem.Click += new System.EventHandler(this.animaisToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // espéciesToolStripMenuItem
            // 
            this.espéciesToolStripMenuItem.Name = "espéciesToolStripMenuItem";
            this.espéciesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.espéciesToolStripMenuItem.Text = "Espécies";
            this.espéciesToolStripMenuItem.Click += new System.EventHandler(this.espéciesToolStripMenuItem_Click);
            // 
            // mnPesquisa
            // 
            this.mnPesquisa.Name = "mnPesquisa";
            this.mnPesquisa.Size = new System.Drawing.Size(65, 20);
            this.mnPesquisa.Text = "Pesquisa";
            this.mnPesquisa.Click += new System.EventHandler(this.mnPesquisa_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ". : : SysVET - Sistema de Cadastro Veterinário : : .        RA: N432373 Gabriele " +
    "Lorene da Rocha da Silva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnCadastro;
        private System.Windows.Forms.ToolStripMenuItem animaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem espéciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnPesquisa;
    }
}

