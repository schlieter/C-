using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Libro
    {
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;

        static Libro()
        {
            Libro._generadorDePaginas = new Random();//VER 
        }
        
        public Libro(float precio, string titulo, string nombre, string apellido):this(titulo,new Autor(nombre,apellido),precio)
        {
            
        }
        public Libro(string titulo, Autor a,float precio)
        {
            this._titulo = titulo;
            this._precio = precio;
            this._autor = a;
        }

        public int CantidadDePaginas
        {
            get{
                    if(this._cantidadDePaginas == 0)
                    {
                        this._cantidadDePaginas = this._generadorDePaginas.Next(10,580);
                    }
                    return _cantidadDePaginas;
                }
        }//VER!!! PIDE QUE NO RETORNE UN VALOR QUE YA RETORNO ANTES

        private static string Mostrar(Libro l)
        {
            return l._autor + l._titulo + l._precio.ToString() + l.CantidadDePaginas.ToString();
        }

        public static Boolean operator ==(Libro a, Libro b)
        {
            if(a._titulo == b._titulo && a._autor == b._autor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean operator !=(Libro a, Libro b)
        {
            return !(a==b);
        }

        public static explicit operator string(Libro l)
        {
            return Libro.Mostrar(l);
        }

          


    }
}
