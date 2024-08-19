namespace sisBiblioteca
{
    partial class frmEmprestimo
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
            this.lbaluno = new System.Windows.Forms.Label();
            this.lblivro = new System.Windows.Forms.Label();
            this.btnovoaluno = new System.Windows.Forms.Button();
            this.btlocalizaraluno = new System.Windows.Forms.Button();
            this.cbaluno = new System.Windows.Forms.ComboBox();
            this.cblivro = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnovolivro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbcodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbaluno
            // 
            this.lbaluno.AutoSize = true;
            this.lbaluno.Location = new System.Drawing.Point(96, 81);
            this.lbaluno.Name = "lbaluno";
            this.lbaluno.Size = new System.Drawing.Size(34, 13);
            this.lbaluno.TabIndex = 0;
            this.lbaluno.Text = "Aluno";
            // 
            // lblivro
            // 
            this.lblivro.AutoSize = true;
            this.lblivro.Location = new System.Drawing.Point(96, 121);
            this.lblivro.Name = "lblivro";
            this.lblivro.Size = new System.Drawing.Size(30, 13);
            this.lblivro.TabIndex = 1;
            this.lblivro.Text = "Livro";
            // 
            // btnovoaluno
            // 
            this.btnovoaluno.Location = new System.Drawing.Point(267, 95);
            this.btnovoaluno.Name = "btnovoaluno";
            this.btnovoaluno.Size = new System.Drawing.Size(75, 23);
            this.btnovoaluno.TabIndex = 2;
            this.btnovoaluno.Text = "Novo";
            this.btnovoaluno.UseVisualStyleBackColor = true;
            this.btnovoaluno.Click += new System.EventHandler(this.btnovoaluno_Click);
            // 
            // btlocalizaraluno
            // 
            this.btlocalizaraluno.Location = new System.Drawing.Point(348, 95);
            this.btlocalizaraluno.Name = "btlocalizaraluno";
            this.btlocalizaraluno.Size = new System.Drawing.Size(75, 23);
            this.btlocalizaraluno.TabIndex = 3;
            this.btlocalizaraluno.Text = "Localizar";
            this.btlocalizaraluno.UseVisualStyleBackColor = true;
            // 
            // cbaluno
            // 
            this.cbaluno.FormattingEnabled = true;
            this.cbaluno.Location = new System.Drawing.Point(99, 97);
            this.cbaluno.Name = "cbaluno";
            this.cbaluno.Size = new System.Drawing.Size(121, 21);
            this.cbaluno.TabIndex = 6;
            // 
            // cblivro
            // 
            this.cblivro.FormattingEnabled = true;
            this.cblivro.Location = new System.Drawing.Point(99, 137);
            this.cblivro.Name = "cblivro";
            this.cblivro.Size = new System.Drawing.Size(121, 21);
            this.cblivro.TabIndex = 7;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(99, 225);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(240, 150);
            this.dgv.TabIndex = 8;
            // 
            // btnovolivro
            // 
            this.btnovolivro.Location = new System.Drawing.Point(267, 137);
            this.btnovolivro.Name = "btnovolivro";
            this.btnovolivro.Size = new System.Drawing.Size(75, 23);
            this.btnovolivro.TabIndex = 9;
            this.btnovolivro.Text = "Novo";
            this.btnovolivro.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Localizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Location = new System.Drawing.Point(282, 13);
            this.lbcodigo.Name = "lcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(40, 13);
            this.lbcodigo.TabIndex = 11;
            this.lbcodigo.Text = "Código";
            // 
            // frmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbcodigo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnovolivro);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cblivro);
            this.Controls.Add(this.cbaluno);
            this.Controls.Add(this.btlocalizaraluno);
            this.Controls.Add(this.btnovoaluno);
            this.Controls.Add(this.lblivro);
            this.Controls.Add(this.lbaluno);
            this.Name = "frmEmprestimo";
            this.Text = "Empréstimo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbaluno;
        private System.Windows.Forms.Label lblivro;
        private System.Windows.Forms.Button btnovoaluno;
        private System.Windows.Forms.Button btlocalizaraluno;
        private System.Windows.Forms.ComboBox cbaluno;
        private System.Windows.Forms.ComboBox cblivro;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnovolivro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbcodigo;
    }
}