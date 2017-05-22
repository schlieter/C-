using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Provincial:Llamada
    {
        //Enumerado
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }
        //Atributo
        protected Franja _franjaHoraria;
        //Constructores
        public Provincial(Franja miFranja, Llamada unaLlamada): base(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion)
        {
            this._franjaHoraria = miFranja;
        }
        public Provincial(string origen, string destino, float duracion, Franja miFranja): base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }
        //Propiedades
        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }
        //Metodos
        private float CalcularCosto()
        {
            float costo = 0;
            if (this._franjaHoraria == Franja.Franja_1)
            {
                costo += base.Duracion * (float)0.99;
                return costo;
            }
            else if (this._franjaHoraria == Franja.Franja_2)
            {
                costo += base.Duracion * (float)1.25;
                return costo;
            }
            else
            {
                costo += base.Duracion * (float)0.66;
                return costo;
            }
        }
        
        public override bool Equals(object obj)
        {
            if (obj is Provincial)
            {
                if (((Provincial)obj) == this)//pregunto dos veces si es provincial porque obj tiene adentro un "provincial"(que esta encapsulado como object)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Franja Horaria: " + this._franjaHoraria.ToString());
            sb.AppendLine(CostoLlamada.ToString());
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        //Sobrecarga
       /* public static Boolean operator ==(Provincial a, Provincial b)
        {
            if (a._franjaHoraria == b._franjaHoraria)
                return true;
            else
                return false;
        }
        public static Boolean operator !=(Provincial a, Provincial b)
        {
            return !(a == b);
        }*/
    }
}
