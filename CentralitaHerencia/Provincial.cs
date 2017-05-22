using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
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
        public Provincial(Franja miFranja, Llamada unaLlamada):base(unaLlamada.NroOrigen,unaLlamada.NroDestino,unaLlamada.Duracion)
        {
            this._franjaHoraria = miFranja;
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(origen,destino,duracion)
        {
            this._franjaHoraria = miFranja;
        }
        //Propiedades
        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }
        //Metodos
        private float CalcularCosto()
        {
            float costo;
            if(this._franjaHoraria == Franja.Franja_1)
            {
                costo = base.Duracion * (float)0.99;
                return costo;
            }
            else if(this._franjaHoraria == Franja.Franja_2)
            {
                costo = base.Duracion * (float)1.25;
                return costo;
            }
            else
            {
                costo = base.Duracion * (float)0.66;
                return costo;
            }
        }
        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            base.Mostrar();
            sb.AppendLine("Franja Horaria: " + this._franjaHoraria.ToString());
            sb.AppendLine(CostoLlamada.ToString());
            Console.WriteLine(sb);
        }
    }
}
