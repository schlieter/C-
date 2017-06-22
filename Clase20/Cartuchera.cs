using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Clase20
{
    [Serializable]
    public class Cartuchera<T>:ISerializable
    {
        private int _capacidad;
        private string _marca;
        private List<T> _utiles;

        public int Capacidad { get { return this._capacidad; } set { this._capacidad = value; } }
        public string Marca { get { return this._marca; } set { this._marca = value; } }

        public List<T> Utiles { get { return this._utiles; } }

        public T AgregarUtil
        {
            set
            {
                //try
                //{
                    if (this._utiles.Count < this._capacidad)
                    {
                        this._utiles.Add(value);
                    }
                    else
                    {
                        throw new CartucheraLlenaExcepcion("Cartuchera Llena!");
                    }
                //}
                //catch (CartucheraLlenaExcepcion e) { Console.WriteLine(e.Message); Console.ReadLine(); }
            }
        }

        public Cartuchera()
        {
            this._utiles = new List<T>();
        }
        public Cartuchera(string marca, int capacidad): this()
        {
            this._marca = marca;
            this._capacidad = capacidad;
        }

        public override string ToString()
        {
            string cadena = "Marca: " + this._marca + " Capacidad: " + this._capacidad.ToString() + "\n";
            foreach (T a in this._utiles)
            {
                cadena += a.ToString();
            }
            return cadena;
        }
        public bool SerializarXML(string a)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Cartuchera<T>));
                StreamWriter sw = new StreamWriter(a);
                xml.Serialize(sw, this);
                sw.Close();
                return true;
            }
            catch (Exception) {return false; }
        }

        public bool DeserializarXML(string a, out Cartuchera<Utiles> cartuchera)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Cartuchera<T>));
                StreamReader sr = new StreamReader(a);
                cartuchera = (Cartuchera<Utiles>)xml.Deserialize(sr);
                sr.Close();
                return true;
            }
            catch (Exception) { cartuchera = null; return false; }
        }
    }
}
