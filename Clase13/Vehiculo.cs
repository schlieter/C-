using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13
{
    public abstract class Vehiculo
    {
        protected int _cantidadPasajeros;
        protected EVelocidad _velocidadMaxima;

        public Vehiculo(int c, EVelocidad v)
        {
            this._cantidadPasajeros = c;
            this._velocidadMaxima = v;
        }

        public abstract string Detalle { get; }//tambien podria ser virtual 

        public abstract string Frenar();

        public virtual string Acelerar()//podria ser un metodo comun
        {
            return "Esta acelerando a: " + ((int)this._velocidadMaxima).ToString();
        }

    }
}
