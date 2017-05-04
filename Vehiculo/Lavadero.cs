using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

        private Lavadero() 
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float a, float c, float m):this()
        {
            this._precioAuto = a;
            this._precioCamion = c;
            this._precioMoto = m;
        }

        public string lavadero 
        {
            get { return this._precioAuto.ToString() + this._precioCamion.ToString() + this._precioMoto.ToString() + Vehiculos; }
        }

        public string Vehiculos
        {
            get { string v = "";
                  foreach (Vehiculo a in this._vehiculos)
                  { v = v + a.Marca + a.Patente + "\n"; }
                  return v;
                  }
        }

        public Double MostrarTotalFacturado()
        {
            double total = 0;
            total = this.MostrarTotalFacturado(EVehiculos.Auto) + this.MostrarTotalFacturado(EVehiculos.Camion) + this.MostrarTotalFacturado(EVehiculos.Moto);
            return total;
        }
        public Double MostrarTotalFacturado(EVehiculos tipo)
        {
            double total = 0;
            foreach (Vehiculo a in this._vehiculos)
            {
                if (a is Auto && tipo == EVehiculos.Auto)
                {
                    total = total + this._precioAuto;
                }
                else if (a is Camion && tipo == EVehiculos.Camion)
                {
                    total = total + this._precioCamion;
                }
                else if (a is Moto && tipo == EVehiculos.Moto)
                {
                    total = total + this._precioMoto;
                }
            }
            return total;
        }

        public static Boolean operator ==(Vehiculo v, Lavadero l)
        {
            foreach (Vehiculo a in l._vehiculos)
            {
                if (v == a)
                    return true;
            }
            return false;
        }
        public static Boolean operator !=(Vehiculo v, Lavadero l)
        {
            return !(v==l);
        }

        public static Lavadero operator +(Lavadero l, Vehiculo v)
        {
            if (v != l)
            {
                l._vehiculos.Add(v);
                return l;
            }
            return l;
        }
        //FALTA SOBRECARGA DEL OPERADOR -

        public static int CompararPatenteAscendente(Vehiculo a, Vehiculo b)
        {
            //return string.Compare(a.Patente, b.Patente);
            return a.Patente.CompareTo(b.Patente);
        }
        public static int CompararPatenteDescendente(Vehiculo a, Vehiculo b)
        {
            //return string.Compare(a.Patente, b.Patente);
            return b.Patente.CompareTo(a.Patente);
        }

        public int CompararMarcaAscendente(Vehiculo a, Vehiculo b)
        {
            return string.Compare(a.Patente, b.Patente);
            //return a.Marca.CompareTo(b.Marca);
        }
        public int CompararMarcaDescendente(Vehiculo a, Vehiculo b)
        {
            //return string.Compare(a.Patente, b.Patente);
            return b.Marca.CompareTo(a.Marca);
        }
        



    }
}
