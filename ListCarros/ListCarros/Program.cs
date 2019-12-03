using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaCarros = new List<string>
            {
                "Vectra",
                "Polo",
                "Sandero",
                "Chevette",
                "Corvete"
            };

            listaCarros.ForEach(x => Console.WriteLine(x));

            Console.ReadKey(true);
        }
    }
}
