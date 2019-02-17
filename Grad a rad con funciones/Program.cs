using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grad_a_rad_con_funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que desea hacer?");
            Console.WriteLine("1.- Grados -> Rad\n2.- Rad -> Grados");
            string dato = Console.ReadLine();
            int opcion = Convert.ToInt32(dato);

            float respuestaUser = ConversionGradyRad(opcion);
            Console.WriteLine("El resultado de la conversion es {0} ", respuestaUser);

        }
        static float ConversionGradyRad(int opcion)
        {
            //VARIABLES
            double p = Math.PI;
            float pi = Convert.ToSingle(p);
            float resultado;
            float num;

            if (opcion == 1)
            {
                Console.Write("Cuantos grados va a convertir: ");
                string i = Console.ReadLine();
                num = Convert.ToSingle(i);
                resultado = num * (pi / 180);
                return resultado;
            }
            else if (opcion == 2)
            {
                Console.Write("Cuantos radianes va a convertir: ");
                string i = Console.ReadLine();
                num = Convert.ToSingle(i);
                resultado = num / (pi / 180);
                return resultado;
            }
            else
            {
                Console.WriteLine("Hubo un error.");
                return 0;
            }
        }
    }
}

