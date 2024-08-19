using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EditoraBLL
    {
        public void Excluir(int codigo)
        {
            EditoraDAL objexcluir = new EditoraDAL();
            objexcluir.excluir(codigo);
        }


        public void Alterar(EditoraMOD objdados)
        {
            EditoraDAL objalterar = new EditoraDAL();
            objalterar.Alterar(objdados);
        }

        public List<EditoraMOD> BuscarTodos()
        {
            EditoraDAL objbuscar = new EditoraDAL();
            return (objbuscar.BuscaTodos());
        }

        public List<EditoraMOD> LocalizaPorNome(string nome)
        {
            EditoraDAL objbuscar = new EditoraDAL();
            return (objbuscar.BuscaPornome(nome));
        }

        public List<EditoraMOD> CarregarEditora()
        {
            EditoraDAL objcaregar = new EditoraDAL();
            return objcaregar.SelecionaTodos();
        }

        public int Inserir(EditoraMOD objdados)
        {
            if (objdados.Nome.Trim() != "")
            {
                EditoraDAL objInsere = new EditoraDAL();
                objInsere.Insere(objdados);
                return 1;
            }
            else return 0;
        }
    }
}
