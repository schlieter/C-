using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno
{
    class Alumno:Persona
    {
        private string _curso;
        private List<float> _notas;

        public Alumno(string name, string surname, int document):base(name,surname,document)
        {
            this._notas = new List<float>();
        }

        public Alumno(string name, string surname, int document, string curso): this(name, surname, document)
        {
            this._curso = curso; 
        }

        public string Mostrar()
        {
            string notas = "";
            foreach (float n in this._notas)
            {
                notas = notas + n.ToString() + ";";
            }
            return base.Mostrar() + " " + this._curso + " " + notas;
        }

    }
}
