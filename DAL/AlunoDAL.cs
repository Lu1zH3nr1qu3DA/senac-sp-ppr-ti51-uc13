using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class AlunoDAL
    {
        public void excluir(int codigo)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = "DELETE FROM Aluno WHERE Codigo = @Codigo ";
                             
                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Codigo", SqlDbType.Int, codigo);
                
                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }

        public void Insere(AlunoMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " INSERT INTO Aluno (Nome, Nascimento, Endereco, Numero, Celular) " +
                             " VALUES (@Nome, @Nascimento, @Endereco, @Numero, @Celular) ";
                
                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, objDados.Nome);
                consulta.AdicionarParametro("@Nascimento", SqlDbType.DateTime, objDados.Nascimento);
                consulta.AdicionarParametro("@Endereco", SqlDbType.VarChar, objDados.Endereco);
                consulta.AdicionarParametro("@Numero", SqlDbType.VarChar, objDados.Numero);
                consulta.AdicionarParametro("@Celular", SqlDbType.VarChar, objDados.Celular);

                consulta.ExecutaAtualizacao(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }

        }

        public List<AlunoMOD> BuscaTodos()
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT CODIGO, NOME, ENDERECO, NUMERO, CELULAR, NASCIMENTO " +
                             " FROM ALUNO ORDER BY NOME ";

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<AlunoMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new AlunoMOD
                    {
                        Codigo = Convert.ToInt32(linha["CODIGO"]),
                        Nome = Convert.ToString(linha["Nome"]),
                        Endereco = Convert.ToString(linha["Endereco"]),
                        Nascimento = Convert.ToDateTime(linha["Nascimento"]),
                        Numero = Convert.ToString(linha["Numero"]),
                        Celular = Convert.ToString(linha["Celular"])
                    });
                }
                return (lista);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }

        }

        public List<AlunoMOD> LocalizaPorNome(string nome)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT CODIGO, NOME, ENDERECO, NUMERO, CELULAR, NASCIMENTO " +
                             " FROM ALUNO WHERE NOME LIKE @NOME  ORDER BY NOME ";

                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, nome+"%");


                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<AlunoMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new AlunoMOD
                    {
                        Codigo = Convert.ToInt32(linha["CODIGO"]),
                        Nome = Convert.ToString(linha["Nome"]),
                        Endereco = Convert.ToString(linha["Endereco"]),
                        Nascimento = Convert.ToDateTime(linha["Nascimento"]),
                        Numero = Convert.ToString(linha["Numero"]),
                        Celular = Convert.ToString(linha["Celular"])
                    });
                }
                return (lista);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }

        }

        public void Alterar (AlunoMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " Update Aluno set Nome = @Nome, Nascimento = @Nascimento, "+
                             " Endereco = @Endereco, Numero = @Numero, Celular = @Celular " +
                             " Where Codigo = @Codigo ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, objDados.Nome);
                consulta.AdicionarParametro("@Nascimento", SqlDbType.DateTime, objDados.Nascimento);
                consulta.AdicionarParametro("@Endereco", SqlDbType.VarChar, objDados.Endereco);
                consulta.AdicionarParametro("@Numero", SqlDbType.VarChar, objDados.Numero);
                consulta.AdicionarParametro("@Celular", SqlDbType.VarChar, objDados.Celular);
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
