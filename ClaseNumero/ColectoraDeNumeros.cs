using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14
{
    public class ColectoraDeNumeros:Exception
    {
        protected List<Numero> _numeros;

        public ETipoNumero TipoNumero
        {
            get;
            set;
        }
        private ColectoraDeNumeros()
        {
        }
        public ColectoraDeNumeros(ETipoNumero a):this()
        {
            this.TipoNumero = a;
        }
        public static Boolean operator ==(ColectoraDeNumeros c, Numero n)
        {
            foreach (Numero a in c._numeros)
            {
                if (a.Numeros == n.Numeros)
                    return true;  
            }
            return false;
        }
        public static Boolean operator !=(ColectoraDeNumeros c, Numero n)
        {
            return !(c == n);
        }
        public static ColectoraDeNumeros operator +(ColectoraDeNumeros c, Numero n)
        {
            switch (c.TipoNumero)
	        {
                case ETipoNumero.Par:
                    if ((n.Numeros % 2) == 0)
                    { c._numeros.Add(n); }
                    else
                    { Console.WriteLine("Error"); }
                    break;
                case ETipoNumero.Impar:
                    if((n.Numeros % 2)!=0)
                    {   c._numeros.Add(n);}
                    else
                    {   Console.WriteLine("Error");}
                    break;
                case ETipoNumero.Positivo:
                    if(n.Numeros > 0)
                    {   c._numeros.Add(n);}
                    else
                    {   Console.WriteLine("Error");}
                    break;
                case ETipoNumero.Negativo:
                    if(n.Numeros < 0)
                    {   c._numeros.Add(n);}
                    else
                    {   Console.WriteLine("Error");}
                    break;
                case ETipoNumero.Cero:
                    if(n.Numeros == 0)
                    {    c._numeros.Add(n);}
                    else
                    {   Console.WriteLine("Error");}
                    break;
            }
            return c;
        }
        public static ColectoraDeNumeros operator -(ColectoraDeNumeros c, Numero n)
        {
            if (c == n)
                c._numeros.Remove(n);
            else
                Console.WriteLine("Error el numero no se encuentra en la lista");
            return c;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("La lista es de tipo: "+ this.TipoNumero.ToString());
            foreach (Numero n in this._numeros)
            {
                sb.AppendLine(n.Numeros.ToString());
            }
            return sb.ToString();
        }                
	}		
}
       