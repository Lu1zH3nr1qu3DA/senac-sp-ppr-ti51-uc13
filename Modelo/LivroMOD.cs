using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class LivroMOD
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string AutorCodigo { get; set; }
        public string EditoraCodigo { get; set; }
        public string Genero { get; set; }
        public string Secao { get; set; }
        public string Isbn { get; set; }
        public DateTime Lancamento { get; set; }
    }
}
