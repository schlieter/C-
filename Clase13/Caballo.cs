using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13
{
    public class Caballo:TransporteTerrestre
    {

        private string _raza;

        public Caballo(int c, string r, EVelocidad v):base(c,v)
        {
            this._raza = r;
        }
        public override string Detalle
        {
            get{return this._raza + base._cantidadPasajeros.ToString() + (int)base._velocidadMaxima;}
        }
        public override string Frenar()
        {
            return "El caballo esta frenando";
        }
        public override string Acelerar()
        {
            return base.Acelerar();
        }

    }
}
