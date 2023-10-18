namespace wfa_ui
{
    partial class frmAnimalPesquisa
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
            this.gridPesquisa = new System.Windows.Forms.DataGridView();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPesquisa
            // 
            this.gridPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesquisa.Location = new System.Drawing.Point(24, 23);
            this.gridPesquisa.Name = "gridPesquisa";
            this.gridPesquisa.Size = new System.Drawing.Size(644, 298);
            this.gridPesquisa.TabIndex = 0;
            // 
            // btSelecionar
            // 
            this.btSelecionar.Location = new System.Drawing.Point(497, 337);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btSelecionar.TabIndex = 1;
            this.btSelecionar.Text = "Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = true;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(592, 337);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 2;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // frmAnimalPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 373);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.gridPesquisa);
            this.Name = "frmAnimalPesquisa";
            this.Text = ". : : Pesquisa de Animais : : .";
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPesquisa;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btVoltar;
    }
}