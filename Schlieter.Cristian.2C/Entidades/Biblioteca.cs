using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        private Biblioteca()
        {
            this._libros = new List<Libro>();
        }

        private Biblioteca(int capacidad):this()
        {
            this._capacidad = capacidad;
        }

        public static string Mostrar(Biblioteca b)
        {
            string retorno = "";
            foreach (Libro p in b._libros)
            {

                if (p is Manual)
                {
                    retorno += ((Manual)p).Mostrar();
                }
                if (p is Novela)
                {
                    retorno += ((Novela)p).Mostrar();
                }
            }
            return retorno;
        }

        public static implicit operator Biblioteca(int capacidad)
        {
            Biblioteca miBiblioteca = new Biblioteca(capacidad);
            return miBiblioteca;
        }
        
        public static Boolean operator ==(Biblioteca b, Libro l)
        {
            foreach (Libro p in b._libros)
            {
                if (p == l)
                    return true;
            }
            return false;
        }

        public static Boolean operator !=(Biblioteca b, Libro l)
        {
            return !(b == l);
        }

        public static Biblioteca operator +(Biblioteca b, Libro l)
        {
            if (b._capacidad > 0 && b != l)
            {
                b._libros.Add(l);
                b._capacidad--;
                return b;
            }
            else if (b._capacidad == 0)
            {
                Console.WriteLine("No hay mas lugar en la biblioteca");
                return b;
            }
            else
            {
                Console.WriteLine("El libro ya esta en la biblioteca");
                return b;
            }
        }

        private double ObtenerPrecio(ELibro tipoLibro)
        {
            if(tipoLibro == ELibro.Manual)
            {
                return PrecioDeManuales;
            }
            else if(tipoLibro == ELibro.Novela)
            {
                return PrecioDeNovelas;
            }
            else
            {
                return PrecioTotal;
            }
        }

        public double PrecioDeManuales
        {
            get
            {
                double totalM = 0; 
                foreach (Libro p in this._libros)
                {
                    if (p is Manual)
                    {
                        totalM = totalM +(Manual)p;
                    }
                }
                return totalM;
            }
        }
        public double PrecioDeNovelas
        {
            get
            {
                double totalN = 0;
                foreach (Libro p in this._libros)
                {
                    if (p is Novela)
                    {
                        totalN = totalN + (Novela)p;
                    }
                }
                return totalN;
            }
        }
        public double PrecioTotal
        {
            get
            {
                double totalA = 0;
                foreach (Libro p in this._libros)
                {
                    if (p is Manual)
                    {
                        totalA = totalA + (Manual)p;
                    }
                    else
                    {
                        totalA = totalA + (Novela)p;
                    }
                }
                return totalA;
            }
        }

                

    
    }
}
