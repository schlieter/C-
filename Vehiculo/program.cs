using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{   
    class program
    {
        static void Main(string[] args)
        {
            Lavadero miLavadero = new Lavadero(150, 500, 100);
            Auto Jorge = new Auto("AAA", 4, Emarcas.Fiat, 4);
            Moto Yo = new Moto("JJJ", 2, Emarcas.Honda, 250);
            Camion Pepe = new Camion("YYY", 16, Emarcas.Iveco, 40000);

            miLavadero = miLavadero + Jorge ;
            miLavadero = miLavadero + Yo;
            miLavadero += Pepe;


            

        }

    }
}
