using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ItemEmprestimoDAL
    {
        public void excluir(int codigo)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " DELETE FROM Editora WHERE Codigo = @Codigo ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Codigo", SqlDbType.Int, codigo);

                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }

        public void Insere(ItemEmprestimoMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = "Insert into ItemEmprestimo (EmprestimoCodigo, LivroCodigo) " +
                             " values (@EmprestimoCodigo, @LivroCodigo) ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@EmprestimoCodigo", SqlDbType.Int, objDados.EmprestimoCodigo);
                consulta.AdicionarParametro("@LivroCodigo", SqlDbType.Int, objDados.LivroCodigo);

                consulta.ExecutaAtualizacao(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }

        }

        public List<EditoraMOD> BuscaPornome(string nome)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT " +
                                " Editora.Codigo, Editora.Nome, Editora.Email, Editora.Endereco, Editora.Telefone, " +
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

                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, nome + "%");

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<EditoraMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new EditoraMOD
                    {
                        Codigo = Convert.ToInt32(linha["Codigo"]),
                        Nome = Convert.ToString(linha["Nome"]),
                        Email = Convert.ToString(linha["Email"]),
                        Endereco = Convert.ToString(linha["Endereco"]),
                        Telefone = Convert.ToString(linha["Telefone"]),
                        CodigoCidade = Convert.ToInt32(linha["CidadeCodigo"]),
                        CidadeNome = Convert.ToString(linha["CidadeNome"])
                    });
                }
                return (lista);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }
        }

        public List<EditoraMOD> SelecionaTodos()
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " SELECT CidadeID, NOME " +
                            " FROM cidade ORDER BY NOME DESC";
                DataTable registros = consulta.ExecutaConsulta(SQL);

                var listaAluno = new List<EditoraMOD>();

                foreach (DataRow linha in registros.Rows)
                {
                    listaAluno.Add(new EditoraMOD
                    {
                        Codigo = Convert.ToInt32(linha["CidadeId"]),
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

        public void Alterar(EditoraMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " UPDATE " +
                                " Editora " +
                                " SET Nome = @Nome, endereco = @endereco, Email = @Email, cidadecodigo = @cidadecodigo, telefone = @telefone " +
                             " WHERE " +
                                " Codigo = @Codigo ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, objDados.Nome);
                consulta.AdicionarParametro("@Email", SqlDbType.VarChar, objDados.Email);
                consulta.AdicionarParametro("@endereco", SqlDbType.VarChar, objDados.Endereco);
                consulta.AdicionarParametro("@telefone", SqlDbType.VarChar, objDados.Telefone);
                consulta.AdicionarParametro("@cidadecodigo", SqlDbType.Int, objDados.CodigoCidade);
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
