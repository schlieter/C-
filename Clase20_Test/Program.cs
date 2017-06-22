using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Clase20;

namespace Clase20_Test
{
    class Program
    {
        public static void EscribirLog(string a)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\alumno\Desktop\Excepciones.txt",true);
            sw.WriteLine(DateTime.Now + " " + a);
            sw.Close();
        }
        static void Main(string[] args)
        {
            try
            {
                Cartuchera<Utiles> miCartuchera = new Cartuchera<Utiles>("Karpatos", 3);
                Lapicera l1 = new Lapicera(ConsoleColor.Black, "medio");
                Lapicera l2 = new Lapicera(ConsoleColor.Blue, "fino");
                Goma g1 = new Goma(true);
                Goma g2 = new Goma(false);

                l1.Marca = "BIC";
                l1.Precio = 3;

                miCartuchera.AgregarUtil = l1;
                miCartuchera.AgregarUtil = l2;
                miCartuchera.AgregarUtil = g1;
                //miCartuchera.AgregarUtil = g2;

                if (miCartuchera.SerializarXML(AppDomain.CurrentDomain.BaseDirectory + "Cartuchera.xml"))
                { Console.WriteLine("OK"); Console.ReadLine(); }
                else
                { Program.EscribirLog("Error de Serializacion"); }
                    
                Cartuchera<Utiles> cartu = new Cartuchera<Utiles>();

                if (miCartuchera.DeserializarXML(AppDomain.CurrentDomain.BaseDirectory + "Cartuchera.xml", out cartu))
                { Console.WriteLine(cartu.ToString()); Console.ReadLine(); }
                else
                { Program.EscribirLog("Error de Deserializacion"); }
            }
            catch (CartucheraLlenaExcepcion e) { Console.WriteLine(e.Message); Program.EscribirLog(e.Message); Console.ReadLine(); }
            catch (Exception e) { Console.WriteLine(e.Message); Program.EscribirLog(e.Message); Console.ReadLine(); }
            
            
            

        }
    }
}
