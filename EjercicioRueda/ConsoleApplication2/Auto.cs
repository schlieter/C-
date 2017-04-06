using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Auto
    {
        public string fabricante;

        Rueda ruedaDD;
        Rueda ruedaDI;
        Rueda ruedaTD;
        Rueda ruedaTI;

        public Auto()
        {
            ruedaDD = new Rueda();
        }
    }
}
