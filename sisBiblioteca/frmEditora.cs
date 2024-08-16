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
    public partial class frmEditora : Form
    {
        public frmEditora()
        {
            InitializeComponent();
        }

        string operacao = "I";

        private void frmEditora_Load(object sender, EventArgs e)
        {
            CarregaCidade();
        }

        public void CarregaCidade()
        {
            cidadeBLL objCarregar= new cidadeBLL();
            cbcidade.DataSource = objCarregar.CarregarCidade();
            cbcidade.DisplayMember= "Nome";
            cbcidade.ValueMember= "CidadeId";
        }

        private void cbcidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btconfirmar_Click(object sender, EventArgs e)
        {
            editoraMOD objdados = new editoraMOD();
            objdados.Nome = tbnome.Text;
            objdados.Endereco = tbendereco.Text;
            objdados.Telefone = tbtelefone.Text;
            objdados.Email = tbemail.Text;
            objdados.CodigoCidade = Convert.ToInt32(cbcidade.SelectedValue);

            switch (operacao)
            {
                case "I":
                    EditoraBLL objinserir = new EditoraBLL();
                    if (objinserir.Inserir(objdados) == 1)
                    {
                        LimpaTela();
                        MessageBox.Show("Gravação com sucesso!");
                    }
                    else MessageBox.Show("Verifique os dados!");
                    break;

                case "A":
                    objdados.Codigo = Convert.ToInt32(tbcodigo.Text);
                    EditoraBLL objalterar = new EditoraBLL();
                    objalterar.Alterar(objdados);
                    LimpaTela();
                    MessageBox.Show("Gravação com sucesso!");
                    break;

                case "E":
                    int codigo = Convert.ToInt32(tbcodigo.Text);
                    EditoraBLL objexcluir = new EditoraBLL();
                    objexcluir.Excluir(codigo);
                    LimpaTela();
                    MessageBox.Show("Exclusão com sucesso!");
                    break;
            }
        }
        public void LimpaTela()
        {
            tbcodigo.Clear();
            tbnome.Clear();
            tbemail.Clear();
            tbendereco.Clear();
            tbtelefone.Clear();
            tbselecionar.Clear();
            cbcidade.ResetText();
        }
        private void tbselecionar_TextChanged(object sender, EventArgs e)
        {
            EditoraBLL objbuscar = new EditoraBLL();
            dgveditoras.DataSource = objbuscar.LocalizaPorNome(dgveditoras.Text);
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();

            operacao = "I";

            rbcadastrar.Checked = true;
            plocaliza.Visible = false;

            tbnome.Focus();
        }

        private void rbalterar_Click(object sender, EventArgs e)
        {
            if (rbalterar.Checked)
            {
                operacao = "A";
                plocaliza.Visible = true;
            }
        }

        private void rbexcluir_Click(object sender, EventArgs e)
        {
            if (rbexcluir.Checked)
            {
                operacao = "E";
                plocaliza.Visible = true;
            }
        }

        private void rbcadastrar_Click(object sender, EventArgs e)
        {
            if (rbcadastrar.Checked)
            {
                operacao = "I";
                plocaliza.Visible = false;
            }
        }

        private void dgveditoras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbcodigo.Text = dgveditoras.CurrentRow.Cells[0].Value.ToString();
            tbnome.Text = dgveditoras.CurrentRow.Cells[1].Value.ToString();
            tbemail.Text = dgveditoras.CurrentRow.Cells[2].Value.ToString();
            tbendereco.Text = dgveditoras.CurrentRow.Cells[3].Value.ToString();
            tbtelefone.Text = dgveditoras.CurrentRow.Cells[4].Value.ToString();
            cbcidade.SelectedValue = Convert.ToInt32(dgveditoras.CurrentRow.Cells[5].Value.ToString());

            tbnome.Focus();
        }

        private void plocaliza_VisibleChanged(object sender, EventArgs e)
        {
            if (plocaliza.Visible == true)
            {
                tbselecionar.Text = "A";
                tbselecionar.Text = "";
                tbselecionar.Focus();
            }
        }
    }
}
