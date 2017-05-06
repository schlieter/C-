using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Novela:Libro
    {
        public EGenero genero;

        public Novela(string titulo, float precio, Autor autor, EGenero g)
            : base(titulo,autor, precio)
        {
            this.genero = g;
        }
        public string Mostrar()
        {
            return base._autor + base._titulo + this.genero + base._cantidadDePaginas.ToString() + base._precio.ToString();
        }

        public static Boolean operator ==(Novela a, Novela b)
        {
            if (a._titulo == b._titulo && a.genero == b.genero)
                return true;
            else
                return false;
        }

        public static Boolean operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }

        public static implicit operator double(Novela a)
        {
            return (double)a._precio;
        }




    }
}