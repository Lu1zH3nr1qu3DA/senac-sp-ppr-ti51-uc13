using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class cidadeBLL
    {
        public List<cidadeMOD> CarregarCidade()
        {
            cidadeDAL objcaregar= new cidadeDAL();
            return objcaregar.SelecionaTodos();
        }
    }
}
