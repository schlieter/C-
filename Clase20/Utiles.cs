using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clase20
{
    [XmlInclude(typeof(Lapicera))]
    [XmlInclude(typeof(Goma))]
    public abstract class Utiles
    {
        public abstract float Precio { get; set; }
        public abstract string Marca { get; set; }

        protected virtual string UtilesToString()
        {
            return "Marca: " + this.Marca + " Precio: " + this.Precio.ToString();
        }
    }
}
