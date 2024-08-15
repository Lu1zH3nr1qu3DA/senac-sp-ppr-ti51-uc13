using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaconsole
{
    public class emprestimo
    {
        public int Codigo { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string Observacoes { get; set; }
        public List<aluno> alunos;
        public List<livro> livros;

    }
}
