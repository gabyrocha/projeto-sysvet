namespace cadastroClientes
{
    partial class frmCadastroCliente
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
            this.lbIdCliente = new System.Windows.Forms.Label();
            this.tbIdCliente = new System.Windows.Forms.TextBox();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbData = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdCliente
            // 
            this.lbIdCliente.AutoSize = true;
            this.lbIdCliente.Location = new System.Drawing.Point(13, 9);
            this.lbIdCliente.Name = "lbIdCliente";
            this.lbIdCliente.Size = new System.Drawing.Size(66, 13);
            this.lbIdCliente.TabIndex = 0;
            this.lbIdCliente.Text = "Id do Cliente";
            this.lbIdCliente.Click += new System.EventHandler(this.lbId_Click);
            // 
            // tbIdCliente
            // 
            this.tbIdCliente.BackColor = System.Drawing.Color.LightGray;
            this.tbIdCliente.Enabled = false;
            this.tbIdCliente.Location = new System.Drawing.Point(16, 29);
            this.tbIdCliente.Name = "tbIdCliente";
            this.tbIdCliente.Size = new System.Drawing.Size(113, 20);
            this.tbIdCliente.TabIndex = 1;
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(145, 9);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(85, 13);
            this.lbNomeCliente.TabIndex = 2;
            this.lbNomeCliente.Text = "Nome do Cliente";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(316, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(13, 70);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(27, 13);
            this.lbCpf.TabIndex = 4;
            this.lbCpf.Text = "CPF";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(145, 70);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "E-mail";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(316, 20);
            this.textBox3.TabIndex = 7;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(13, 125);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(90, 13);
            this.lbData.TabIndex = 8;
            this.lbData.Text = "Data do Cadastro";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(113, 20);
            this.textBox4.TabIndex = 9;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(148, 137);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 10;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(389, 195);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 12;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(389, 224);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 13;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(389, 253);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(389, 282);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 15;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(389, 311);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 16;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(389, 340);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 17;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPeqsuisar_Click);
            // 
            // gridClientes
            // 
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Location = new System.Drawing.Point(16, 195);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.Size = new System.Drawing.Size(354, 168);
            this.gridClientes.TabIndex = 18;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 379);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbNomeCliente);
            this.Controls.Add(this.tbIdCliente);
            this.Controls.Add(this.lbIdCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroCliente";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdCliente;
        private System.Windows.Forms.TextBox tbIdCliente;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.DataGridView gridClientes;
    }
}

