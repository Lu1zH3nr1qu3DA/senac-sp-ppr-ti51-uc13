using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmprestimoDAL
    {
        public void excluir(int codigo)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " DELETE FROM Emprestimo WHERE Codigo = @Codigo ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Codigo", SqlDbType.Int, codigo);

                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }

        public int Insere(EmprestimoMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " INSERT INTO Emprestimo (DataEmprestimo, DataDevolucao) " +
                                " VALUES (@DataEmprestimo, @DataDevolucao) SELECT @@identity AS Codigo";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@DataEmprestimo", SqlDbType.DateTime, objDados.DataEmprestimo);
                consulta.AdicionarParametro("@DataDevolucao", SqlDbType.DateTime, objDados.DataDevolucao);

                DataTable registros = consulta.ExecutaConsulta(SQL);

                int codigo = 0;

                foreach (DataRow linha in registros.Rows)
                {
                    codigo = Convert.ToInt32(linha["codigo"]);
                }

                return codigo;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }

        }

        public List<EmprestimoMOD> BuscaPornome(string nome)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT " +
                                " Emprestimo.Codigo, Emprestimo.DataEmprestimo, Emprestimo.DataDevolucao, Emprestimo.Observacao, " +
                                " Aluno.Nome " +
                             " FROM " +
                                " Emprestimo " +
                                " LEFT OUTER JOIN " +
                                    " Aluno " +
                                " ON " +
                                    " Emprestimo.AlunoCodigo = Aluno.Codigo " +
                             " WHERE " +
                                " Aluno.Nome " +
                                " LIKE " +
                                    " @Nome " +
                                " ORDER BY " +
                                    " Nome ";

                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, nome + "%");

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<EmprestimoMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new EmprestimoMOD
                    {
                        Codigo = Convert.ToInt32(linha["Codigo"]),
                        DataEmprestimo = Convert.ToDateTime(linha["DataEmprestimo"]),
                        DataDevolucao = Convert.ToDateTime(linha["DataDevolucao"]),
                        AlunoCodigo = Convert.ToInt32(linha["AlunoCodigo"]),
                        AlunoNome = Convert.ToString(linha["Nome"])
                    });
                }
                return (lista);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }
        }

        public void Alterar(EmprestimoMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " UPDATE " +
                                " Emprestimo " +
                                " SET " +
                                    " DataDevolucao = @DataDevolucao, AlunoCodigo = @AlunoCodigo, Observacao = @Observacao " +
                             " WHERE " +
                                " Codigo = @Codigo ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@DataDevolucao", SqlDbType.DateTime, objDados.DataDevolucao);
                consulta.AdicionarParametro("@AlunoCodigo", SqlDbType.Int, objDados.AlunoCodigo);
                consulta.AdicionarParametro("@Observacao", SqlDbType.VarChar, objDados.Observacao);
                consulta.AdicionarParametro("@Codigo", SqlDbType.VarChar, objDados.Codigo);

                consulta.ExecutaAtualizacao(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }
    }
}
