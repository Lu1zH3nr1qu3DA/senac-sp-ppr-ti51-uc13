namespace sisBiblioteca
{
    partial class frmAutor
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
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tborigem = new System.Windows.Forms.TextBox();
            this.dtnascimento = new System.Windows.Forms.DateTimePicker();
            this.btgravar = new System.Windows.Forms.Button();
            this.plocaliza = new System.Windows.Forms.Panel();
            this.dgvautor = new System.Windows.Forms.DataGridView();
            this.tblocaliza = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btlocaliza = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.plocaliza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvautor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Origem";
            // 
            // tbcodigo
            // 
            this.tbcodigo.Location = new System.Drawing.Point(42, 32);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(100, 20);
            this.tbcodigo.TabIndex = 5;
            // 
            // tbnome
            // 
            this.tbnome.Location = new System.Drawing.Point(42, 101);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(250, 20);
            this.tbnome.TabIndex = 6;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(42, 251);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(250, 20);
            this.tbemail.TabIndex = 7;
            // 
            // tborigem
            // 
            this.tborigem.Location = new System.Drawing.Point(42, 333);
            this.tborigem.Name = "tborigem";
            this.tborigem.Size = new System.Drawing.Size(250, 20);
            this.tborigem.TabIndex = 8;
            // 
            // dtnascimento
            // 
            this.dtnascimento.Location = new System.Drawing.Point(42, 176);
            this.dtnascimento.Name = "dtnascimento";
            this.dtnascimento.Size = new System.Drawing.Size(250, 20);
            this.dtnascimento.TabIndex = 9;
            // 
            // btgravar
            // 
            this.btgravar.Location = new System.Drawing.Point(355, 421);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(93, 36);
            this.btgravar.TabIndex = 10;
            this.btgravar.Text = "Gravar";
            this.btgravar.UseVisualStyleBackColor = true;
            this.btgravar.Click += new System.EventHandler(this.btgravar_Click);
            // 
            // plocaliza
            // 
            this.plocaliza.Controls.Add(this.dgvautor);
            this.plocaliza.Controls.Add(this.tblocaliza);
            this.plocaliza.Controls.Add(this.label6);
            this.plocaliza.Location = new System.Drawing.Point(308, 44);
            this.plocaliza.Name = "plocaliza";
            this.plocaliza.Size = new System.Drawing.Size(473, 347);
            this.plocaliza.TabIndex = 11;
            this.plocaliza.Visible = false;
            // 
            // dgvautor
            // 
            this.dgvautor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvautor.Location = new System.Drawing.Point(13, 71);
            this.dgvautor.Name = "dgvautor";
            this.dgvautor.Size = new System.Drawing.Size(438, 255);
            this.dgvautor.TabIndex = 2;
            this.dgvautor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvautor_CellDoubleClick);
            // 
            // tblocaliza
            // 
            this.tblocaliza.Location = new System.Drawing.Point(13, 34);
            this.tblocaliza.Name = "tblocaliza";
            this.tblocaliza.Size = new System.Drawing.Size(438, 20);
            this.tblocaliza.TabIndex = 1;
            this.tblocaliza.TextChanged += new System.EventHandler(this.tblocaliza_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Localiza";
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(454, 421);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(88, 36);
            this.btExcluir.TabIndex = 12;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(145, 421);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(106, 36);
            this.btNovo.TabIndex = 13;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btlocaliza
            // 
            this.btlocaliza.Location = new System.Drawing.Point(257, 421);
            this.btlocaliza.Name = "btlocaliza";
            this.btlocaliza.Size = new System.Drawing.Size(92, 36);
            this.btlocaliza.TabIndex = 14;
            this.btlocaliza.Text = "Localizar";
            this.btlocaliza.UseVisualStyleBackColor = true;
            this.btlocaliza.Click += new System.EventHandler(this.btlocaliza_Click);
            // 
            // btsair
            // 
            this.btsair.Location = new System.Drawing.Point(548, 421);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(85, 36);
            this.btsair.TabIndex = 16;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // frmAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 551);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btlocaliza);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.plocaliza);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.dtnascimento);
            this.Controls.Add(this.tborigem);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAutor_FormClosing);
            this.Load += new System.EventHandler(this.frmAutor_Load);
            this.plocaliza.ResumeLayout(false);
            this.plocaliza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvautor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tborigem;
        private System.Windows.Forms.DateTimePicker dtnascimento;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Panel plocaliza;
        private System.Windows.Forms.DataGridView dgvautor;
        private System.Windows.Forms.TextBox tblocaliza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btlocaliza;
        private System.Windows.Forms.Button btsair;
    }
}