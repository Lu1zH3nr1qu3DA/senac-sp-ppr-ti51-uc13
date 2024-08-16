using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CidadeBLL
    {
        public List<CidadeMOD> CarregarCidade()
        {
            CidadeDAL objcaregar= new CidadeDAL();
            return objcaregar.SelecionaTodos();
        }
    }
}
