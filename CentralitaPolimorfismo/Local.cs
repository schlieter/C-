using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Local:Llamada
    {
        //Atributo
        protected float _costo;
        //Construtores
        public Local(Llamada unaLlamada, float costo):base(unaLlamada.NroOrigen,unaLlamada.NroDestino,unaLlamada.Duracion)
        {
            this._costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo): base(origen, destino, duracion)
        {
            this._costo = costo;
        }
        //Propiedades
        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        //Metodos
        public override bool Equals(object obj)
        {
            if (obj is Local)
            {
                if (((Local)obj) == this)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        private float CalcularCosto()
        {
            float costo=0;
            return costo = this._costo * base.Duracion;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine(CostoLlamada.ToString());
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
