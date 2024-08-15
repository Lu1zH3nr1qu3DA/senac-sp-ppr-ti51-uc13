using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;

namespace BLL
{
    public class AlunoBLL
    {

        public void Excluir(int codigo)
        {
            AlunoDAL objexcluir = new AlunoDAL();
            objexcluir.excluir(codigo);
        }


        public void Alterar(AlunoMOD objdados)
        {
            AlunoDAL objalterar = new AlunoDAL();
            objalterar.Alterar(objdados);
        }

        public List<AlunoMOD> BuscarTodos()
        {
            AlunoDAL objbuscar = new AlunoDAL();
            return (objbuscar.BuscaTodos());
        }

        public List<AlunoMOD> LocalizaPorNome(string nome)
        {
            AlunoDAL objbuscar = new AlunoDAL();
            return (objbuscar.LocalizaPorNome(nome));
        }


        public int  Inserir (AlunoMOD objdados)
        {
            if (objdados.Nome.Trim() != "")
            {
                AlunoDAL objInsere = new AlunoDAL();
                objInsere.Insere(objdados);
                return 1;
            }
            else return 0;
        }
    }
}
