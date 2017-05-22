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
            get
            {
                string retorno = "Precio Auto: " + this._precioAuto.ToString() + "// Precio Camion: " + this._precioCamion.ToString() + "// Precio Moto: " + this._precioMoto.ToString() + "\n";
                foreach (Vehiculo a in this._vehiculos)
                {
                    if (a is Auto)
                    {
                        retorno = retorno + ((Auto)a).MostrarAuto() + "\n";
                    }
                    else if (a is Camion)
                    {
                        retorno = retorno + ((Camion)a).MostrarCamion() + "\n";
                    }
                    else if (a is Moto)
                    {
                        retorno = retorno + ((Moto)a).MostrarMoto() + "\n";
                    }
                }
                return retorno;
            }
        }
        
        public List<Vehiculo> Vehiculos
        {
            get {return this._vehiculos;}
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
        public static Lavadero operator -(Lavadero l, Vehiculo v)
        {
            if (v == l)
            {
                l._vehiculos.Remove(v);
                return l;
            }
            return l;
        }

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
        //
        //
        //De instancia tienen que ser estos
        //
        //
        public static int CompararMarcaAscendente(Vehiculo a, Vehiculo b)
        {
            return string.Compare(a.Patente, b.Patente);
            //return a.Marca.CompareTo(b.Marca);
        }
        public static int CompararMarcaDescendente(Vehiculo a, Vehiculo b)
        {
            return string.Compare(b.Patente, a.Patente);
            //return b.Marca.CompareTo(a.Marca);
        }
        



    }
}
