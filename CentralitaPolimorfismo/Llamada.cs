using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    abstract class Llamada
    {
        //Atributos
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        //Constructor
        public Llamada(string origen, string destino, float duracion)
        {
            this._duracion = duracion;
            this._nroDestino = destino;
            this._nroOrigen = origen;
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
        public abstract float CostoLlamada
        {
            get;
        }
        //Metodos
        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return string.Compare(uno.Duracion.ToString(), dos.Duracion.ToString());
        }
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion: " + this.Duracion.ToString());
            sb.AppendLine("Nro Destino :" + this.NroDestino);
            sb.AppendLine("Nro Origen :" + this.NroOrigen);
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is Llamada)
            {
                if (((Llamada)obj) == this)
                    return true;
                else
                    return false;
            }
            return false;
        }
        //Sobrecargas
        public static Boolean operator ==(Llamada uno, Llamada dos)
        {
            if (uno._nroDestino == dos._nroDestino && uno._nroOrigen == dos._nroOrigen)
                return true;
            else
                return false;
        }
        public static Boolean operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }
    }
}
