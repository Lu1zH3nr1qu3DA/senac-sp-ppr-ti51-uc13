using BLL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaconsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "10";
            List<aluno> listaaluno = new List<aluno>(); //Armazenar em memória
            List<autor> listaautor = new List<autor>(); //Armazena o autor
            List<editora> listaeditora = new List<editora>();  //Editora 
            List<livro> listalivro= new List<livro>();  //Livro
            List<emprestimo> listaemprestimo = new List<emprestimo>(); //Emprestimo


            while(resposta != "9")
            {
                Console.Clear();
                Console.WriteLine("1 - Aluno");
                Console.WriteLine("2 - Autor");
                Console.WriteLine("3 - Editora");
                Console.WriteLine("4 - Livro");
                Console.WriteLine("5 - Emprestimo");
                Console.Write("Opção: ");
                resposta= Console.ReadLine();

                //Aluno
                if(resposta == "1")
                {
                    Console.Clear();
                    Console.WriteLine("1 - Cadastrar");
                    Console.WriteLine("2 - Excluir");
                    Console.WriteLine("3 - Listar");
                    Console.WriteLine("4 - Alterar");
                    resposta= Console.ReadLine();

                    if(resposta == "1")
                    {
                        AlunoMOD objaluno = new AlunoMOD();
                        Console.Clear();
                        Console.WriteLine("Informe os dados:");
                        Console.Write("Código: ");
                        objaluno.Codigo =  Convert.ToInt16(Console.ReadLine());
                        Console.Write("Nome: ");
                        objaluno.Nome = Console.ReadLine();
                        Console.Write("Nascimento: ");
                        objaluno.Nascimento = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Endereco: ");
                        objaluno.Endereco = Console.ReadLine();
                        Console.Write("Número: ");
                        objaluno.Numero = Console.ReadLine();
                        Console.Write("Celular: ");
                        objaluno.Celular = Console.ReadLine();
                        //listaaluno.Add(objaluno);
                        AlunoBLL objInserir = new AlunoBLL();
                        objInserir.Inserir(objaluno);



                    }
                    else if ( resposta =="3") //Impressao
                    {
                        //Buscar no Banco de Dados
                        AlunoBLL objBusca= new AlunoBLL();
                        List<AlunoMOD> listadobanco= new List<AlunoMOD>();
                        listadobanco = objBusca.BuscarTodos();

                        Console.Clear();
                        Console.WriteLine("Código \tNome \t\tCeluar");
                        foreach(AlunoMOD alunos   in listadobanco)
                        {
                            Console.WriteLine(alunos.Codigo + "\t" + alunos.Nome + "\t\t" + alunos.Celular);                        
                        }
                        Console.ReadKey();
                    }
                    else if (resposta == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Informe o código para excluir: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        AlunoBLL objexcluir = new AlunoBLL();
                        objexcluir.Excluir(codigo);
                        
                    }
                    else if (resposta == "4") //Alterar
                    {
                        Console.Clear();
                        Console.WriteLine("Informe o código para alterar: ");
                        int codigo = Convert.ToInt16(Console.ReadLine());                        
                        AlunoMOD item = new AlunoMOD();

                        Console.Write("Informe o nome: ");
                        item.Nome = Console.ReadLine();
                        Console.Write("Nascimento: ");
                        item.Nascimento = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Endereco: ");
                        item.Endereco = Console.ReadLine();
                        Console.Write("Número: ");
                        item.Numero = Console.ReadLine();
                        Console.Write("Celular: ");
                        item.Celular = Console.ReadLine();
                        item.Codigo = codigo;
                        Console.WriteLine("Cadastro alterado com sucesso!");
                        //Objeto para alteração
                        AlunoBLL objAlterar = new AlunoBLL();
                        objAlterar.Alterar(item);

                    }

                }

                //Autor
                if (resposta == "2")
                {
                    Console.Clear();
                    Console.WriteLine("1 - Cadastrar");
                    Console.WriteLine("2 - Excluir");
                    Console.WriteLine("3 - Listar");
                    Console.WriteLine("4 - Alterar");
                    resposta = Console.ReadLine();

                    if (resposta == "1")
                    {
                        AutorMOD objautor = new AutorMOD();
                        Console.Clear();
                        Console.WriteLine("Informe os dados:");
                        Console.Write("Código: ");
                        objautor.Codigo = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Nome: ");
                        objautor.Nome = Console.ReadLine();
                        Console.Write("Nascimento: ");
                        objautor.Nascimento = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("E-mail: ");
                        objautor.Email = Console.ReadLine();
                        Console.Write("Origem: ");
                        objautor.Origem = Console.ReadLine();
                        AutorBLL objinserir = new AutorBLL();
                        objinserir.Inserir(objautor);
                        
                    }
                    else if (resposta == "3") //Impressao
                    {
                        AutorBLL objbuscar = new AutorBLL();
                        List<AutorMOD> impressaoAutor = objbuscar.BuscarTodos();
                        //impressaoAutor = objbuscar.BuscarTodos();

                        Console.Clear();
                        Console.WriteLine("Código \tNome \t\tEmail");
                        foreach (AutorMOD autores in impressaoAutor)
                        {
                            Console.WriteLine(autores.Codigo + "\t" + autores.Nome + "\t\t" + autores.Email);
                        }
                        Console.ReadKey();
                    }
                    else if (resposta == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Informe o código para excluir: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        AutorBLL objexcluir = new AutorBLL();
                        objexcluir.Excluir(codigo);

                    }
                    else if (resposta == "4")
                    {
                        Console.Clear();
                        Console.WriteLine("Informe o código para alterar: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        AutorMOD item = new AutorMOD();

                        Console.WriteLine("Escreva o nome: ");
                        item.Nome = Console.ReadLine();
                        Console.Write("Nascimento: ");
                        item.Nascimento = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("E-mail: ");
                        item.Email = Console.ReadLine();
                        Console.Write("Origem: ");
                        item.Origem = Console.ReadLine();

                        AutorBLL objAlterar = new AutorBLL();
                        objAlterar.Alterar(item);

                    }

                }

                //Editora
                if (resposta == "3")
                {
                    Console.Clear();
                    Console.WriteLine("1 - Cadastrar");
                    Console.WriteLine("2 - Excluir");
                    Console.WriteLine("3 - Listar");
                    resposta = Console.ReadLine();

                    if (resposta == "1")
                    {
                        editora objeditora = new editora();
                        Console.Clear();
                        Console.WriteLine("Informe os dados:");
                        Console.Write("Código: ");
                        objeditora.Codigo = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Nome: ");
                        objeditora.Nome = Console.ReadLine();                        
                        Console.Write("E-mail: ");
                        objeditora.Email = Console.ReadLine();
                        Console.Write("Telefone: ");
                        objeditora.Telefone = Console.ReadLine();
                        Console.Write("Endereço: ");
                        objeditora.Endereco = Console.ReadLine();
                        Console.Write("Cidade: ");
                        objeditora.Cidade = Console.ReadLine();

                        listaeditora.Add(objeditora);
                    }
                    else if (resposta == "3") //Impressao
                    {
                        Console.Clear();
                        Console.WriteLine("Código \tNome \t\tEmail");
                        foreach (editora editoras in listaeditora)
                        {
                            Console.WriteLine(editoras.Codigo + "\t" + editoras.Nome + "\t\t" + editoras.Email);
                        }
                        Console.ReadKey();
                    }
                    else if (resposta == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Informe o código para excluir: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        listaeditora.RemoveAll(delegate (editora f) { return f.Codigo == codigo; });
                    }
                    else if (resposta == "4")
                    {
                        Console.Clear();
                        Console.WriteLine("Informe o código para alterar: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        var item = listaeditora.First(x => x.Codigo == codigo);

                        Console.WriteLine("Escreva o nome: ");
                        item.Nome = Console.ReadLine();
                        Console.Write("E-mail: ");
                        item.Email = Console.ReadLine();
                        Console.Write("Telefone: ");
                        item.Telefone = Console.ReadLine();
                        Console.Write("Endereço: ");
                        item.Endereco = Console.ReadLine();
                        Console.Write("Cidade: ");
                        item.Cidade = Console.ReadLine();

                    }

                }

                //Livro
                if (resposta == "4")
                {
                    Console.Clear();
                    Console.WriteLine("1 - Cadastrar");
                    Console.WriteLine("2 - Excluir");
                    Console.WriteLine("3 - Listar");
                    resposta = Console.ReadLine();

                    if (resposta == "1")
                    {
                        livro objlivro = new livro();
                        Console.Clear();
                        Console.WriteLine("Informe os dados:");
                        Console.Write("Código: ");
                        objlivro.Codigo = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Título: ");
                        objlivro.Titulo = Console.ReadLine();
                        Console.Write("Autor: ");
                        objlivro.Autor = Console.ReadLine();
                        Console.Write("Editora: ");
                        objlivro.Editora = Console.ReadLine();
                        Console.Write("Genero: ");
                        objlivro.Genero = Console.ReadLine();
                        Console.Write("Seção: ");
                        objlivro.Secao = Console.ReadLine();
                        Console.Write("ISBN: ");
                        objlivro.ISBN = Console.ReadLine();
                        Console.Write("Lançamento: ");
                        objlivro.Lancamento = Convert.ToDateTime(Console.ReadLine());

                        listalivro.Add(objlivro);
                    }
                    else if (resposta == "3") //Impressao
                    {
                        Console.Clear();
                        Console.WriteLine("Código \tTítulo \t\tAutor");
                        foreach (livro livros in listalivro)
                        {
                            Console.WriteLine(livros.Codigo + "\t" + livros.Titulo + "\t\t" + livros.Autor);
                        }
                        Console.ReadKey();
                    }
                    else if (resposta == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Informe o código para excluir: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        listalivro.RemoveAll(delegate (livro f) { return f.Codigo == codigo; });
                    }
                    else if (resposta == "4")
                    {
                        Console.Clear();
                        Console.WriteLine("Informe o código para alterar: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        var item = listalivro.First(x => x.Codigo == codigo);

                        Console.Write("Título: ");
                        item.Titulo = Console.ReadLine();
                        Console.Write("Autor: ");
                        item.Autor = Console.ReadLine();
                        Console.Write("Editora: ");
                        item.Editora = Console.ReadLine();
                        Console.Write("Genero: ");
                        item.Genero = Console.ReadLine();
                        Console.Write("Seção: ");
                        item.Secao = Console.ReadLine();
                        Console.Write("ISBN: ");
                        item.ISBN = Console.ReadLine();
                        Console.Write("Lançamento: ");
                        item.Lancamento = Convert.ToDateTime(Console.ReadLine());

                    }

                }

                //emprestimo
                if(resposta == "5")
                {
                    Console.Clear();
                    Console.WriteLine("1 - Cadastrar");
                    Console.WriteLine("2 - Excluir");
                    Console.WriteLine("3 - Listar");
                    resposta = Console.ReadLine();

                    if (resposta == "1") //Cadastrar
                    {
                        emprestimo obj= new emprestimo();   
                        Console.Clear();
                        Console.WriteLine("Informe o código: ");
                        obj.Codigo = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Informe a data de emprestimo");
                        obj.DataEmprestimo = Convert.ToDateTime(Console.ReadLine());
                        //obj.DataEmprestimo = DateTime.Now;
                        obj.DataDevolucao = obj.DataEmprestimo.AddDays(7); //DateTime.Now.AddDays(7);
                        Console.WriteLine("Observação: ");
                        obj.Observacoes = Console.ReadLine();
                        
                        //Adicionando o aluno
                        aluno objaluno = new aluno();
                        List<aluno> listaaluno2= new List<aluno>(); 
                        Console.WriteLine("Informe o código do aluno: ");
                        objaluno.Codigo= Convert.ToInt16(Console.ReadLine());
                        listaaluno2.Add(objaluno);
                        obj.alunos= listaaluno2;  //Atribui o aluno ao emprestimo

                        //Adicionando os livros.                        
                        List<livro> listalivro2 = new List<livro>();
                        ConsoleKeyInfo tecla;   //captura qual tecla foi pressionada
                        tecla= Console.ReadKey();
                        do
                        {
                            livro objLivro2 = new livro();
                            Console.WriteLine("Informe o código do livro: ");
                            objLivro2.Codigo= Convert.ToInt16(Console.ReadLine());
                            listalivro2.Add(objLivro2);
                            Console.WriteLine("Pressione qualquer tecla ou ESC para sair. ");
                            tecla = Console.ReadKey();
                        }
                        while (tecla.Key != ConsoleKey.Escape);
                        obj.livros= listalivro2; //Adiciono o livro no emprestimo

                        listaemprestimo.Add(obj);
                        Console.ReadKey();

                    }

                }


            } //Fim do while 

        }
    }
}
