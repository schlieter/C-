using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno
{
    class Program
    {
        static void Main(string[] args)
        {
            Obrero miObrero1 = new Obrero("Homero ", 20780960, "Simpson ", 21, 14000f);
            Alumno miAlumno1 = new Alumno("Bart ", "Simpson ", 42003021, "3ero");
            Alumno miAlumno2 = new Alumno("Lisa ", "Simpson ", 41980782, "4to");

            List<Persona> listaDePersonas = new List<Persona>();

            listaDePersonas.Add(miObrero1);
            listaDePersonas.Add(miAlumno1);
            listaDePersonas.Add(miAlumno2);

            foreach (Persona a in listaDePersonas)
            {
                if (a is Obrero)
                    Console.WriteLine(Obrero.Mostrar((Obrero)a));
                else if (a is Alumno)
                    Console.WriteLine(((Alumno)a).Mostrar());
                Console.ReadLine();
            }

            


        }
    }
}
