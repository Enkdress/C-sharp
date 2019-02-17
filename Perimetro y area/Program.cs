using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetro_y_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado;
            
            if (true)
            {
                //Calculando el apotema 
                Console.Write("Numero de lados: ");
                string i = Console.ReadLine();
                int cantLados = Convert.ToInt32(i);
                Console.Write("Valor de los Lados(cm): ");
                i = Console.ReadLine();
                int valorLado = Convert.ToInt32(i);
                
                //preguntamos que quiere calcular
                Console.Write("Que Calculamos: \na. Area\nb. Perimetro\n");
                i = Console.ReadLine();

                //opcion elegida
                if (i == "a")
                {
                    double alpha = 360 / cantLados;
                    alpha = alpha * (Math.PI / 180);
                    double ap = valorLado / (2 * (Math.Tan(alpha / 2)));
                    resultado = ((/*perimetro*/(cantLados * valorLado) * ap) / 2);
                    float result = Convert.ToSingle(resultado);
                    Console.WriteLine("El area del poligono de {0} lados es {1}cm²", cantLados, result);
                }
                else if (i == "b")
                {
                    resultado = cantLados * valorLado;
                    Console.WriteLine("El perimetro del poligono de {0} lados es {1}cm", cantLados, resultado);
                }
                else
                {
                    Console.WriteLine("Opcion invalida");
                }
            }
        }
    }
}
