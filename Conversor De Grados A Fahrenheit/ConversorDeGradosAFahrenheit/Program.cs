using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeGradosAFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            string celsius;
            float grados;
            float fahrenheit;

            //Pedimos los grados a convertir
            Console.WriteLine("Grados en Celsius: ");
            celsius = Console.ReadLine();

            //lo convertimos a float
            grados = Convert.ToSingle(celsius);

            //calculamos el valor de grados en fahrenheit
            fahrenheit = (grados * 9/5)+32;
            
            //mostramos en consola el valor de grados en fahrenheit
            Console.WriteLine("Aqui tienes la respuesta:\n{0}°C son {1}°F",grados, fahrenheit);
        }
    }
}
