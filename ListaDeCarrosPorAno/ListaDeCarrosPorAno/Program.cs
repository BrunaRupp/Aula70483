using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCarrosPorAno
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeCarrosComAno = new List<string>
            {
                "Chevette 1990",
                "Miura 1970",
                "Corvete 1920",
                "Mustang 1970",
                "Elba 1980",
                "Lotus 1960"
            };

            listaDeCarrosComAno.ForEach(x => Console.WriteLine(x));

            Console.ReadKey(true);
        }
    }
}
