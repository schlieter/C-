using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Autor
    {
        private string _apellido;
        private string _nombre;

        public Autor(string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }

        public static Boolean operator ==(Autor a, Autor b)
        {
            if (a._nombre == b._nombre && a._apellido == b._apellido)
                return true;
            else
                return false;
        }
        public static Boolean operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }

        public static implicit operator string(Autor a)
        {
            return a._apellido + a._nombre;
        }


    }
}
