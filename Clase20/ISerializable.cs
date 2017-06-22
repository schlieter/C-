using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20
{
    public interface ISerializable
    {
        bool SerializarXML(string a);
        bool DeserializarXML(string a, out Cartuchera<Utiles> cartuchera);
    }
}
