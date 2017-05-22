using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase11;

namespace TestClase11
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseUno miClase1 = new ClaseUno("Clase 1");
            Console.Write(miClase1.Tipo);
            Console.Write(miClase1.ToString());
            //
            ClaseDos miClase2 = new ClaseDos("Clase 2",miClase1.Tipo);
            Console.Write(miClase2.Tipo);
            Console.Write(miClase2.ToString());
            //
            ClaseTres miClase3 = new ClaseTres("Clase1","Clase2","Clase3");
            Console.Write(miClase3.Tipo);
            Console.Write(miClase3.ToString());
            Console.ReadLine();
            //
            List<ClaseUno> lista = new List<ClaseUno>();
            lista.Add(miClase1);
            lista.Add(miClase2);
            lista.Add(miClase3);

            foreach (ClaseUno a in lista)
            {
                Console.WriteLine(a.ToString());
                Console.WriteLine(a.Tipo);
                /*if(a is ClaseTres)
                {
                    Console.Write(((ClaseTres)a).TipoClaseTres);
                    Console.Write(((ClaseTres)a).MostrarClaseTres());
                }
                else if(a is ClaseDos)
                {
                    Console.Write(((ClaseDos)a).TipoClaseDos);
                    Console.Write(((ClaseDos)a).MostrarClaseDos());
                }
                else*/
            }
            
        }
    }
}
