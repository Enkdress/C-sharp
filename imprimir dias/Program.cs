using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imprimir_dias
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedimos el numero del dia y lo convertimos a int
            Console.WriteLine("Numero del dia: ");
            string i = Console.ReadLine();
            int num = Convert.ToInt32(i);

            //comparamos el numero con los dias de la semana
            if (num == 1)
            {
                Console.WriteLine("Es Lunes.");
            }
            else if (num == 2)
            {
                Console.WriteLine("Es Martes.");
            }
            else if (num == 3)
            {
                Console.WriteLine("Es Miercoles.");
            }
            else if (num == 4)
            {
                Console.WriteLine("Es Jueves.");
            }
            else if (num == 5)
            {
                Console.WriteLine("Es Viernes.");
            }
            else if (num == 6)
            {
                Console.WriteLine("Es Sabado.");
            }
            else if (num == 7)
            {
                Console.WriteLine("Es Domingo.");
            }
            else
            {
                Console.WriteLine("Dia no valido");
            }
        }
    }
}
