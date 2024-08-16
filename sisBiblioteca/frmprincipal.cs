using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisBiblioteca
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluno telaaluno = new frmAluno();
            telaaluno.ShowDialog();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutor telaautor = new frmAutor();
            telaautor.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAluno telaaluno = new frmAluno();
            telaaluno.ShowDialog();
        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditora telaediora = new frmEditora();
            telaediora.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            System.Environment.Exit(1);
        }

        private void frmprincipal_FormClosing(object sender, FormClosingEventArgs frm)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Deseja fechar a tela?", "Sair", buttons);
            if (result == DialogResult.No)
            {
                frm.Cancel = true;
            }
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {

        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivro telalivro = new frmLivro();
            telalivro.ShowDialog();
        }
    }
}
