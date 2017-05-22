using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13
{
    public class Auto:TransporteTerrestre
    {
        private int _cantRuedas;

        public override string Detalle
        {
            get { return base._cantidadPasajeros.ToString() + this._cantRuedas.ToString() + (int)base._velocidadMaxima; }
        }

        public Auto(int p, int r, EVelocidad v):base(p,v)
        {
            this._cantRuedas = r;
        }

        public override string Frenar()
        {
            return "El auto esta frenando";
        }
        public override string Acelerar()
        {
            return base.Acelerar();
        }


    }
}
