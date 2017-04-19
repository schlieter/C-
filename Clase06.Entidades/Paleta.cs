using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Entidades
{
    public class Paleta
    {
        private Tempera[] _colores;
        private int _cantidadMaximaColores;




        private Paleta()
            : this(5)
        { }
        private Paleta(int a)
        {
            this._colores = new Tempera[a];
            this._cantidadMaximaColores = a;
        }
        public static implicit operator Paleta(int a)
        {
            Paleta miPaleta = new Paleta(a);
            return miPaleta;
        }

        private string Mostrar()
        {
            string mensaje = "";
            foreach (Tempera b in this._colores)
            {
                mensaje = mensaje + (string)b + "\n";
            }

            return "Cantidad de colores" + this._cantidadMaximaColores.ToString() + "\n" + mensaje;
        }

        public static explicit operator string(Paleta p1)
        {
            return p1.Mostrar();
        }

        public static Boolean operator ==(Paleta p1, Tempera t1)
        {
            foreach (Tempera t2 in p1._colores)
            {
                if (t2 == t1)
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean operator !=(Paleta p1, Tempera t1)
        {
            return !(p1 == t1);
        }

        public static Paleta operator +(Paleta p1, Tempera t1)
        {
            int i, j;
            i = p1.ObtenerIndice(t1);
            j = p1.ObtenerIndice();
            if (i < 0)
            {
                if (j > -1)
                    p1._colores[j] = t1;
            }
            else
            {
                p1._colores[i] = p1._colores[i] + t1;
            }
            return p1;
        }

        public static Paleta operator -(Paleta p1, Tempera t1)
        {
            int i;
            i = p1.ObtenerIndice(t1);

            if (i > -1)
            {
                p1._colores[i] = p1._colores[i] - t1;
                if (p1._colores[i] < 1)
                {
                    p1._colores[i] = null;
                }

            }
            return p1;
        }
        public static Paleta operator +(Paleta p1, Paleta p2)
        {
            int a, i;
            a = p1._colores.GetLength(0) + p2._colores.GetLength(0);
            Paleta p3 = new Paleta(a);
            p1._colores.CopyTo(p3._colores, 0);
            for (i = 0; i < p2._colores.GetLength(0); i++)
            {
                p3 = p3 + p2._colores[i];
            }
            return p3;
        }


        public int ObtenerIndice()
        {
            int i;
            for (i = 0; i < this._colores.GetLength(0); i++)
            {
                if (this._colores[i] == null)
                    return i;
            }
            return -1;
        }
        public int ObtenerIndice(Tempera t1)
        {
            int i;
            for (i = 0; i < this._colores.GetLength(0); i++)
            {
                if (this._colores[i] == t1)
                    return i;
            }
            return -1;
        }
    }
}
