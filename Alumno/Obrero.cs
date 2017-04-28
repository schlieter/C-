using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno
{
    class Obrero:Persona
    {
        private int _legajo;
        private float _sueldo;

        public Obrero(string name, int document, string surname): base (name,surname,document)
        {
        }

        public Obrero(string name, int document, string surname, int file, float salary): this(name, document, surname)
        {
            this._legajo = file;
            this._sueldo = salary;
        }

        public static string Mostrar(Obrero obrero)
        {
            return obrero.Mostrar() + " " + obrero._legajo.ToString() + " " + obrero._sueldo.ToString();
        }
    }
}
