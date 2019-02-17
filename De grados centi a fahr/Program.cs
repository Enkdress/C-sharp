using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_grados_centi_a_fahr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Grados Celcius: ");
            string dato = Console.ReadLine();
            float degree = Convert.ToSingle(dato);

            ConvertirGrados(degree);
        }
        static float ConvertirGrados(float num)
        {
            float resultado = (num * 9/5)+32;
            Console.WriteLine("La conversion a Fahrenheit es de {0}", resultado);
            return 0;
        }
    }
}
