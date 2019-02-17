using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_y_Exponente
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedimos numero
            Console.Write("Dame el numero: ");
            string dato = Console.ReadLine();
            float num = Convert.ToSingle(dato);

            //pedimos el exponente
            Console.Write("Dame el exponente: ");
            dato = Console.ReadLine();
            float exponente = Convert.ToSingle(dato);

            float constante = num;

            for (int i = 0; i < exponente; i++)
            {
                constante = constante * num;
            }

            Console.WriteLine("El valor de {0} elevado a la {1} es {2}", num, exponente, constante);
        }
    }
}
