using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase13;

namespace Clase13Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto(4, 4, EVelocidad.media);
            Cohete cohete1 = new Cohete(3, 8, "SpaceX", EVelocidad.hiper);
            Caballo caballo1 = new Caballo(2, "Pura Sangre", EVelocidad.media);

            Console.WriteLine(auto1.Detalle);
            Console.WriteLine(cohete1.Detalle);
            Console.WriteLine(caballo1.Detalle);

            Console.WriteLine(cohete1.Acelerar());
            Console.WriteLine(auto1.Acelerar());
            Console.ReadLine();

            List<Vehiculo> _lista= new List<Vehiculo>();

            _lista.Add(auto1);
            _lista.Add(cohete1);
            _lista.Add(caballo1);

            foreach (Vehiculo a in _lista)
            {
                Console.WriteLine(a.Detalle);
            }
            Console.ReadLine();
            
        }
    }
}
