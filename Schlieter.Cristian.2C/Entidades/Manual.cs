using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Manual:Libro
    {
        protected ETipo tipo;

        public Manual(string titulo,float precio, string nombre, string apellido, ETipo t):base(precio,titulo,nombre,apellido)
        {
            this.tipo = t;
        }

        public string Mostrar()
        {
            return base._autor + base._titulo + this.tipo + base._cantidadDePaginas.ToString() + base._precio.ToString();
        }

        public static Boolean operator ==(Manual a, Manual b)
        {
            if (a.tipo == b.tipo && a._titulo == b._titulo)
                return true;
            else
                return false;
        }

        public static Boolean operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }

        public static implicit operator double(Manual a)
        {
            return (double)a._precio;
        }
        


    }
}
