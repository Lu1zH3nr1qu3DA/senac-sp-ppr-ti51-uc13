using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cidadeDAL
    {
        public List<cidadeMOD> SelecionaTodos()
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " SELECT CidadeID, NOME " +
                            " FROM cidade ORDER BY NOME DESC";
                DataTable registros = consulta.ExecutaConsulta(SQL);

                var listaAluno = new List<cidadeMOD>();

                foreach (DataRow linha in registros.Rows)
                {
                    listaAluno.Add(new cidadeMOD
                    {
                        CidadeId = Convert.ToInt32(linha["CidadeId"]),
                        Nome = Convert.ToString(linha["Nome"])
                    });
                }
                return listaAluno;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro Banco: " + ex.Message);
            }

        }
    }
}
