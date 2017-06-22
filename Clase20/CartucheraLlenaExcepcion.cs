using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20
{
    public class CartucheraLlenaExcepcion : Exception
    {
        public CartucheraLlenaExcepcion(string m):base(m)
        {
        }
    }
}
