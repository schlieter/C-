using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class Camion:Vehiculo
    {
        
        protected float _tara;

        public Camion(string a, byte b, Emarcas c, float t): base(a, b, c)
        {
            this._tara = t;
        } 
        

        public string MostrarCamion()
        {
            return base.Mostrar() + this._tara.ToString();
        }
    }
}
