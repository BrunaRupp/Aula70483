using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCores
{
    class Program
    {
        static List<string> listaDeCores = new List<string>();
        static void Main(string[] args)
        {
            MensagemInicial();

            var menuEscolhido = "0";

            while (menuEscolhido != "2")
            {
                menuEscolhido = MostrarMenu();

                switch (menuEscolhido)
                {
                    case "1":
                        RegistrarCores();
                        break;
                    case "2":
                        ListarCores();
                        break;
                    default:
                        Console.WriteLine("Opção selecionada é inválida");
                        Console.ReadKey(true);
                        break;
                }
                Console.Clear();
            }
            Console.ReadKey(true);
        }
        static void ListarCores()
        {
            Console.WriteLine("Listagem de Cores Selecionada" );

            listaDeCores.ForEach(x => Console.WriteLine($"Cor: {x}"));
                       
            Console.WriteLine("Listagem de cores finalizada.");

            Console.ReadKey(true);

        }

        static void RegistrarCores()
        {
            Console.WriteLine("Registro de Cores selecionado");

            Console.WriteLine("Informe a cor desejada: ");

            var corInformada = Console.ReadLine();

            listaDeCores.Add(corInformada);

            Console.WriteLine("Cor informada com sucesso!");

            Console.ReadKey(true);
        }

        static void MensagemInicial()
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Seja bem vindo ao nosso sistema de cadastro de cores!");
            Console.WriteLine("*****************************************************");
        }

        static string MostrarMenu()
        {
            Console.WriteLine("Digite o número para a opção desejada: ");
            Console.WriteLine("           1 - Incluir cor         ");
            Console.WriteLine("           2 - Listar cores        ");

            return Console.ReadLine();
        } 
    }

}
