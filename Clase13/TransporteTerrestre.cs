using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13
{
    public abstract class TransporteTerrestre:Vehiculo
    {

        public TransporteTerrestre(int c, EVelocidad v)
            : base(c, v)
        {
        }
    }
}
