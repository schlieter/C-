using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20
{
    public class Goma:Utiles
    {
        private bool _soloLapiz;

        public override string Marca { get; set; }
        public override float Precio { get; set; }
        public bool SoloLapiz { get{return this._soloLapiz;} set{this._soloLapiz = value;} }

        public Goma() { }
        public Goma(bool sLapiz)
        {
            this._soloLapiz = sLapiz;
        }

        public override string ToString()
        {
            return base.UtilesToString() + " Tipo: " + this._soloLapiz.ToString() + "\n";
        }
    }
}
