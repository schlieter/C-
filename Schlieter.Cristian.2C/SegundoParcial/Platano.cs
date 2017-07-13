using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    public class Platano:Fruta
    {
        public string paisOrigen;

        public Platano() { }
        public Platano(ConsoleColor color,  float peso, string pais)
            : base(peso, color)
        {
            this.paisOrigen = pais;
        }

        public override bool TieneCarozo
        {
            get { return false; }
        }
        public string Tipo { get { return " Platano "; } }

        protected override string FrutaToString()
        {
            return this.Tipo + base.FrutaToString();
        }
        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}
