using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_numeros_a_letras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numero a transformar (1-10): ");
            string dato = Console.ReadLine();
            int numTransform = Convert.ToInt32(dato);

            ConversorLetras(numTransform);
        }

        static void ConversorLetras(int num)
        {
            if (num == 0)
                Console.WriteLine("Cero");
            if (num == 1)
                Console.WriteLine("Uno");
            if (num == 2)
                Console.WriteLine("Dos");
            if (num == 3)
                Console.WriteLine("Tres");
            if (num == 4)
                Console.WriteLine("Cuatro");
            if (num == 5)
                Console.WriteLine("Cinco");
            if (num == 6)
                Console.WriteLine("Seis");
            if (num == 7)
                Console.WriteLine("Siete");
            if (num == 8)
                Console.WriteLine("Ocho");
            if (num == 9)
                Console.WriteLine("Nueve");
            if (num == 10)
                Console.WriteLine("Diez");

        }
    }
}
