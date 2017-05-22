using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11
{
    public class ClaseTres :ClaseDos
    {
        protected string _atributoClaseTres;

        public ClaseTres(string a, string b, string c)
            : base(b, c)
        {
            this._atributoClaseTres = a;
        }

        public override string Tipo
        {
            get { return "Clase Tres hereda de " + base.Tipo; }
        }

        public override string Mostrar()
        {
            return this._atributoClaseTres + base.Mostrar();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
