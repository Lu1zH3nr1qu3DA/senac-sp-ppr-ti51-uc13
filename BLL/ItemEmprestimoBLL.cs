using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ItemEmprestimoBLL
    {
        public void Excluir(int emprestimo, int livro)
        {
            ItemEmprestimoDAL objexcluir = new ItemEmprestimoDAL();
            objexcluir.excluir(emprestimo, livro);
        }

        public void Incluir(ItemEmprestimoMOD objdados)
        {
            ItemEmprestimoDAL objincluir = new ItemEmprestimoDAL();
            objincluir.Insere(objdados);
        }

        public List<ItemEmprestimoMOD> BuscaPorCodigo(int emprestimo)
        {
            ItemEmprestimoDAL objbusca = new ItemEmprestimoDAL();
            return objbusca.BuscaPorCodigo(emprestimo);
        }
    }
}
