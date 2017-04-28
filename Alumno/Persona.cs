using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno
{
    class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _dni;

        public Persona(string name, string surname, int document)
        {
            this._nombre = name;
            this._apellido = surname;
            this._dni = document; 
        }

        public string Mostrar()
        {
            return this._nombre + this._apellido + this._dni.ToString();
        }


    }
}
