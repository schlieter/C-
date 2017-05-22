using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local:Llamada
    {
        //Atributo
        protected float _costo;
        //Constructores
        public Local(Llamada unaLlamada, float costo):base(unaLlamada.NroOrigen,unaLlamada.NroDestino,unaLlamada.Duracion)
        {
            this._costo = costo;
        }
        public Local(string origen, string destino,float duracion, float costo):base(origen,destino,duracion)
        {
            this._costo = costo;
        }
        //Propiedades
        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }      
        //Metodos
        private float CalcularCosto()
        {
            float costo = this._costo * base.Duracion;
            return costo;   
        }
        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            base.Mostrar();
            sb.AppendLine(this.CostoLlamada.ToString());
            Console.WriteLine(sb);
        }
    }
}
