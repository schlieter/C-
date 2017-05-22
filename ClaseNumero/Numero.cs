using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14
{
    public class Numero
    {
        protected double _numero;

        public Numero(double n)
        {
            this._numero = n;
        }

        public double Numeros
        {
            get { return this._numero; }
        }

        public static double operator +(Numero a, Numero b)
        {
            double retorno = 0;
            retorno = a.Numeros + b.Numeros;
            return retorno;
        }

        public static double operator -(Numero a, Numero b)
        {
            double retorno = 0;
            retorno = a.Numeros - b.Numeros;
            return retorno;
        }
        public static double operator *(Numero a, Numero b)
        {
            double retorno = 0;
            retorno = a.Numeros * b.Numeros;
            return retorno;
        }
        public static double operator /(Numero a, Numero b)
        {
            double retorno = 0;
            try { retorno = a.Numeros / b.Numeros; }
            catch (DivideByZeroException) { Console.WriteLine("error"); }
            return retorno;
        }

    }
}
