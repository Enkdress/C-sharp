using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetroPoligonal
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos las variables a utilizar
            string lado;
            float perimetro = 0;
            string cantidadDeLados;
            float a;
            int b;
            //empezamos el algoritmo
            Console.WriteLine("Introduce el valor del lado (cm)");

            lado = Console.ReadLine(); //se pide el el valor del lado

            a = Convert.ToSingle(lado); //valor del lado

            Console.WriteLine("Introduce la cantidad de lados del poligono");
            cantidadDeLados = Console.ReadLine(); //pedimos la cant. de lados

            b = Convert.ToInt32(cantidadDeLados); //cant de lados

            perimetro = a * b; //hacemos el proceso para calcular el perimetro

            //imprimimos el perimetro
            Console.WriteLine("El perimetro del poligono que tiene {1} lados y cada uno mide {0}cm es de {2} unidades", a, b, perimetro);

        }
    }
}
