namespace wfa_ui
{
    partial class frmCadastroAnimais
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
            this.lbAniId = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbApelido = new System.Windows.Forms.Label();
            this.lbDataNasc = new System.Windows.Forms.Label();
            this.lbAniObs = new System.Windows.Forms.Label();
            this.lbEspId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAniId
            // 
            this.lbAniId.AutoSize = true;
            this.lbAniId.Location = new System.Drawing.Point(31, 35);
            this.lbAniId.Name = "lbAniId";
            this.lbAniId.Size = new System.Drawing.Size(65, 13);
            this.lbAniId.TabIndex = 0;
            this.lbAniId.Text = "Id do Animal";
            this.lbAniId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(151, 35);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(84, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome do Animal";
            this.lbNome.Click += new System.EventHandler(this.lbNome_Click);
            // 
            // lbApelido
            // 
            this.lbApelido.AutoSize = true;
            this.lbApelido.Location = new System.Drawing.Point(375, 35);
            this.lbApelido.Name = "lbApelido";
            this.lbApelido.Size = new System.Drawing.Size(42, 13);
            this.lbApelido.TabIndex = 2;
            this.lbApelido.Text = "Apelido";
            this.lbApelido.Click += new System.EventHandler(this.lbApelido_Click);
            // 
            // lbDataNasc
            // 
            this.lbDataNasc.AutoSize = true;
            this.lbDataNasc.Location = new System.Drawing.Point(31, 94);
            this.lbDataNasc.Name = "lbDataNasc";
            this.lbDataNasc.Size = new System.Drawing.Size(104, 13);
            this.lbDataNasc.TabIndex = 3;
            this.lbDataNasc.Text = "Data de Nascimento";
            this.lbDataNasc.Click += new System.EventHandler(this.lbDataNasc_Click);
            // 
            // lbAniObs
            // 
            this.lbAniObs.AutoSize = true;
            this.lbAniObs.Location = new System.Drawing.Point(151, 94);
            this.lbAniObs.Name = "lbAniObs";
            this.lbAniObs.Size = new System.Drawing.Size(65, 13);
            this.lbAniObs.TabIndex = 4;
            this.lbAniObs.Text = "Observação";
            // 
            // lbEspId
            // 
            this.lbEspId.AutoSize = true;
            this.lbEspId.Location = new System.Drawing.Point(375, 94);
            this.lbEspId.Name = "lbEspId";
            this.lbEspId.Size = new System.Drawing.Size(72, 13);
            this.lbEspId.TabIndex = 5;
            this.lbEspId.Text = "Id da Espécie";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(34, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(378, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(35, 110);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(154, 110);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(196, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(378, 110);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(500, 30);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 12;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(500, 59);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 13;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(500, 89);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 14;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(500, 118);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 15;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // frmCadastroAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 170);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbEspId);
            this.Controls.Add(this.lbAniObs);
            this.Controls.Add(this.lbDataNasc);
            this.Controls.Add(this.lbApelido);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbAniId);
            this.Name = "frmCadastroAnimais";
            this.Text = ". : : Cadastro de Animais : : .";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAniId;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbApelido;
        private System.Windows.Forms.Label lbDataNasc;
        private System.Windows.Forms.Label lbAniObs;
        private System.Windows.Forms.Label lbEspId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btPesquisar;
    }
}