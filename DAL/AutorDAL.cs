using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class AutorDAL
    {

        public List<AutorMOD> SelecionaTodos()
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " SELECT CidadeID, NOME " +
                            " FROM cidade ORDER BY NOME DESC";
                DataTable registros = consulta.ExecutaConsulta(SQL);

                var listaAluno = new List<AutorMOD>();

                foreach (DataRow linha in registros.Rows)
                {
                    listaAluno.Add(new AutorMOD
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

        public void excluir(int codigo)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " delete from autor where codigo = @codigo ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@codigo", SqlDbType.Int, codigo);

                consulta.ExecutaAtualizacao(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }
        }

        public void Insere(AutorMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = "Insert into autor (Nome, Nascimento, Email, Origem) " +
                             " values (@Nome, @Nascimento, @Email,  @Origem) ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, objDados.Nome);
                consulta.AdicionarParametro("@Nascimento", SqlDbType.DateTime, objDados.Nascimento);
                consulta.AdicionarParametro("@Email", SqlDbType.VarChar, objDados.Email);
                consulta.AdicionarParametro("@Origem", SqlDbType.VarChar, objDados.Origem);
                

                consulta.ExecutaAtualizacao(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro banco de dados: " + ex.Message);
            }

        }

        public List<AutorMOD> BuscaTodos()
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT CODIGO, NOME, Email, Origem,  NASCIMENTO " +
                             " FROM autor ORDER BY NOME ";

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<AutorMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new AutorMOD
                    {
                        Codigo = Convert.ToInt32(linha["CODIGO"]),
                        Nome = Convert.ToString(linha["Nome"]),
                        Email = Convert.ToString(linha["Email"]),
                        Nascimento = Convert.ToDateTime(linha["Nascimento"]),
                        Origem = Convert.ToString(linha["Origem"])                        
                    });
                }
                return (lista);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }

        }

        public List<AutorMOD> BuscaPornome(string nome)
        {
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();
                string SQL = " SELECT CODIGO, NOME, Email, Origem,  NASCIMENTO " +
                             " FROM autor where nome like @nome ORDER BY NOME ";

                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, nome + "%");

                DataTable registros = consulta.ExecutaConsulta(SQL);

                var lista = new List<AutorMOD>();
                foreach (DataRow linha in registros.Rows)
                {
                    lista.Add(new AutorMOD
                    {
                        Codigo = Convert.ToInt32(linha["CODIGO"]),
                        Nome = Convert.ToString(linha["Nome"]),
                        Email = Convert.ToString(linha["Email"]),
                        Nascimento = Convert.ToDateTime(linha["Nascimento"]),
                        Origem = Convert.ToString(linha["Origem"])
                    });
                }
                return (lista);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro do banco: " + ex.Message);
            }

        }

        public void Alterar(AutorMOD objDados)
        {
            //Objeto de conexao com o banco de dados
            AcessoDados consulta = new AcessoDados();

            try
            {
                consulta.LimparParametros();

                string SQL = " Update Autor set Nome = @Nome, Nascimento = @Nascimento, " +
                             " Email = @Email, Origem = @Origem " +
                             " Where Codigo = @Codigo ";

                //Passagem dos valores para os parametros
                consulta.AdicionarParametro("@Nome", SqlDbType.VarChar, objDados.Nome);
                consulta.AdicionarParametro("@Nascimento", SqlDbType.DateTime, objDados.Nascimento);
                consulta.AdicionarParametro("@Email", SqlDbType.VarChar, objDados.Email);
                consulta.AdicionarParametro("@Origem", SqlDbType.VarChar, objDados.Origem);
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
