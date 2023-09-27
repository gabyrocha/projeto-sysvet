namespace cadastroVet
{
    partial class frmAnimais
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
            this.lbNomeAnimal = new System.Windows.Forms.Label();
            this.lbApelidoAnimal = new System.Windows.Forms.Label();
            this.lbDataNascAnimal = new System.Windows.Forms.Label();
            this.lbObsAnimal = new System.Windows.Forms.Label();
            this.lbIdEspecie = new System.Windows.Forms.Label();
            this.tbIdAnimal = new System.Windows.Forms.TextBox();
            this.tbNomeAnimal = new System.Windows.Forms.TextBox();
            this.tbApelidoAnimal = new System.Windows.Forms.TextBox();
            this.tbDataNasc = new System.Windows.Forms.TextBox();
            this.tbObsAnimal = new System.Windows.Forms.TextBox();
            this.tbEspecieAnimal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdAnimal
            // 
            this.lbIdAnimal.AutoSize = true;
            this.lbIdAnimal.Location = new System.Drawing.Point(23, 29);
            this.lbIdAnimal.Name = "lbIdAnimal";
            this.lbIdAnimal.Size = new System.Drawing.Size(65, 13);
            this.lbIdAnimal.TabIndex = 0;
            this.lbIdAnimal.Text = "Id do Animal";
            // 
            // lbNomeAnimal
            // 
            this.lbNomeAnimal.AutoSize = true;
            this.lbNomeAnimal.Location = new System.Drawing.Point(145, 29);
            this.lbNomeAnimal.Name = "lbNomeAnimal";
            this.lbNomeAnimal.Size = new System.Drawing.Size(84, 13);
            this.lbNomeAnimal.TabIndex = 1;
            this.lbNomeAnimal.Text = "Nome do Animal";
            // 
            // lbApelidoAnimal
            // 
            this.lbApelidoAnimal.AutoSize = true;
            this.lbApelidoAnimal.Location = new System.Drawing.Point(262, 30);
            this.lbApelidoAnimal.Name = "lbApelidoAnimal";
            this.lbApelidoAnimal.Size = new System.Drawing.Size(91, 13);
            this.lbApelidoAnimal.TabIndex = 2;
            this.lbApelidoAnimal.Text = "Apelido do Animal";
            // 
            // lbDataNascAnimal
            // 
            this.lbDataNascAnimal.AutoSize = true;
            this.lbDataNascAnimal.Location = new System.Drawing.Point(23, 109);
            this.lbDataNascAnimal.Name = "lbDataNascAnimal";
            this.lbDataNascAnimal.Size = new System.Drawing.Size(104, 13);
            this.lbDataNascAnimal.TabIndex = 3;
            this.lbDataNascAnimal.Text = "Data de Nascimento";
            // 
            // lbObsAnimal
            // 
            this.lbObsAnimal.AutoSize = true;
            this.lbObsAnimal.Location = new System.Drawing.Point(145, 109);
            this.lbObsAnimal.Name = "lbObsAnimal";
            this.lbObsAnimal.Size = new System.Drawing.Size(70, 13);
            this.lbObsAnimal.TabIndex = 4;
            this.lbObsAnimal.Text = "Observações";
            this.lbObsAnimal.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbIdEspecie
            // 
            this.lbIdEspecie.AutoSize = true;
            this.lbIdEspecie.Location = new System.Drawing.Point(262, 109);
            this.lbIdEspecie.Name = "lbIdEspecie";
            this.lbIdEspecie.Size = new System.Drawing.Size(57, 13);
            this.lbIdEspecie.TabIndex = 5;
            this.lbIdEspecie.Text = "Id Espécie";
            // 
            // tbIdAnimal
            // 
            this.tbIdAnimal.Location = new System.Drawing.Point(23, 46);
            this.tbIdAnimal.Name = "tbIdAnimal";
            this.tbIdAnimal.Size = new System.Drawing.Size(83, 20);
            this.tbIdAnimal.TabIndex = 6;
            // 
            // tbNomeAnimal
            // 
            this.tbNomeAnimal.Location = new System.Drawing.Point(148, 46);
            this.tbNomeAnimal.Name = "tbNomeAnimal";
            this.tbNomeAnimal.Size = new System.Drawing.Size(100, 20);
            this.tbNomeAnimal.TabIndex = 7;
            // 
            // tbApelidoAnimal
            // 
            this.tbApelidoAnimal.Location = new System.Drawing.Point(262, 47);
            this.tbApelidoAnimal.Name = "tbApelidoAnimal";
            this.tbApelidoAnimal.Size = new System.Drawing.Size(100, 20);
            this.tbApelidoAnimal.TabIndex = 8;
            // 
            // tbDataNasc
            // 
            this.tbDataNasc.Location = new System.Drawing.Point(21, 125);
            this.tbDataNasc.Name = "tbDataNasc";
            this.tbDataNasc.Size = new System.Drawing.Size(100, 20);
            this.tbDataNasc.TabIndex = 9;
            // 
            // tbObsAnimal
            // 
            this.tbObsAnimal.Location = new System.Drawing.Point(145, 126);
            this.tbObsAnimal.Name = "tbObsAnimal";
            this.tbObsAnimal.Size = new System.Drawing.Size(100, 20);
            this.tbObsAnimal.TabIndex = 10;
            // 
            // tbEspecieAnimal
            // 
            this.tbEspecieAnimal.Location = new System.Drawing.Point(265, 126);
            this.tbEspecieAnimal.Name = "tbEspecieAnimal";
            this.tbEspecieAnimal.Size = new System.Drawing.Size(100, 20);
            this.tbEspecieAnimal.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 239);
            this.dataGridView1.TabIndex = 12;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(396, 30);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 13;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(396, 59);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 14;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(396, 88);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 15;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btListar
            // 
            this.btListar.Location = new System.Drawing.Point(396, 117);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(75, 23);
            this.btListar.TabIndex = 16;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = true;
            // 
            // frmAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbEspecieAnimal);
            this.Controls.Add(this.tbObsAnimal);
            this.Controls.Add(this.tbDataNasc);
            this.Controls.Add(this.tbApelidoAnimal);
            this.Controls.Add(this.tbNomeAnimal);
            this.Controls.Add(this.tbIdAnimal);
            this.Controls.Add(this.lbIdEspecie);
            this.Controls.Add(this.lbObsAnimal);
            this.Controls.Add(this.lbDataNascAnimal);
            this.Controls.Add(this.lbApelidoAnimal);
            this.Controls.Add(this.lbNomeAnimal);
            this.Controls.Add(this.lbIdAnimal);
            this.Name = "frmAnimais";
            this.Text = "Cadastro de Animais";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdAnimal;
        private System.Windows.Forms.Label lbNomeAnimal;
        private System.Windows.Forms.Label lbApelidoAnimal;
        private System.Windows.Forms.Label lbDataNascAnimal;
        private System.Windows.Forms.Label lbObsAnimal;
        private System.Windows.Forms.Label lbIdEspecie;
        private System.Windows.Forms.TextBox tbIdAnimal;
        private System.Windows.Forms.TextBox tbNomeAnimal;
        private System.Windows.Forms.TextBox tbApelidoAnimal;
        private System.Windows.Forms.TextBox tbDataNasc;
        private System.Windows.Forms.TextBox tbObsAnimal;
        private System.Windows.Forms.TextBox tbEspecieAnimal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btListar;
    }
}