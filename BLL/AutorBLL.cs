using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AutorBLL
    {
        public void Excluir(int codigo)
        {
            AutorDAL objexcluir = new AutorDAL();
            objexcluir.excluir(codigo);
        }

        public List<AutorMOD> CarregarAutor()
        {
            AutorDAL objcaregar = new AutorDAL();
            return objcaregar.SelecionaTodos();
        }

        public void Alterar(AutorMOD objdados)
        {
            AutorDAL objalterar = new AutorDAL();
            objalterar.Alterar(objdados);
        }

        public List<AutorMOD> BuscarTodos()
        {
            AutorDAL objbuscar = new AutorDAL();
            return (objbuscar.BuscaTodos());
        }

        public List<AutorMOD> BuscaPorNome(string nome)
        {
            AutorDAL objbuscar = new AutorDAL();
            return (objbuscar.BuscaPornome(nome));
        }


        public void Inserir(AutorMOD objdados)
        {
            if (objdados.Nome.Trim() != "")
            {
                AutorDAL objInsere = new AutorDAL();
                objInsere.Insere(objdados);
            }

        }
    }
}
