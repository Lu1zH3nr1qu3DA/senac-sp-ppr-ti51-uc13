using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Modelo;

namespace sisBiblioteca
{
    public partial class frmEmprestimo : Form
    {
        int codigo = 0;
        public frmEmprestimo()
        {
            InitializeComponent();
        }

        private void btnovoaluno_Click(object sender, EventArgs e)
        {
            EmprestimoMOD objdados = new EmprestimoMOD();
            objdados.DataEmprestimo = DateTime.Now;
            objdados.DataDevolucao = DateTime.Now.AddDays(4);

            EmprestimoBLL objinserir = new EmprestimoBLL();
            codigo = objinserir.Inserir(objdados);

            lbcodigo.Text = codigo.ToString();
        }
    }
}
