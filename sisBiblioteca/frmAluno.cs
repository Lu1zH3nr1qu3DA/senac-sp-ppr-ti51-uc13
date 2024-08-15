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
    public partial class frmAluno : Form
    {
        public frmAluno()
        {
            InitializeComponent();
        }
        string operacao = "I";

        private void btgravar_Click(object sender, EventArgs e)
        {
            AlunoMOD objdados = new AlunoMOD();
            objdados.Nome = tbnome.Text;
            objdados.Endereco = tbendereco.Text;
            objdados.Celular = tbcelular.Text;
            objdados.Numero = tbnumero.Text;
            objdados.Nascimento = dtnascimento.Value;

            if(rbAlterar.Checked)
            {
                operacao = "A";
            }
            else
            {
                operacao = "E";
            }

            switch (operacao)
            {
                case "I":
                    AlunoBLL objinserir = new AlunoBLL();
                    if (objinserir.Inserir(objdados) == 1)
                    {
                        LimpaTela();
                        MessageBox.Show("Gravação com sucesso!");
                    }
                    else MessageBox.Show("Verifique os dados!");
                    break;

                case "A":
                    objdados.Codigo = Convert.ToInt32(tbcodigo.Text);
                    AlunoBLL objalterar = new AlunoBLL();
                    objalterar.Alterar(objdados);
                    LimpaTela();
                    MessageBox.Show("Gravação com sucesso!");
                    break;

                case "E":
                    int codigo = Convert.ToInt32(tbcodigo.Text);
                    AlunoBLL objexcluir = new AlunoBLL();
                    objexcluir.Excluir(codigo);
                    LimpaTela();
                    MessageBox.Show("Exclusão com sucesso!");
                    break;
            }
        }

        public void LimpaTela()
        {
            tbnome.Clear();
            tbnumero.Clear();
            tbcelular.Clear();
            tbendereco.Clear();
            dtnascimento.Value = DateTime.Now;

        }

        private void btlocaliza_Click(object sender, EventArgs e)
        {
           
            plocaliza.Visible = true;
            tblocaliza.Focus();
        }

        private void tblocaliza_TextChanged(object sender, EventArgs e)
        {
            AlunoBLL objbuscar = new AlunoBLL();
            dgvaluno.DataSource = objbuscar.LocalizaPorNome(tblocaliza.Text);
        }

        private void dgvaluno_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //tbcodigo.Text = dgvaluno.CurrentRow.Cells[0].Value.ToString();
            //tbnome.Text = dgvaluno.CurrentRow.Cells[1].Value.ToString();
            //tbendereco.Text = dgvaluno.CurrentRow.Cells[3].Value.ToString();
            //tbnumero.Text = dgvaluno.CurrentRow.Cells[4].Value.ToString();
            //tbcelular.Text = dgvaluno.CurrentRow.Cells[5].Value.ToString();
            //dtnascimento.Value = Convert.ToDateTime(dgvaluno.CurrentRow.Cells[2].Value);
            //plocaliza.Visible = false;

        }

        private void dgvaluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbcodigo.Text = dgvaluno.CurrentRow.Cells[0].Value.ToString();
            tbnome.Text = dgvaluno.CurrentRow.Cells[1].Value.ToString();
            tbendereco.Text = dgvaluno.CurrentRow.Cells[3].Value.ToString();
            tbnumero.Text = dgvaluno.CurrentRow.Cells[4].Value.ToString();
            tbcelular.Text = dgvaluno.CurrentRow.Cells[5].Value.ToString();
            dtnascimento.Value = Convert.ToDateTime(dgvaluno.CurrentRow.Cells[2].Value);
            plocaliza.Visible = false;
            operacao = "A";
            gbOpcao.Visible = true;
        }

        private void tbcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaTela();
            operacao = "I";
            plocaliza.Visible = false;
            tbnome.Focus();
        }

        private void frmAluno_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
