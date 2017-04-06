using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TestSobrecarga
    {
        private int entero;
        private DateTime fecha;
        private string cadena;

        public string Mostrar() { return this.entero.ToString() + this.fecha.ToString() + this.cadena; }

        public void Inicializar(string c) { this.cadena = c; }
        public void Inicializar(int e) { this.entero = e; }
        public void Inicializar(DateTime f) { this.fecha = f; }

        public TestSobrecarga() { 
            this.entero = 0; 
            this.fecha = DateTime.Now; 
            this.cadena = "sin valor"; }

        public TestSobrecarga(int en, string ca){
            this.entero = en;
            this.fecha = DateTime.Now;
            this.cadena = ca;}

        public TestSobrecarga(string ca)
        {
            this.entero = 0;
            this.fecha = DateTime.Now;
            this.cadena = ca;
        }
    }
}
