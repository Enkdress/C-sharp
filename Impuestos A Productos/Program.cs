using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impuestos_A_Productos
{
    class Program
    {
        static void Main(string[] args)
        {
            float result;
            float impuesto = 0.19f;

            //preguntar que producto es
            Console.WriteLine("De que producto quieres saber el impuesto: ");
            string producto = Console.ReadLine();
            
            //cuanto es el valor neto
            Console.WriteLine("Cuanto es el valor neto del producto: ");
            string i = Console.ReadLine();
            float valorNeto = Convert.ToSingle(i);

            //calcular el impuesto
            result = impuesto * valorNeto;

            //si es medicina el impuesto es de 0
            if (producto == "medicina" || producto == "Medicina")
            {
                result = 0;
            }

            //imprimir el resultado
            Console.WriteLine("El impuesto (19%) del producto {0} es: {1}", producto, result);
        }
    }
}
