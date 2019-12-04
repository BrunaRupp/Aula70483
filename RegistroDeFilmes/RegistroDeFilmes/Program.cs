using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeFilmes
{
    class Program
    {
        static List<string> ListaDeFilmes = new List<string>();

        static void Main(string[] args)
        {
            MensagemInicial();

            var menuEscolhido = "0";

            while (menuEscolhido != "3")
            {
                menuEscolhido = MostrarMenu();

                switch (menuEscolhido)
                {
                    case "1":
                        RegistrarFilme();
                        break;

                    case "2":
                        ListarFilmes();
                        break;

                    default:
                        Console.WriteLine("Menu inválido");
                        Console.ReadKey(true);
                        break;
                }

                Console.Clear();
            }
            
            Console.ReadKey(true);
        }
        
        static void MensagemInicial()
        {
            Console.WriteLine("****************************************************************");
            Console.WriteLine("********************** REGISTRO DE FILMES **********************");
            Console.WriteLine("****************************************************************");
        }

        static string MostrarMenu()
        {
            Console.WriteLine("            Digite o número para a opção desejada:");
            Console.WriteLine("                     1 - Registrar nome filme");
            Console.WriteLine("                     2 - Listar nome filme");
            Console.WriteLine("                     3 - Sair do sistema");

            return Console.ReadLine();
        }

        static void RegistrarFilme()
        {
            Console.WriteLine("Registro nome filme");
            Console.WriteLine("Informe o nome do Filme: ");
            var nomeInformado = Console.ReadLine();

            ListaDeFilmes.Add(nomeInformado);

            Console.WriteLine("Nome informado com sucesso!");
            Console.ReadKey(true);
        }

        static void ListarFilmes()
        {
            Console.WriteLine("Listagem de Filmes");

            ListaDeFilmes.ForEach(x => Console.WriteLine($"Nome do filme: {x}"));

            Console.WriteLine("Listagem de filmes finalizada.");
            Console.ReadKey(true);
        }

    }
}
