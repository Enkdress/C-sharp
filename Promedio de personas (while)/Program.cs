using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_de_personas__while_
{
    class Program
    {
        static void Main(string[] args)
        {
            float personas = 0.0f;
            int edades = 0;
            int ingreso = 0;
            float edadCounter = 0.0f;
            int masJoven = 1000;
            int masViejo = 0; 
            string respuesta = "";
            float promedio = 0.0f;

            while (ingreso == 0 || respuesta == "si")
            {
                //datos de las personas
                Console.Write("Nombre de la persona: ");
                string dato = Console.ReadLine();
                personas++;

                //edad 
                Console.Write("Edad de {0}: ", dato);
                dato = Console.ReadLine();
                edades = Convert.ToInt32(dato);
                edadCounter = edadCounter + edades;

                if (edades < masJoven)
                {
                    masJoven = edades;
                }

                if (edades > masViejo)
                {
                    masViejo = edades;
                }

                //calculos
                promedio = edadCounter / personas;

                //pregunta del millon
                Console.WriteLine("Desea continuar ingresando integrantes al grupo?");
                Console.Write("si/no: ");
                respuesta = Console.ReadLine();

                ingreso++;
            }
            Console.WriteLine("El promedio de edades es de {0}", promedio);
            Console.WriteLine("La edad mas joven es de {0}", masJoven);
            Console.WriteLine("La edad de la persona con mas years es de {0}", masViejo);
        }
    }
}
