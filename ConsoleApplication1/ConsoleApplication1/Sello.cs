using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.ArmarMensaje();
        }
        public static void Borrar()
        {
            Sello.mensaje = null;
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
        }
        private static string ArmarMensaje()
        {
            int i,j;
            string var = "";
            string m;
            string ret;
            i = Sello.mensaje.Length + 2;
            for(j=0;j<i;j++)
            {
                var = var + "*";
            }
            m = "\n*" + Sello.mensaje + "*\n";
            ret = var + m + var;
            return ret;
        }
    }
}
