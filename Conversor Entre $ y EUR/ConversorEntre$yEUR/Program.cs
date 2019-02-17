using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorEntre_yEUR
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, tc, moneda, ma;
            float monedaActual, cambio, tasaDeCambio;
            //configuramos un saludo
            Console.WriteLine("Cual es tu nombre?");
            name = Console.ReadLine();
            Console.WriteLine("Hola {0} mucho gusto", name);

            //tipo de moneda
            Console.WriteLine("Cual es el tipo de moneda al que desea convertir?");
            moneda = Console.ReadLine();

            //validamos los tipos de moneda del cliente
            if (moneda == "dolar" | moneda == "euro")
            {
                //pedimos el tipo de cambio del dia
                Console.WriteLine("OK, {0}, dime a cuanto esta el cambio?", name);
                tc = Console.ReadLine();
                tasaDeCambio = Convert.ToSingle(tc);

                //Moneda del cliente
                Console.WriteLine("Cuanta plata tienes?");
                ma = Console.ReadLine();
                monedaActual = Convert.ToSingle(ma);

                //calculo de los valores
                cambio = monedaActual * tasaDeCambio;

                //mostrar cambio
                Console.WriteLine("Aqui tienes el resultado: \n{0} en {1} es {2}", monedaActual, moneda, cambio);
            }
            else
            {
                Console.WriteLine("Lo siento, solo se puede hacer la conversion entre dolar y euro");
            }          
        }
    }
}
