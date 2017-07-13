using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace SegundoParcial
{
    [XmlInclude(typeof(Platano))]
    [XmlInclude(typeof(Manzana))]
    [Serializable]
    public abstract class Fruta
    {
        private ConsoleColor _color;
        private float _peso;

        public float Peso { get { return this._peso; } set { this._peso = value; } }
        public ConsoleColor Color { get { return this._color; } set { this._color = value; } }

        public abstract bool TieneCarozo { get; }

        public Fruta(){}

        public Fruta(float peso, ConsoleColor color)
        {
            this._color= color;
            this._peso = peso;
        }

        protected virtual string FrutaToString()
        {
            if (this.TieneCarozo == true)
                return " Peso: " + this._peso.ToString() + " Color: " + this._color.ToString() + " tiene carozo ";
            else
                return " Peso: " + this._peso.ToString() + " Color: " + this._color.ToString();
        }
    }
}
