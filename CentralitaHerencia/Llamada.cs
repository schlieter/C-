using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Llamada
    {
        //Atributos
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        //Constructor
        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }
        //Propiedades
        public float Duracion
        {
            get { return this._duracion; }
        }
        public string NroDestino
        {
            get { return this._nroDestino; }
        }
        public string NroOrigen
        {
            get { return this._nroOrigen; }
        }
        //Metodos
        public static int OrdenarPorDuracion(Llamada a, Llamada b)
        {
            return string.Compare(a.Duracion.ToString(), b.Duracion.ToString());
        }
        public void Mostrar()
        {
            StringBuilder a = new StringBuilder();
            a.AppendLine("Duracion: " + this.Duracion.ToString());
            a.AppendLine("Nro Destino :" + this.NroDestino);
            a.AppendLine("Nro Origen :" + this.NroOrigen);
            Console.WriteLine(a);
        }
    }
}
