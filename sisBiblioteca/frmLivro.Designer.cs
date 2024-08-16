namespace sisBiblioteca
{
    partial class frmLivro
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
            this.btlimpar = new System.Windows.Forms.Button();
            this.gbprocedimento = new System.Windows.Forms.GroupBox();
            this.rbcadastrar = new System.Windows.Forms.RadioButton();
            this.rbexcluir = new System.Windows.Forms.RadioButton();
            this.rbalterar = new System.Windows.Forms.RadioButton();
            this.plocaliza = new System.Windows.Forms.Panel();
            this.lbselecionar = new System.Windows.Forms.Label();
            this.tbselecionar = new System.Windows.Forms.TextBox();
            this.dgvlivros = new System.Windows.Forms.DataGridView();
            this.btconfirmar = new System.Windows.Forms.Button();
            this.tbgenero = new System.Windows.Forms.TextBox();
            this.tbtitulo = new System.Windows.Forms.TextBox();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.lbsecao = new System.Windows.Forms.Label();
            this.lbgenero = new System.Windows.Forms.Label();
            this.lbeditora = new System.Windows.Forms.Label();
            this.lbautor = new System.Windows.Forms.Label();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.cbautor = new System.Windows.Forms.ComboBox();
            this.cbeditora = new System.Windows.Forms.ComboBox();
            this.tbsecao = new System.Windows.Forms.TextBox();
            this.lbisbn = new System.Windows.Forms.Label();
            this.lblancamento = new System.Windows.Forms.Label();
            this.tbisbn = new System.Windows.Forms.TextBox();
            this.dplancamento = new System.Windows.Forms.DateTimePicker();
            this.gbprocedimento.SuspendLayout();
            this.plocaliza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlivros)).BeginInit();
            this.SuspendLayout();
            // 
            // btlimpar
            // 
            this.btlimpar.Location = new System.Drawing.Point(68, 398);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(75, 23);
            this.btlimpar.TabIndex = 31;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // gbprocedimento
            // 
            this.gbprocedimento.Controls.Add(this.rbcadastrar);
            this.gbprocedimento.Controls.Add(this.rbexcluir);
            this.gbprocedimento.Controls.Add(this.rbalterar);
            this.gbprocedimento.Location = new System.Drawing.Point(43, 15);
            this.gbprocedimento.Name = "gbprocedimento";
            this.gbprocedimento.Size = new System.Drawing.Size(252, 47);
            this.gbprocedimento.TabIndex = 30;
            this.gbprocedimento.TabStop = false;
            this.gbprocedimento.Text = "Procedimento";
            // 
            // rbcadastrar
            // 
            this.rbcadastrar.AutoSize = true;
            this.rbcadastrar.Checked = true;
            this.rbcadastrar.Location = new System.Drawing.Point(6, 19);
            this.rbcadastrar.Name = "rbcadastrar";
            this.rbcadastrar.Size = new System.Drawing.Size(70, 17);
            this.rbcadastrar.TabIndex = 16;
            this.rbcadastrar.TabStop = true;
            this.rbcadastrar.Text = "Cadastrar";
            this.rbcadastrar.UseVisualStyleBackColor = true;
            this.rbcadastrar.CheckedChanged += new System.EventHandler(this.rbcadastrar_CheckedChanged);
            // 
            // rbexcluir
            // 
            this.rbexcluir.AutoSize = true;
            this.rbexcluir.Location = new System.Drawing.Point(143, 19);
            this.rbexcluir.Name = "rbexcluir";
            this.rbexcluir.Size = new System.Drawing.Size(56, 17);
            this.rbexcluir.TabIndex = 2;
            this.rbexcluir.Text = "Excluir";
            this.rbexcluir.UseVisualStyleBackColor = true;
            this.rbexcluir.CheckedChanged += new System.EventHandler(this.rbexcluir_CheckedChanged);
            // 
            // rbalterar
            // 
            this.rbalterar.AutoSize = true;
            this.rbalterar.Location = new System.Drawing.Point(82, 19);
            this.rbalterar.Name = "rbalterar";
            this.rbalterar.Size = new System.Drawing.Size(55, 17);
            this.rbalterar.TabIndex = 1;
            this.rbalterar.Text = "Alterar";
            this.rbalterar.UseVisualStyleBackColor = true;
            this.rbalterar.CheckedChanged += new System.EventHandler(this.rbalterar_CheckedChanged);
            // 
            // plocaliza
            // 
            this.plocaliza.Controls.Add(this.lbselecionar);
            this.plocaliza.Controls.Add(this.tbselecionar);
            this.plocaliza.Controls.Add(this.dgvlivros);
            this.plocaliza.Location = new System.Drawing.Point(439, 15);
            this.plocaliza.Name = "plocaliza";
            this.plocaliza.Size = new System.Drawing.Size(321, 406);
            this.plocaliza.TabIndex = 29;
            this.plocaliza.Visible = false;
            this.plocaliza.VisibleChanged += new System.EventHandler(this.plocaliza_VisibleChanged);
            // 
            // lbselecionar
            // 
            this.lbselecionar.AutoSize = true;
            this.lbselecionar.Location = new System.Drawing.Point(3, 18);
            this.lbselecionar.Name = "lbselecionar";
            this.lbselecionar.Size = new System.Drawing.Size(57, 13);
            this.lbselecionar.TabIndex = 2;
            this.lbselecionar.Text = "Selecionar";
            // 
            // tbselecionar
            // 
            this.tbselecionar.Location = new System.Drawing.Point(3, 34);
            this.tbselecionar.Name = "tbselecionar";
            this.tbselecionar.Size = new System.Drawing.Size(315, 20);
            this.tbselecionar.TabIndex = 1;
            this.tbselecionar.TextChanged += new System.EventHandler(this.tbselecionar_TextChanged);
            // 
            // dgvlivros
            // 
            this.dgvlivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlivros.Location = new System.Drawing.Point(3, 60);
            this.dgvlivros.Name = "dgvlivros";
            this.dgvlivros.Size = new System.Drawing.Size(315, 343);
            this.dgvlivros.TabIndex = 0;
            this.dgvlivros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlivros_CellDoubleClick);
            // 
            // btconfirmar
            // 
            this.btconfirmar.Location = new System.Drawing.Point(195, 398);
            this.btconfirmar.Name = "btconfirmar";
            this.btconfirmar.Size = new System.Drawing.Size(75, 23);
            this.btconfirmar.TabIndex = 28;
            this.btconfirmar.Text = "Confirmar";
            this.btconfirmar.UseVisualStyleBackColor = true;
            this.btconfirmar.Click += new System.EventHandler(this.btconfirmar_Click);
            // 
            // tbgenero
            // 
            this.tbgenero.Location = new System.Drawing.Point(43, 246);
            this.tbgenero.Name = "tbgenero";
            this.tbgenero.Size = new System.Drawing.Size(252, 20);
            this.tbgenero.TabIndex = 27;
            // 
            // tbtitulo
            // 
            this.tbtitulo.Location = new System.Drawing.Point(43, 128);
            this.tbtitulo.Name = "tbtitulo";
            this.tbtitulo.Size = new System.Drawing.Size(252, 20);
            this.tbtitulo.TabIndex = 24;
            // 
            // tbcodigo
            // 
            this.tbcodigo.Enabled = false;
            this.tbcodigo.Location = new System.Drawing.Point(43, 89);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(100, 20);
            this.tbcodigo.TabIndex = 23;
            // 
            // lbsecao
            // 
            this.lbsecao.AutoSize = true;
            this.lbsecao.Location = new System.Drawing.Point(40, 269);
            this.lbsecao.Name = "lbsecao";
            this.lbsecao.Size = new System.Drawing.Size(38, 13);
            this.lbsecao.TabIndex = 22;
            this.lbsecao.Text = "Seção";
            // 
            // lbgenero
            // 
            this.lbgenero.AutoSize = true;
            this.lbgenero.Location = new System.Drawing.Point(40, 229);
            this.lbgenero.Name = "lbgenero";
            this.lbgenero.Size = new System.Drawing.Size(42, 13);
            this.lbgenero.TabIndex = 21;
            this.lbgenero.Text = "Gênero";
            // 
            // lbeditora
            // 
            this.lbeditora.AutoSize = true;
            this.lbeditora.Location = new System.Drawing.Point(40, 190);
            this.lbeditora.Name = "lbeditora";
            this.lbeditora.Size = new System.Drawing.Size(40, 13);
            this.lbeditora.TabIndex = 20;
            this.lbeditora.Text = "Editora";
            // 
            // lbautor
            // 
            this.lbautor.AutoSize = true;
            this.lbautor.Location = new System.Drawing.Point(40, 151);
            this.lbautor.Name = "lbautor";
            this.lbautor.Size = new System.Drawing.Size(32, 13);
            this.lbautor.TabIndex = 19;
            this.lbautor.Text = "Autor";
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Location = new System.Drawing.Point(40, 112);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(35, 13);
            this.lbtitulo.TabIndex = 18;
            this.lbtitulo.Text = "Título";
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Location = new System.Drawing.Point(40, 73);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(40, 13);
            this.lbcodigo.TabIndex = 17;
            this.lbcodigo.Text = "Código";
            // 
            // cbautor
            // 
            this.cbautor.FormattingEnabled = true;
            this.cbautor.Location = new System.Drawing.Point(43, 166);
            this.cbautor.Name = "cbautor";
            this.cbautor.Size = new System.Drawing.Size(252, 21);
            this.cbautor.TabIndex = 16;
            // 
            // cbeditora
            // 
            this.cbeditora.FormattingEnabled = true;
            this.cbeditora.Location = new System.Drawing.Point(43, 206);
            this.cbeditora.Name = "cbeditora";
            this.cbeditora.Size = new System.Drawing.Size(252, 21);
            this.cbeditora.TabIndex = 32;
            // 
            // tbsecao
            // 
            this.tbsecao.Location = new System.Drawing.Point(43, 285);
            this.tbsecao.Name = "tbsecao";
            this.tbsecao.Size = new System.Drawing.Size(252, 20);
            this.tbsecao.TabIndex = 33;
            // 
            // lbisbn
            // 
            this.lbisbn.AutoSize = true;
            this.lbisbn.Location = new System.Drawing.Point(40, 308);
            this.lbisbn.Name = "lbisbn";
            this.lbisbn.Size = new System.Drawing.Size(32, 13);
            this.lbisbn.TabIndex = 34;
            this.lbisbn.Text = "ISBN";
            // 
            // lblancamento
            // 
            this.lblancamento.AutoSize = true;
            this.lblancamento.Location = new System.Drawing.Point(40, 348);
            this.lblancamento.Name = "lblancamento";
            this.lblancamento.Size = new System.Drawing.Size(66, 13);
            this.lblancamento.TabIndex = 35;
            this.lblancamento.Text = "Lançamento";
            // 
            // tbisbn
            // 
            this.tbisbn.Location = new System.Drawing.Point(43, 325);
            this.tbisbn.Name = "tbisbn";
            this.tbisbn.Size = new System.Drawing.Size(252, 20);
            this.tbisbn.TabIndex = 36;
            // 
            // dplancamento
            // 
            this.dplancamento.Location = new System.Drawing.Point(43, 364);
            this.dplancamento.Name = "dplancamento";
            this.dplancamento.Size = new System.Drawing.Size(252, 20);
            this.dplancamento.TabIndex = 38;
            // 
            // frmLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dplancamento);
            this.Controls.Add(this.tbisbn);
            this.Controls.Add(this.lblancamento);
            this.Controls.Add(this.lbisbn);
            this.Controls.Add(this.tbsecao);
            this.Controls.Add(this.cbeditora);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.gbprocedimento);
            this.Controls.Add(this.plocaliza);
            this.Controls.Add(this.btconfirmar);
            this.Controls.Add(this.tbgenero);
            this.Controls.Add(this.tbtitulo);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.lbsecao);
            this.Controls.Add(this.lbgenero);
            this.Controls.Add(this.lbeditora);
            this.Controls.Add(this.lbautor);
            this.Controls.Add(this.lbtitulo);
            this.Controls.Add(this.lbcodigo);
            this.Controls.Add(this.cbautor);
            this.Name = "frmLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLivro";
            this.Load += new System.EventHandler(this.frmLivro_Load);
            this.gbprocedimento.ResumeLayout(false);
            this.gbprocedimento.PerformLayout();
            this.plocaliza.ResumeLayout(false);
            this.plocaliza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.GroupBox gbprocedimento;
        private System.Windows.Forms.RadioButton rbcadastrar;
        private System.Windows.Forms.RadioButton rbexcluir;
        private System.Windows.Forms.RadioButton rbalterar;
        private System.Windows.Forms.Panel plocaliza;
        private System.Windows.Forms.Label lbselecionar;
        private System.Windows.Forms.TextBox tbselecionar;
        private System.Windows.Forms.DataGridView dgvlivros;
        private System.Windows.Forms.Button btconfirmar;
        private System.Windows.Forms.TextBox tbgenero;
        private System.Windows.Forms.TextBox tbtitulo;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.Label lbsecao;
        private System.Windows.Forms.Label lbgenero;
        private System.Windows.Forms.Label lbeditora;
        private System.Windows.Forms.Label lbautor;
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.ComboBox cbautor;
        private System.Windows.Forms.ComboBox cbeditora;
        private System.Windows.Forms.TextBox tbsecao;
        private System.Windows.Forms.Label lbisbn;
        private System.Windows.Forms.Label lblancamento;
        private System.Windows.Forms.TextBox tbisbn;
        private System.Windows.Forms.DateTimePicker dplancamento;
    }
}