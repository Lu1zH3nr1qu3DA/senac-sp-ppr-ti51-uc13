using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class EmprestimoMOD
    {
        public int Codigo { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string Observacao { get; set; }
        public int AlunoCodigo { get; set; }
        public string AlunoNome { get; set; }
    }
}
