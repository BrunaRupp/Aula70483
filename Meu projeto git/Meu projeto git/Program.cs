using System;
using System.Collections.Generic;

namespace Meu_projeto_git
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> minhaLista = new List<string>
            {
                "Felipe",
                "Giomar",
                "Ariosvaldo",
                "Adagoberto",
                "Valdisney",
                "Rusbervaldo"
            };

            minhaLista.ForEach(x => Console.WriteLine(x));

            Console.ReadKey(true);

        }
    }
}
