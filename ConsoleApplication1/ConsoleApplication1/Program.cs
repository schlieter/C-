using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Hola";
            Sello.color = ConsoleColor.DarkCyan;
            Console.WriteLine(Sello.Imprimir());
            Sello.ImprimirEnColor();
            Sello.color = ConsoleColor.Gray;
            Sello.ImprimirEnColor();
            Console.ReadKey();

        }
    }
}
