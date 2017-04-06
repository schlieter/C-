using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Sobrecarga
{
    public class Tinta
    {
        private ConsoleColor color;
        private ETipo tipo;

        public Tinta()
        {
            this.color = ConsoleColor.Blue;
            this.tipo = ETipo.Comun;
        }
        public Tinta(ConsoleColor a): this()
        {
            this.color = a;
        }

        public Tinta(ConsoleColor a, ETipo b):this(a)
        {
            this.tipo = b;
        }

        private string Mostrar()
        {
            return this.color.ToString() + this.tipo.ToString();
        }

        public static string Mostrar(Tinta a)
        {
            return a.color.ToString() + a.tipo.ToString();
        }

        public static Boolean operator ==(Tinta t1, Tinta t2)
        {

            if (t1.color == t2.color && t1.tipo == t2.tipo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean operator !=(Tinta t1, Tinta t2)
        {
            return !(t1 == t2);
        }
    }
}
