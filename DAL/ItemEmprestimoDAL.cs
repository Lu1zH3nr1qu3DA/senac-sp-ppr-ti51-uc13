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
    }
}
