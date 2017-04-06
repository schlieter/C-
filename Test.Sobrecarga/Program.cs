using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Sobrecarga;

namespace Test.Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tinta1 = new Tinta();
            Tinta tinta2 = new Tinta();
            Pluma miPluma = new Pluma("faber", 0, tinta1);

            miPluma = miPluma + tinta1;
        }
    }
}
