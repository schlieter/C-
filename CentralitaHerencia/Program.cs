using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita Telefonica = new Centralita("Telefonica");

            Local l1 = new Local("CABA", "Lanus", 30, 2.65f);
            Local l2 = new Local("Lanus", "Avellaneda", 45, 1.99f);
            Provincial p1 = new Provincial("Cordoba", Provincial.Franja.Franja_1, 21, "Lanus");
            Provincial p2 = new Provincial(Provincial.Franja.Franja_3, (Llamada)p1);

            Telefonica.Llamadas.Add(l1);
            Telefonica.Llamadas.Add(p1);
            Telefonica.Llamadas.Add(l2);
            Telefonica.Llamadas.Add(p2);

            Telefonica.Mostrar();

            Telefonica.OrdenarLlamadas();

            Telefonica.Mostrar();
            Console.ReadLine();

        }
    }
}
