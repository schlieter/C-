using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace SegundoParcial
{
    public class Manzana:Fruta,ISerializable
    {
        public string distribuidora;

        public Manzana() { }
        public Manzana(float peso,  ConsoleColor color, string distribuidora)
            : base(peso, color)
        {
            this.distribuidora = distribuidora;
        }

        public override bool TieneCarozo
        {
            get { return  true; }
        }
        public string Tipo { get { return " Manzana "; } }

        protected override string FrutaToString()
        {
            return this.Tipo + base.FrutaToString();
        }
        public override string ToString()
        {
            return this.FrutaToString();
        }

        public string RutaArchivo {get; set;}

        public bool SerializarXML()
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Manzana));
                StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + this.RutaArchivo);
                xml.Serialize(sw, this);
                sw.Close();
                return true;
            }
            catch (Exception) { return false; }
        }
        public bool Deserializar()
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Manzana));
                StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + this.RutaArchivo);
                Manzana m = (Manzana)xml.Deserialize(sr);
                sr.Close();
                return true;
            }
            catch (Exception) { return false; }
        }
    }
}
