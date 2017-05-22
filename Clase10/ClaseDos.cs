using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11
{
    public class ClaseDos:ClaseUno
    {
        protected string _atributoClaseDos;

        public ClaseDos(string a, string b)
            : base(b)
        {
            this._atributoClaseDos = a;
        }

        public override string Tipo
        {
            get { return this._atributoClaseDos + " hereda de " + base.Tipo; }
        }

        public override string Mostrar()
        {
            return this._atributoClaseDos + base.Mostrar(); 
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
