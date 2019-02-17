using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadesYEjemplos
{
    class Activities
    {
        static void Main(string[] args)
        {
            string nombre = " ";
            int edad = 18;
            //Actividad del capitulo 1
            Console.WriteLine("Actividad del capitulo 1 del libro");
            nombre = Console.ReadLine(); //De esta manera pedimos datos al usuario
            Console.WriteLine("Mi nombre es {0} y tengo {1} años\n", nombre, edad);

            //Capitulo 2
            //Ejemplo del capitulo 2
            Console.WriteLine("Ejemplo 1 del capitulo 2");
            Console.WriteLine("Pasos para hornear una torta: \n1. Precalentar el horno.\n2. Batir margarina con azucar.\n3. Agregar huevos.\n4. Cernir harina.\n5. Agregar a la mezcla y leche.\n6. Hornear por 40 minutos.\n7. Decorar y comer.\n");

            //Convertir a tipo int
            string intInput; //Variable donde se guarda el IN
            int operation; //Variable donde se guarda la conversion del string a int
            intInput = Console.ReadLine();
            operation = Convert.ToInt32(intInput);
            Console.WriteLine(operation + 2);

            //Convertir a tipo float
            string floatInput;
            float floatOperation;
            floatInput = Console.ReadLine();
            floatOperation = Convert.ToSingle(floatInput);
            Console.WriteLine(floatOperation * 2);
        }
    }
}





