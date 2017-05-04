using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class Vehiculo
    {
        protected string _patente;
        protected byte _cantRuedas;
        protected Emarcas _marca;

        public string Patente
        {
            get { return this._patente; }
        }
        public Emarcas Marca
        {
            get { return this._marca; }
        }

        protected string Mostrar()
        {
            return this._marca + this._patente + this._cantRuedas.ToString();
        }

        public Vehiculo(string p, byte c, Emarcas m)
        {
            this._patente = p;
            this._cantRuedas = c;
            this._marca = m;
        }
        
        public static Boolean operator ==(Vehiculo a, Vehiculo b)
        {
            if (a._patente == b._patente && a._marca == b._marca)
                return true;
            else
                return false;
        }

        public static Boolean operator !=(Vehiculo a, Vehiculo b)
        {
            return !(a == b);
        }

        public static int CompararPatenteAscendente(Vehiculo a, Vehiculo b)
        {
            //return string.Compare(a.Patente, b.Patente);
            return a.Patente.CompareTo(b.Patente);
        }
        public static int CompararPatenteDescendente(Vehiculo b, Vehiculo a)
        {
            //return string.Compare(a.Patente, b.Patente);
            return a.Patente.CompareTo(b.Patente);
        }
        
    }
}
