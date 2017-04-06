using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Sobrecarga
{
    public class Pluma
    {
        private string marca;
        private int cantidad;
        private Tinta tinta;

        public Pluma()
        {
            this.marca ="sin marca";
            this.cantidad = 0;
            this.tinta = null;
        }

        public Pluma(string a):this()
        {
            this.marca = a;
        }

        public Pluma(string a, int b)
            : this(a)
        {
            this.cantidad = b;
        }

        public Pluma(string a, int b, Tinta c):this(a,b)
        {
            this.tinta = c;
        }

        public string Mostrar()
        {
            return this.marca.ToString() + this.cantidad.ToString() + Tinta.Mostrar(this.tinta);
        }

        //*

        public static Pluma operator +(Pluma p, Tinta t)
        {
            if (p.tinta == t)//*Modificar con la sobrecarga que me falta
            {
                p.cantidad++;
                return p;
            }
            else
            {
                return p;
            }
        }

        public static Pluma operator -(Pluma p, Tinta t)
        {
            if (p.tinta == t)
            {
                if (p.cantidad > 1)
                {
                    p.cantidad--;
                }
                
            }
        }
    }
}
