using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Entidades
{
    public class Paleta
    {
        private Tempera[] _colores;
        private int _cantidadMaximaColores;

        
        

        private Paleta():this(5)
        {}
        private Paleta(int a)
        {
            this._colores = new Tempera[a];
            this._cantidadMaximaColores = a;
        }
        public static implicit operator Paleta(int a)
        {
            Paleta miPaleta = new Paleta(a);
            return miPaleta;
        }

        private string Mostrar()
        {
            string mensaje = "";
            foreach (Tempera b in this._colores)
            {
                mensaje = mensaje + (string)b + "\n";
            }

            return "Cantidad de colores" + this._cantidadMaximaColores.ToString() + "\n" + mensaje;
        }

        public static explicit operator string(Paleta p1)
        {
            return p1.Mostrar();
        }

        public static Boolean operator ==(Paleta p1, Tempera t1)//VER SI ESTA BIEN
        {
            foreach (Tempera t2 in p1._colores)
            {
                if (t2 == t1)
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean operator !=(Paleta p1, Tempera t1)
        {
            return !(p1 == t1);
        }

        public static Paleta operator +(Paleta p1, Tempera t1)
        {
            int i, j = 0;
            for (i = 0; i < p1._colores.GetLength(0); i++)
            {
                if (p1._colores[i] == t1)
                {
                    p1._colores[i] = p1._colores[i] + t1;
                    j = 1;
                    break;
                }
            }
            if (j == 0)
            {
                for (i = 0; i < p1._colores.GetLength(0); i++)
                {
                    if (p1._colores[i] == null)
                    {
                        p1._colores.SetValue(t1, i);
                        break;
                    }
                }

            }
            return p1;
        }
         
        public static Paleta operator -(Paleta p1, Tempera t1)
        {
            int i;
            for (i = 0; i < p1._colores.GetLength(0); i++)
            {
                if (p1._colores[i] == t1)
                {
                    p1._colores[i] = p1._colores[i] - t1;
                    if (p1._colores[i] == 0)////COMO SE QUE COMPARA EL 0 CON LA CANTIDAD
                        p1._colores[i] = null;
                    break;
                } 
            }
            return p1;
        }
        public static Paleta operator +(Paleta p1, Paleta p2)
        {
            int a,i,j,flag;
            a = p1._colores.GetLength(0) + p2._colores.GetLength(0);
            Paleta p3 = new Paleta(a);
            for(i=0;i<p1._colores.GetLength(0);i++)
            {
                flag=0;
                for(j=0; j<p2._colores.GetLength(0);j++)
                {
                    if(p1._colores[i] == p2._colores[j])
                    {
                        p3._colores[i]= p1._colores[i] + p2._colores[j];//hay que hacer un add o sumando ya lo agrega a la paleta??
                        flag=1;
                        break;
                    }
                }
                //flag esta en 0 add
                if(flag == 0)
                {
                    p3._colores[i] = (Tempera)p1._colores.GetValue(i);//ESTA BIEN???
                    p3._colores.SetValue(p1._colores.GetValue(i),i);//CUAL DE LAS DOS
                }
            }
            for(i=0;i<p2._colores.GetLength(0);i++){
            //for nuevo para agregar lo de la segunda paleta que falta
            //si paleta2 no coincide con ninguno de paleta3 add, si coincide no hace nada porque ya lo agrego antes
            }
        }

        public int ObtenerIndice()
        {
            
    }
 

    }
}
