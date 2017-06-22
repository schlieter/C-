using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20
{
    public class Lapicera:Utiles
    {
        private ConsoleColor _color;
        protected string _trazo;
        
        public ConsoleColor Color { get { return this._color; } set { this._color = value; } }
        public string Trazo { get { return this._trazo; } set { this._trazo = value; } }

        public Lapicera() { }
        public Lapicera(ConsoleColor color, string trazo)
        {
            this._color = color;
            this._trazo = trazo;
        }

        public override string Marca { get; set; }
        public override float Precio { get; set; }

        public override string ToString()
        {
            return base.UtilesToString() + " Color: " + this._color.ToString() + " Trazo: " + this._trazo + "\n";
        }
    }
}
