namespace cadastroVet
{
    partial class frmEspecies
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
            this.lbIdAnimal = new System.Windows.Forms.Label();
            this.lbIdEspecie = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdAnimal
            // 
            this.lbIdAnimal.AutoSize = true;
            this.lbIdAnimal.Location = new System.Drawing.Point(28, 43);
            this.lbIdAnimal.Name = "lbIdAnimal";
            this.lbIdAnimal.Size = new System.Drawing.Size(91, 13);
            this.lbIdAnimal.TabIndex = 0;
            this.lbIdAnimal.Text = "Nome da Espécie";
            // 
            // lbIdEspecie
            // 
            this.lbIdEspecie.AutoSize = true;
            this.lbIdEspecie.Location = new System.Drawing.Point(159, 43);
            this.lbIdEspecie.Name = "lbIdEspecie";
            this.lbIdEspecie.Size = new System.Drawing.Size(72, 13);
            this.lbIdEspecie.TabIndex = 1;
            this.lbIdEspecie.Text = "Id da Espécie";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 182);
            this.dataGridView1.TabIndex = 4;
            // 
            // frmEspecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 313);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbIdEspecie);
            this.Controls.Add(this.lbIdAnimal);
            this.Name = "frmEspecies";
            this.Text = "Cadastro de Especies";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdAnimal;
        private System.Windows.Forms.Label lbIdEspecie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}