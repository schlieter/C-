using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegundoParcial;

namespace ConsoleApplication1
{
    class Program
    {
        private static bool Serializar(ISerializable obj)
        {
            return obj.SerializarXML();
        }
        private static bool Deserializar(ISerializable obj)
        {
            return obj.Deserializar();
        }
        private static string ObtenerPreciosBD(ISerializable obj)
        {
            return obj.ObtenerPreciosBD();
        }
                
        static void Main(string[] args)
        {
            Cajon<Fruta> miCajon = new Cajon<Fruta>(3, 2);

            Cajon<Platano> miCajon2 = new Cajon<Platano>(3, 2);

            Platano p1 = new Platano(ConsoleColor.Yellow, 0.2f, "Ecuador");
            Platano p2 = new Platano(ConsoleColor.Yellow, 0.150f, "Brasil");

            Manzana m1 = new Manzana(0.3f, ConsoleColor.Red, "Manzanita");
            Manzana m2 = new Manzana(0.320f, ConsoleColor.Red, "Rio Negro");

            miCajon += p1;
            miCajon += p2;
            miCajon += m1;

            miCajon2 += p1;
            miCajon2 += p2;

            miCajon.RutaArchivo = "Cajon.xml";

            if (Program.Serializar(miCajon))
            {
                Console.WriteLine("OK");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("MAAAL");
                Console.ReadLine();
            }

            miCajon2.ImprimirTicket(@"C:\Users\alumno\Desktop\Schlieter.Cristian.2C\Ticket.txt");
    
            




        }
    }
}
