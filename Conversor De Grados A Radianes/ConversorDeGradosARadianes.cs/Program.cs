using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeGradosARadianes.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double p = Math.PI;
            float pi = Convert.ToSingle(p);
            float num;
            float resultado;

            //menu
            Console.WriteLine("Elige la unidad a convertir.\n1.- Grados\n2.- Radianes");
            string i = Console.ReadLine();
            int opcion = Convert.ToInt32(i);

            //validacion y operaciones
            if (opcion == 1)
            {
                Console.WriteLine("Cuantos radianes va a convertir: ");
                i = Console.ReadLine();
                num = Convert.ToSingle(i); //cantidad de radianes
                resultado = num / (pi / 180);

                //mostrar resultado
                Console.WriteLine("El resultado de la conversion de {1}rad es: {0}°", resultado, num);
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Cuantos grados va a convertir: ");
                i = Console.ReadLine();
                num = Convert.ToSingle(i); //cantidad de grados
                resultado = num * (pi / 180);

                //mostrar resultado
                Console.WriteLine("El resultado de la conversion de {1}° es: {0}rad", resultado, num);
            }
            else
            {
                Console.WriteLine("Operacion no valida.");
            }

        }
    }
}
