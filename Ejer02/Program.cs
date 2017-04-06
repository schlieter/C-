using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = ("Ejercicio 02");
            int aux, i=0,j,x=0;
            Console.WriteLine("Ingrese altura de la piramide");
            aux = int.Parse(Console.ReadLine());
            for(;i<aux;i++)
            {
                if (x > 2)
                    x = 0;
                switch (x)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
                if(i > 0)
                {
                    for (j=0; j < i; j++)
                    {
                        Console.Write("**");
                    }
                }
                Console.WriteLine("*");
                x++;

            }
            Console.ReadLine();

        }
    }
}
