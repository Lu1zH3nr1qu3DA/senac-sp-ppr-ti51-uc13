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
    public partial class frmLivro : Form
    {
        public void LimpaTela()
        {
            tbcodigo.Clear();
            tbtitulo.Clear();
            cbautor.ResetText();
            cbeditora.ResetText();
            tbgenero.Clear();
            tbsecao.Clear();
            tbisbn.Clear();
            dplancamento.ResetText();
        }

        //CarregarEditora();

        //CarregarAutor();

        public frmLivro()
        {
            InitializeComponent();
        }

        private void frmLivro_Load(object sender, EventArgs e)
        {
            CarregarEditora();
            CarregarAutor();
        }

        public void CarregarEditora()
        {
            EditoraBLL objCarregar = new EditoraBLL();
            cbeditora.DataSource = objCarregar.CarregarEditora();
            cbeditora.DisplayMember = "Nome";
            cbeditora.ValueMember = "CidadeId";
        }

        public void CarregarAutor()
        {
            AutorBLL objCarregar = new AutorBLL();
            cbautor.DataSource = objCarregar.CarregarAutor();
            cbautor.DisplayMember = "Nome";
            cbautor.ValueMember = "CidadeId";
        }

        string operacao;

        private void rbcadastrar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcadastrar.Checked)
            {
                operacao = "I";
                plocaliza.Visible = false;
            }
        }

        private void rbalterar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbalterar.Checked)
            {
                operacao = "A";
                plocaliza.Visible = true;
            }
        }

        private void rbexcluir_CheckedChanged(object sender, EventArgs e)
        {
            if (rbexcluir.Checked)
            {
                operacao = "E";
                plocaliza.Visible = true;
            }
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

        private void tbselecionar_TextChanged(object sender, EventArgs e)
        {
            LivroBLL objbuscar = new LivroBLL();
            dgvlivros.DataSource = objbuscar.LocalizaPorNome(dgvlivros.Text);
        }

        private void dgvlivros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbcodigo.Text = dgvlivros.CurrentRow.Cells[0].Value.ToString();
            tbtitulo.Text = dgvlivros.CurrentRow.Cells[1].Value.ToString();
            cbautor.SelectedValue = dgvlivros.CurrentRow.Cells[2].Value;
            cbeditora.SelectedValue = dgvlivros.CurrentRow.Cells[3].Value;
            tbgenero.Text = dgvlivros.CurrentRow.Cells[4].Value.ToString();
            tbsecao.Text = dgvlivros.CurrentRow.Cells[5].Value.ToString();

            tbtitulo.Focus();
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();

            operacao = "I";

            rbcadastrar.Checked = true;
            plocaliza.Visible = false;

            tbtitulo.Focus();
        }

        private void btconfirmar_Click(object sender, EventArgs e)
        {
            LivroMOD objdados = new LivroMOD();
            objdados.Titulo = tbtitulo.Text;
            objdados.Genero = tbgenero.Text;
            objdados.Secao = tbsecao.Text;
            objdados.Isbn = tbisbn.Text;
            objdados.Lancamento = dplancamento.Value;

            switch (operacao)
            {
                case "I":
                    LivroBLL objinserir = new LivroBLL();
                    if (objinserir.Inserir(objdados) == 1)
                    {
                        LimpaTela();
                        MessageBox.Show("Gravação com sucesso!");
                    }
                    else MessageBox.Show("Verifique os dados!");
                    break;

                case "A":
                    objdados.Codigo = Convert.ToInt32(tbcodigo.Text);
                    LivroBLL objalterar = new LivroBLL();
                    objalterar.Alterar(objdados);
                    LimpaTela();
                    MessageBox.Show("Gravação com sucesso!");
                    break;

                case "E":
                    int codigo = Convert.ToInt32(tbcodigo.Text);
                    LivroBLL objexcluir = new LivroBLL();
                    objexcluir.Excluir(codigo);
                    LimpaTela();
                    MessageBox.Show("Exclusão com sucesso!");
                    break;
            }
        }
    }
}
