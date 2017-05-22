using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13
{
    public class Cohete:Vehiculo
    {
        private string _modelo;
        private int _cantidadVentanas;

        public Cohete(int cp, int cv, string m, EVelocidad v):base(cp,v)
        {
            this._cantidadVentanas = cv;
            this._modelo = m;
        }

        public override string Detalle
        {
            get { return this._modelo + base._cantidadPasajeros.ToString() + this._cantidadVentanas.ToString() + (int)base._velocidadMaxima; }
        }

        public override string Frenar()
        {
            return "El cohete esta frenando";
        }

        public override string Acelerar()
        {
            return base.Acelerar();
        }

    }
}
