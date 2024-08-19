using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LivroBLL
    {
        public void Excluir(int codigo)
        {
            LivroDAL objexcluir = new LivroDAL();
            objexcluir.excluir(codigo);
        }


        public void Alterar(LivroMOD objdados)
        {
            LivroDAL objalterar = new LivroDAL();
            objalterar.Alterar(objdados);
        }

        public List<LivroMOD> BuscarTodos()
        {
            LivroDAL objbuscar = new LivroDAL();
            return (objbuscar.BuscaTodos());
        }

        public List<LivroMOD> LocalizaPorNome(string nome)
        {
            LivroDAL objbuscar = new LivroDAL();
            return (objbuscar.BuscaPornome(nome));
        }



        public int Inserir(LivroMOD objdados)
        {
            if (objdados.Titulo.Trim() != "")
            {
                LivroDAL objInsere = new LivroDAL();
                objInsere.Insere(objdados);
                return 1;
            }
            else return 0;
        }
    }
}
