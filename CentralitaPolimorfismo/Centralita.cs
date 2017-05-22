using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Centralita
    {
        //Enumerado
        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }
        //Atributos
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        //Constructores
        private Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa): this()
        {
            this._razonSocial = nombreEmpresa;
        }
        //Propiedades
        public List<Llamada> Llamadas
        {
            get {return this._listaDeLlamadas; }
        }
        public float GananciaPorLocal
        {
            get { return CalcularGanancia(TipoLlamada.Local); }
        }
        public float GananciaPorProvincial
        {
            get { return CalcularGanancia(TipoLlamada.Provincial); }
        }
        public float GananciaTotal
        {
            get { return CalcularGanancia(TipoLlamada.Todas); }
        }
        //Metodos
        public override string ToString()
        {
            string retorno = "";
            foreach(Llamada a in this._listaDeLlamadas)
            {
                retorno += a.ToString();
            }
            return retorno;
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this._listaDeLlamadas.Add(nuevaLlamada);
        }
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0;
            foreach (Llamada a in this._listaDeLlamadas)
            {
                if (a is Local && tipo == TipoLlamada.Local)
                {
                    ganancia += ((Local)a).CostoLlamada;
                }
                else if (a is Provincial && tipo == TipoLlamada.Provincial)
                {
                    ganancia += ((Provincial)a).CostoLlamada;
                }
                else
                {
                    if (a is Local)
                    {
                        ganancia += ((Local)a).CostoLlamada;
                    }
                    else
                    {
                        ganancia += ((Provincial)a).CostoLlamada;
                    }
                }
            }
            return ganancia;
        }
        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        //Sobrecargas
        public static Boolean operator ==(Centralita central, Llamada nuevaLlamada)
        {
            foreach (Llamada a in central._listaDeLlamadas)
            {
                if (a == nuevaLlamada)
                    return true;
            }
            return false;
        }
        public static Boolean operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }
        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            if (central != nuevaLlamada)
            {
                central.AgregarLlamada(nuevaLlamada);
                return central;
            }
            else
            {
                Console.WriteLine("La llamada ya se encuentra registrada!");
                return central;
            }
        }
    }
}
