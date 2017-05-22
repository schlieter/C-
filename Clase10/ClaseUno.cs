using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11
{
    public class ClaseUno
    {
        protected string _atributoClaseUno;

        public ClaseUno(string a)
        {
            this._atributoClaseUno = a;
        }
        public virtual string Tipo
        {
            get {return "Clase uno\n";}
        }
        public virtual string Mostrar()
        {
            return this._atributoClaseUno;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        
    }
}
