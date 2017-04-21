using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Entidades
{
    public class Tempera
    {
        private ConsoleColor _color;
        private string _marca;
        private int _cantidad;

        public Tempera(ConsoleColor a, string b, int c)
        {
            this._color = a;
            this._marca = b;
            this._cantidad = c;
        }

        private string Mostrar()
        {
            return this._color.ToString() + this._marca.ToString() + this._cantidad.ToString();
        }

        public static string Mostrar(Tempera a)
        {
            return a.Mostrar();
        }

        public static Boolean operator ==(Tempera t1, Tempera t2)
        {
            if (t1._marca == t2._marca && t1._color == t2._color)
                return true;
            else
                return false;
        }
        public static Boolean operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static implicit operator int(Tempera t1)
        {
            return t1._cantidad;
        }

        public static explicit operator string (Tempera t1)
        {
            return t1.Mostrar();
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            if (t1 == t2)
            {
                t1._cantidad = t1._cantidad + t2._cantidad;
                return t1;
            }
            else
                return t1;
        }

        public static Tempera operator +(Tempera t1, int a)
        {
            t1._cantidad = t1._cantidad + a;
            return t1;
        }

        public static Tempera operator -(Tempera t1, Tempera t2)
        {
            if (t1 == t2)
            {
                t1._cantidad = t1._cantidad - t2._cantidad;
                return t1;
            }
            else
                return t1;
        }


    }
}
