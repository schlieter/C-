using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
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
        public float GananciaPorLocal
        {
            get { return CalcularGanancia(TipoLlamada.Local); }
        }
        public float GananciaPorProvincia
        {
            get { return CalcularGanancia(TipoLlamada.Provincial); }
        }
        public float GananciaTotal
        {
            get { return CalcularGanancia(TipoLlamada.Todas); }
        }
        public List<Llamada> Llamadas
        {
            get { return this._listaDeLlamadas; }
        }
        //Metodos
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0;
            foreach(Llamada a in this._listaDeLlamadas)
            {
                if(a is Provincial && tipo == TipoLlamada.Provincial)
                {
                    ganancia += ((Provincial)a).CostoLlamada;
                }
                else if(a is Local && tipo == TipoLlamada.Local)
                {
                    ganancia += ((Local)a).CostoLlamada;
                }
                else
                {
                    if(a is Provincial)
                    {
                        ganancia += ((Provincial)a).CostoLlamada;
                    }
                    else
                    {
                        ganancia +=((Provincial)a).CostoLlamada;
                    }
                }
            }
            return ganancia;
        }
        public void Mostrar()
        {
            Console.WriteLine("Llamadas: \n");
            foreach (Llamada a in this._listaDeLlamadas)
            {
                if (a is Provincial)
                {
                    ((Provincial)a).Mostrar();
                }
                else
                {
                    ((Local)a).Mostrar();
                }
            }

        }
        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
