using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cual es el numero del que quieres el factorial: ");
            string dato = Console.ReadLine();
            int numero = Convert.ToInt32(dato);

            int numFactored = Factorial(numero);
            Console.WriteLine("El factorial de {0} es {1}", numero, numFactored);
        }

        static int Factorial(int num)
        {
            int realNum = num;

            for (int i = 1; i <= realNum; i++)
                num = num * i;

            return num;
        }
    }
}
