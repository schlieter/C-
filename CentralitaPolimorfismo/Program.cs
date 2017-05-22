using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita Telefonica = new Centralita("Telefonica");

            Local l1 = new Local("Lanus", 30, "Avellaneda", 2.65f);
            Local l2 = new Local("Avellaneda", 45, "Lanus", 1.99f);
            Provincial p1 = new Provincial("Lanus","Mendoza",21,Provincial.Franja.Franja_1);
            Provincial p2 = new Provincial(Provincial.Franja.Franja_3,p1);

            Telefonica += l1;
            Telefonica += p1;
            Telefonica += l2;
            //Telefonica += p2;

            //Telefonica.Llamadas.Add(l1);
            //Telefonica.Llamadas.Add(p2);
            Console.WriteLine(Telefonica.ToString());
            Console.ReadLine();
            
            Telefonica.OrdenarLlamadas();

            Console.WriteLine(Telefonica.ToString());
            Console.ReadLine();
        }
    }
}
