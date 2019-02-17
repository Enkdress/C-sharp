using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_De_Multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int result = 0;
            int n = 0;

            //pedimos el numero a multiplicar
            Console.Write("De que numero deseas saber la tabla de multiplicar: ");
            string i = Console.ReadLine();
            int num = Convert.ToInt32(i);

            for (n = 1; n <= 10; n++)
            {
                result = num * n;
                Console.WriteLine("{0} x {1} = {2}",num, n, result);
            }
        }
    }
}
