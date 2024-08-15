namespace sisBiblioteca
{
    partial class frmAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.tbendereco = new System.Windows.Forms.TextBox();
            this.tbnumero = new System.Windows.Forms.TextBox();
            this.tbcelular = new System.Windows.Forms.TextBox();
            this.dtnascimento = new System.Windows.Forms.DateTimePicker();
            this.btgravar = new System.Windows.Forms.Button();
            this.btlocaliza = new System.Windows.Forms.Button();
            this.plocaliza = new System.Windows.Forms.Panel();
            this.dgvaluno = new System.Windows.Forms.DataGridView();
            this.tblocaliza = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gbOpcao = new System.Windows.Forms.GroupBox();
            this.rbExluir = new System.Windows.Forms.RadioButton();
            this.rbAlterar = new System.Windows.Forms.RadioButton();
            this.plocaliza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaluno)).BeginInit();
            this.gbOpcao.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Celular";
            // 
            // tbcodigo
            // 
            this.tbcodigo.Location = new System.Drawing.Point(70, 69);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.ReadOnly = true;
            this.tbcodigo.Size = new System.Drawing.Size(100, 20);
            this.tbcodigo.TabIndex = 6;
            this.tbcodigo.TextChanged += new System.EventHandler(this.tbcodigo_TextChanged);
            // 
            // tbnome
            // 
            this.tbnome.Location = new System.Drawing.Point(70, 122);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(190, 20);
            this.tbnome.TabIndex = 0;
            // 
            // tbendereco
            // 
            this.tbendereco.Location = new System.Drawing.Point(70, 228);
            this.tbendereco.Name = "tbendereco";
            this.tbendereco.Size = new System.Drawing.Size(190, 20);
            this.tbendereco.TabIndex = 9;
            // 
            // tbnumero
            // 
            this.tbnumero.Location = new System.Drawing.Point(70, 281);
            this.tbnumero.Name = "tbnumero";
            this.tbnumero.Size = new System.Drawing.Size(190, 20);
            this.tbnumero.TabIndex = 10;
            // 
            // tbcelular
            // 
            this.tbcelular.Location = new System.Drawing.Point(70, 334);
            this.tbcelular.Name = "tbcelular";
            this.tbcelular.Size = new System.Drawing.Size(190, 20);
            this.tbcelular.TabIndex = 11;
            // 
            // dtnascimento
            // 
            this.dtnascimento.Location = new System.Drawing.Point(70, 176);
            this.dtnascimento.Name = "dtnascimento";
            this.dtnascimento.Size = new System.Drawing.Size(200, 20);
            this.dtnascimento.TabIndex = 12;
            // 
            // btgravar
            // 
            this.btgravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgravar.Location = new System.Drawing.Point(70, 427);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(189, 40);
            this.btgravar.TabIndex = 13;
            this.btgravar.Text = "C o n f i r m a r";
            this.btgravar.UseVisualStyleBackColor = true;
            this.btgravar.Click += new System.EventHandler(this.btgravar_Click);
            // 
            // btlocaliza
            // 
            this.btlocaliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlocaliza.Location = new System.Drawing.Point(292, 427);
            this.btlocaliza.Name = "btlocaliza";
            this.btlocaliza.Size = new System.Drawing.Size(178, 41);
            this.btlocaliza.TabIndex = 14;
            this.btlocaliza.Text = "L o c a l i z a r";
            this.btlocaliza.UseVisualStyleBackColor = true;
            this.btlocaliza.Click += new System.EventHandler(this.btlocaliza_Click);
            // 
            // plocaliza
            // 
            this.plocaliza.Controls.Add(this.dgvaluno);
            this.plocaliza.Controls.Add(this.tblocaliza);
            this.plocaliza.Controls.Add(this.label7);
            this.plocaliza.Location = new System.Drawing.Point(292, 53);
            this.plocaliza.Name = "plocaliza";
            this.plocaliza.Size = new System.Drawing.Size(497, 315);
            this.plocaliza.TabIndex = 15;
            this.plocaliza.Visible = false;
            // 
            // dgvaluno
            // 
            this.dgvaluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvaluno.Location = new System.Drawing.Point(13, 56);
            this.dgvaluno.Name = "dgvaluno";
            this.dgvaluno.Size = new System.Drawing.Size(475, 236);
            this.dgvaluno.TabIndex = 2;
            this.dgvaluno.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvaluno_CellDoubleClick);
            // 
            // tblocaliza
            // 
            this.tblocaliza.Location = new System.Drawing.Point(13, 30);
            this.tblocaliza.Name = "tblocaliza";
            this.tblocaliza.Size = new System.Drawing.Size(475, 20);
            this.tblocaliza.TabIndex = 1;
            this.tblocaliza.TextChanged += new System.EventHandler(this.tblocaliza_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Localizar";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(67, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gbOpcao
            // 
            this.gbOpcao.Controls.Add(this.rbExluir);
            this.gbOpcao.Controls.Add(this.rbAlterar);
            this.gbOpcao.Location = new System.Drawing.Point(70, 371);
            this.gbOpcao.Name = "gbOpcao";
            this.gbOpcao.Size = new System.Drawing.Size(189, 50);
            this.gbOpcao.TabIndex = 17;
            this.gbOpcao.TabStop = false;
            this.gbOpcao.Text = "Opção Operação";
            this.gbOpcao.Visible = false;
            this.gbOpcao.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbExluir
            // 
            this.rbExluir.AutoSize = true;
            this.rbExluir.Location = new System.Drawing.Point(112, 24);
            this.rbExluir.Name = "rbExluir";
            this.rbExluir.Size = new System.Drawing.Size(56, 17);
            this.rbExluir.TabIndex = 1;
            this.rbExluir.Text = "Excluir";
            this.rbExluir.UseVisualStyleBackColor = true;
            // 
            // rbAlterar
            // 
            this.rbAlterar.AutoSize = true;
            this.rbAlterar.Checked = true;
            this.rbAlterar.Location = new System.Drawing.Point(17, 24);
            this.rbAlterar.Name = "rbAlterar";
            this.rbAlterar.Size = new System.Drawing.Size(55, 17);
            this.rbAlterar.TabIndex = 0;
            this.rbAlterar.TabStop = true;
            this.rbAlterar.Text = "Alterar";
            this.rbAlterar.UseVisualStyleBackColor = true;
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 502);
            this.Controls.Add(this.gbOpcao);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.plocaliza);
            this.Controls.Add(this.btlocaliza);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.dtnascimento);
            this.Controls.Add(this.tbcelular);
            this.Controls.Add(this.tbnumero);
            this.Controls.Add(this.tbendereco);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluno";
            this.Load += new System.EventHandler(this.frmAluno_Load);
            this.plocaliza.ResumeLayout(false);
            this.plocaliza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaluno)).EndInit();
            this.gbOpcao.ResumeLayout(false);
            this.gbOpcao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.TextBox tbendereco;
        private System.Windows.Forms.TextBox tbnumero;
        private System.Windows.Forms.TextBox tbcelular;
        private System.Windows.Forms.DateTimePicker dtnascimento;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btlocaliza;
        private System.Windows.Forms.Panel plocaliza;
        private System.Windows.Forms.TextBox tblocaliza;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvaluno;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gbOpcao;
        private System.Windows.Forms.RadioButton rbExluir;
        private System.Windows.Forms.RadioButton rbAlterar;
    }
}