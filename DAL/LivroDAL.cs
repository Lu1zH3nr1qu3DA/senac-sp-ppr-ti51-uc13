using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LivroDAL
    {
        public void excluir(int codigo)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = "DELETE FROM Livro WHERE Codigo = @Codigo ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Codigo", SqlDbType.Int, codigo);

                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }

        public void Insere(LivroMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " INSERT INTO Livro (Titulo, Genero, Secao, Isbn, Lancamento) " +
                                " VALUES (@Titulo, @Genero, @Secao, @Isbn, @Lancamento) ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Titulo", SqlDbType.VarChar, objDados.Titulo);
                consulta.AdicionarParametro("@Genero", SqlDbType.VarChar, objDados.Genero);
                consulta.AdicionarParametro("@Secao", SqlDbType.VarChar, objDados.Secao);
                consulta.AdicionarParametro("@Isbn", SqlDbType.VarChar, objDados.Isbn);
                consulta.AdicionarParametro("@Lancamento", SqlDbType.DateTime, objDados.Lancamento);

                consulta.ExecutaAtualizacao(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }

        }

        public List<LivroMOD> BuscaTodos()
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT Codigo, Titulo, Genero, Secao, Isbn, Lancamento " +
                             " FROM Livro ORDER BY Titulo ";

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<LivroMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new LivroMOD
                    {
                        Codigo = Convert.ToInt32(linha["Codigo"]),
                        Titulo = Convert.ToString(linha["Titulo"]),
                        Genero = Convert.ToString(linha["Genero"]),
                        Secao = Convert.ToString(linha["Secao"]),
                        Isbn = Convert.ToString(linha["Isbn"]),
                        Lancamento = Convert.ToDateTime(linha["Lancamento"]),
                    });
                }
                return (lista);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }

        }

        public List<LivroMOD> BuscaPornome(string nome)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT " +
                                " Livro.Codigo, Livro.Titulo, Livro.Genero, Livro.Secao, Livro.Isbn, " +
                                " Cidade.Nome AS CidadeNome, Editora.CidadeCodigo " +
                             " FROM " +
                                " Editora " +
                                " LEFT OUTER JOIN " +
                                    " Cidade " +
                                " ON " +
                                    " Editora.CidadeCodigo = Cidade.CidadeId " +
                             " WHERE " +
                                " Editora.Nome " +
                                " LIKE " +
                                    " @Nome " +
                                " ORDER BY " +
                                    " Nome ";

                consulta.AdicionarParametro("@Titulo", SqlDbType.VarChar, nome + "%");

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<LivroMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new LivroMOD
                    {
                        Codigo = Convert.ToInt32(linha["Codigo"]),
                        Titulo = Convert.ToString(linha["Titulo"]),
                        Genero = Convert.ToString(linha["Genero"]),
                        Secao = Convert.ToString(linha["Secao"]),
                        Isbn = Convert.ToString(linha["Isbn"]),
                        Lancamento = Convert.ToDateTime(linha["Lancamento"])
                    });
                }
                return (lista);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }
        }

        public List<LivroMOD> LocalizaPorNome(string nome)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT Codigo, Titulo, Genero, Secao, Isbn, Lancamento " +
                             " FROM Livro WHERE Titulo LIKE @Titulo ORDER BY Titulo ";

                consulta.AdicionarParametro("@Titulo", SqlDbType.VarChar, nome + "%");


                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<LivroMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new LivroMOD
                    {
                        Codigo = Convert.ToInt32(linha["Codigo"]),
                        Titulo = Convert.ToString(linha["Titulo"]),
                        Genero = Convert.ToString(linha["Genero"]),
                        Secao = Convert.ToString(linha["Secao"]),
                        Isbn = Convert.ToString(linha["Isbn"]),
                        Lancamento = Convert.ToDateTime(linha["Lancamento"])
                    });
                }
                return (lista);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }

        }

        public void Alterar(LivroMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " UPDATE Livro SET Titulo = @Titulo, Genero = @Genero, " +
                             " Secao = @Secao, Isbn = @Isbn, Lancamento = @Lancamento " +
                             " WHERE Codigo = @Codigo ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Titulo", SqlDbType.VarChar, objDados.Titulo);
                consulta.AdicionarParametro("@Genero", SqlDbType.VarChar, objDados.Genero);
                consulta.AdicionarParametro("@Secao", SqlDbType.VarChar, objDados.Secao);
                consulta.AdicionarParametro("@Isbn", SqlDbType.VarChar, objDados.Isbn);
                consulta.AdicionarParametro("@Lancamento", SqlDbType.DateTime, objDados.Lancamento);
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