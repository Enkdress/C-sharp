using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca el limite: ");
            string index = Console.ReadLine();
            float num = Convert.ToSingle(index);

            //contadores
            int fizzbuzz = 0;
            int fizz= 0;
            int buzz = 0;

            for (int i = 1; i <= num; i++)
            {
                if (Divisible(i,3) && Divisible(i,5))
                {
                    Console.WriteLine("{0} FizzBuzz", i);
                    fizzbuzz++;
                }
                else if (Divisible(i, 3))
                {
                    Console.WriteLine("{0} Fizz", i);
                    fizz++;
                }
                else if (Divisible(i, 5))
                {
                    Console.WriteLine("{0} Buzz", i);
                    buzz++;
                }
                else
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.WriteLine("Cantidad de numeros FizzBuzz: {0}", fizzbuzz);
            Console.WriteLine("Cantidad de numeros Fizz: {0}", fizz);
            Console.WriteLine("Cantidad de numeros Buzz: {0}", buzz);

        }

        static bool Divisible(float num, float divisor)
        {
            if (num % divisor == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
