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
        public void excluir(int emprestimo, int livro)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " DELETE FROM " +
                                " Editora " +
                                " WHERE " +
                                    " EmprestimoCodigo = @Codigo " +
                                    " AND " +
                                    " LivroCodigo = @Livro";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Codigo", SqlDbType.Int, emprestimo);
                consulta.AdicionarParametro("@livro", SqlDbType.Int, livro);

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

        public List<ItemEmprestimoMOD> BuscaPorCodigo(int codigo)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT " +
                                " ItemEmprestimo.Emprestimo.Codigo, " +
                                " Livro.Codigo, Livro.Titulo " +
                             " FROM " +
                                " ItemEmprestimo " +
                                " LEFT OUTER JOIN " +
                                    " Livro " +
                                " ON " +
                                    " ItemEmprestimo.LivroCodigo = Livro.Codigo" +
                             " WHERE " +
                                " ItemEmprestimo.EmprestimoCodigo = @Codigo ";

                consulta.AdicionarParametro("@Codigo", SqlDbType.Int, codigo);

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<ItemEmprestimoMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new ItemEmprestimoMOD
                    {
                        EmprestimoCodigo = Convert.ToInt32(linha["EmprestimoCodigo"]),
                        LivroCodigo = Convert.ToInt32(linha["LivroCodigo"]),
                        LivroNome = Convert.ToString(linha["Titulo"])

                    });
                }
                return (lista);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }
        }

        public List<ItemEmprestimoMOD> SelecionaTodos()
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " SELECT CidadeID, NOME " +
                            " FROM cidade ORDER BY NOME DESC";
                DataTable registros = consulta.ExecutaConsulta(SQL);

                var listaItemEmprestimo = new List<ItemEmprestimoMOD>();

                foreach (DataRow linha in registros.Rows)
                {
                    listaItemEmprestimo.Add(new ItemEmprestimoMOD
                    {
                        EmprestimoCodigo = Convert.ToInt32(linha["EmprestimoCodigo"]),
                        LivroCodigo = Convert.ToInt32(linha["LivroCodigo"]),
                        LivroNome = Convert.ToString(linha["Titulo"])
                    });
                }
                return listaItemEmprestimo;

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
