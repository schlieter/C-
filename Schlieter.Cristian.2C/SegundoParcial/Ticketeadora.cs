using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace SegundoParcial
{
    public static class Ticketeadora
    {
        public static bool ImprimirTicket(this Cajon<Platano> c, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);
                sw.Write(DateTime.Now + " Precio total: " + c.PrecioTotal);
                sw.Close();
                return true;
            }
            catch (Exception) { return false; }
        }
        public static string ObtenerPreciosBD(this ISerializable bd)
        {
            try
            {
                string retorno = "";
                SqlConnection _conexion;
                _conexion = new SqlConnection(Properties.Settings.Default.Precios);
                SqlCommand cm = new SqlCommand("SELECT * FROM PreciosFruta", _conexion);
                _conexion.Open();
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read() != false)
                {
                    retorno = dr["id"].ToString() + dr["descripcion"].ToString() + dr["precio"].ToString() + "\n";
                }
                dr.Close();
                _conexion.Close();
                return retorno;
            }
            catch (SqlException e) { return e.Message; }
        }
    }
}
