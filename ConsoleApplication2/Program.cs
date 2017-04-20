using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase06.Entidades;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Paleta a = 5;
            Paleta b = 7;
            Tempera temp = new Tempera(ConsoleColor.Blue, "azul", 3);
            Tempera temp2 = new Tempera(ConsoleColor.Red, "rojo", 3);
            Tempera temp3 = new Tempera(ConsoleColor.White, "blanco", 3);
            Tempera temp4 = new Tempera(ConsoleColor.Yellow, "amarillo", 3);
            Tempera temp5 = new Tempera(ConsoleColor.Green, "verde", 3);
            Tempera temp6 = new Tempera(ConsoleColor.Blue, "azul", 3);

            a += temp;
        }
    }
}
