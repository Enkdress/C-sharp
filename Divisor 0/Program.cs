using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisor_0
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedimos el dividendo
            Console.WriteLine("Dividendo: ");
            string div = Console.ReadLine();
            float dividendo = Convert.ToSingle(div);

            //pedimos el divisor
            Console.WriteLine("Divisor:");
            div = Console.ReadLine();
            float divisor = Convert.ToSingle(div);

            //si el divisor es 0 entonces no se puede hacer la operacion
            if (divisor != 0)
            {
                float resultado = dividendo / divisor;
                Console.WriteLine("El resultado de la division es {0} ", resultado);
            }
            else
            {
                Console.WriteLine("No se pudo realizar la operacion.");
            }
        }
    }
}
