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


        public void Alterar(editoraMOD objdados)
        {
            EditoraDAL objalterar = new EditoraDAL();
            objalterar.Alterar(objdados);
        }

        public List<editoraMOD> BuscarTodos()
        {
            EditoraDAL objbuscar = new EditoraDAL();
            return (objbuscar.BuscaTodos());
        }

        public List<editoraMOD> LocalizaPorNome(string nome)
        {
            EditoraDAL objbuscar = new EditoraDAL();
            return (objbuscar.BuscaPornome(nome));
        }


        public int Inserir(editoraMOD objdados)
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
