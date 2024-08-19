using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmprestimoBLL
    {
        public void Excluir(int codigo)
        {
            EmprestimoDAL objexcluir = new EmprestimoDAL();
            objexcluir.excluir(codigo);
        }


        public void Alterar(EmprestimoMOD objdados)
        {
            EmprestimoDAL objalterar = new EmprestimoDAL();
            objalterar.Alterar(objdados);
        }

        public List<EmprestimoMOD> LocalizaPorNome(string nome)
        {
            EmprestimoDAL objbuscar = new EmprestimoDAL();
            return (objbuscar.BuscaPornome(nome));
        }


        public int Inserir(EmprestimoMOD objdados)
        {
            EmprestimoDAL objinsere = new EmprestimoDAL();
            return objinsere.Insere(objdados);
        }
    }
}
