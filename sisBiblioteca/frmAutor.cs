using BLL;
using Modelo;
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
    public partial class frmAutor : Form
    {
        string operacao = "I";
        public frmAutor()
        {
            InitializeComponent();
        }

        private void btgravar_Click(object sender, EventArgs e)
        {
            AutorMOD objdados=new AutorMOD();

            objdados.Nome = tbnome.Text;
            objdados.Origem = tborigem.Text;
            objdados.Email = tbemail.Text;
            objdados.Nascimento = dtnascimento.Value;

            if (operacao == "I")
            {
                AutorBLL objInserir = new AutorBLL();
                objInserir.Inserir(objdados);
                MessageBox.Show("Cadastro efetuado!");
            }
            else if (operacao == "A")
            {
                objdados.Codigo = Convert.ToInt32(tbcodigo.Text);
                AutorBLL objalterar = new AutorBLL();
                objalterar.Alterar(objdados);
                MessageBox.Show("Alteração efetuada!");
            }
            LimpaTela();

        }

        public void LimpaTela()
        {
            tbcodigo.Clear();
            tbnome.Clear();
            dtnascimento.Value = DateTime.Now;
            tbemail.Clear();
            tborigem.Clear();
        }

        private void tblocaliza_TextChanged(object sender, EventArgs e)
        {
            AutorBLL objbusca = new AutorBLL();
            dgvautor.DataSource= objbusca.BuscaPorNome(tblocaliza.Text);    
        }

        private void dgvautor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            operacao= "A";
            tbcodigo.Text= dgvautor.CurrentRow.Cells[0].Value.ToString();
            tbnome.Text = dgvautor.CurrentRow.Cells[1].Value.ToString();
            dtnascimento.Value = Convert.ToDateTime(dgvautor.CurrentRow.Cells[2].Value);
            tbemail.Text = dgvautor.CurrentRow.Cells[3].Value.ToString();
            tborigem.Text = dgvautor.CurrentRow.Cells[4].Value.ToString();
            plocaliza.Visible = false;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Deseja excluir?", "Exclusão", buttons);
            if (result == DialogResult.Yes)
            {
                AutorBLL objexcluir = new AutorBLL();
                objexcluir.Excluir(Convert.ToInt32(tbcodigo.Text));
                MessageBox.Show("Exclusão efetuada!");
                LimpaTela();
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            LimpaTela();
            operacao = "I";
            tbnome.Focus();
        }

        private void btlocaliza_Click(object sender, EventArgs e)
        {
            plocaliza.Visible= true;
            tblocaliza.Clear();
            tblocaliza.Focus();
        }

        private void btsair_Click(object sender, EventArgs e)
        {
                this.Close();           
        }

        private void frmAutor_FormClosing(object sender, FormClosingEventArgs snc)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Deseja fechar a tela?", "Sair", buttons);
            if (result == DialogResult.No)
            {
                snc.Cancel = true;
            }
        }

        private void frmAutor_Load(object sender, EventArgs e)
        {

        }
    }
}
