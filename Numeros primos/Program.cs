using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int num = 1000;
            for (int i = 1; i <= num; i++)
            {
                count = 0;
                for (int i_2 = 1; i_2 <= i; i_2++)
                {
                    if (i % i_2 == 0)
                    {
                        count++;
                    }
                    if (count > 2)
                    {
                        break;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(i + " Es primo.");
                }
            }
        }
    }
}
