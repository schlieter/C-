using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace SegundoParcial
{
    public class Cajon<T>:ISerializable
    {
        private int _capacidad;
        private float _precioUnitario;
        private List<T> _frutas;

        public Cajon()
        {
            this._frutas = new List<T>();
        }
        public Cajon(int capacidad):this()
        {
            this._capacidad = capacidad;
        }
        public Cajon(int capacidad, float precio): this(capacidad)
        {
            this._precioUnitario = precio;
        }
        public List<T> Frutas { get { return this._frutas; } }
        public float PrecioTotal { get { return (this._precioUnitario * this._frutas.Count); } }
        public int Capacidad { get { return this._capacidad; } set { this._capacidad = value; } }

        public static Cajon<T> operator +(Cajon<T> c, T f)
        {
            try
            {
                if (c._capacidad > c._frutas.Count)
                {
                    c._frutas.Add(f);
                    return c;
                }
                else
                {
                    throw new CajonLlenoException("El cajon no tiene espacio disponible");
                }
            }
            catch (CajonLlenoException e) { Console.WriteLine(e.Message); return c;  }
        }
        public override string ToString()
        {
            string mensaje = "Capacidad: " + this._capacidad.ToString() + " Cantidad total de frutas: " + this._frutas.Count.ToString() + " Precio total : " + this.PrecioTotal.ToString() + "\n";
            foreach (T f in this._frutas)
            {
                mensaje += f.ToString() + "\n";
            }
            return mensaje;
        }

        public string RutaArchivo { get; set; }

        public bool SerializarXML()
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Cajon<T>));
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
                XmlSerializer xml = new XmlSerializer(typeof(Cajon<T>));
                StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + this.RutaArchivo);
                Cajon<T> m = (Cajon<T>)xml.Deserialize(sr);
                sr.Close();
                return true;
            }
            catch (Exception) { return false; }
        }
     }
}
