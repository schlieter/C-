using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class Moto:Vehiculo
    {
        protected float _cilindrada;

        public Moto(string a, byte b, Emarcas c,float ci) :base(a,b,c)
        {
            this._cilindrada = ci;
        }

        public string MostrarMoto()
        {
            return base.Mostrar() + this._cilindrada.ToString();
        }

    }
}
