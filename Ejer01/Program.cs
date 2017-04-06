using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchlieterCristian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Ejercicio 01");
            int i = 0, aux, min = 0, max = 0, acum = 0;
            float prom = 0;
            for (; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
                aux = int.Parse(Console.ReadLine());
                acum = acum + aux;
                if (i == 0)
                {
                    min = aux;
                    max = aux;
                }
                else if (aux >= max)
                {
                    max = aux;
                }
                else if(aux <= min)
                {
                    min = aux;
                }
                prom = (float)acum / 5;
            }
            Console.WriteLine("El maximo es {0}, el minimo es {1} y  el promedio es {2}",max,min,prom);
            Console.ReadLine();
        }
    }
}
