using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class Auto:Vehiculo
    {
        protected int _cantidadAsientos;

        public Auto(string a, byte b, Emarcas c,int ca) :base(a,b,c)
        {
            this._cantidadAsientos = ca;
        }

        public string MostrarAuto()
        {
            return base.Mostrar() + this._cantidadAsientos.ToString();
        }
    

    }
}
