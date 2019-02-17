using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_atencion_a_clientes_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //ponemos en pantalla un "logo"
            Banner();

            //creacion de la lista de los clientes
            Queue listaClientes = new Queue();
            string index = "";
            do
            {
                Console.Write("     Bienvenido a nuestro sistema.\nPresiona 1 para continuar...");
                index = Console.ReadLine();

                //llamamos al banner otra vez
                Banner();

                if (index == "1")
                {

                    //Agregamos las mesas que hay en el restaurante al queue
                    for (int i = 0; i <= 4; i++)
                    {
                        string iteracion = Convert.ToString(i + 1);
                        string tableName = "Mesa " + iteracion;
                        listaClientes.Enqueue(tableName);
                        Banner();
                    }

                    Console.WriteLine("1. Cuanto falta para que llegue mi pedido.");
                    Console.Write("Elige tu opcion: ");
                    index = Console.ReadLine();

                    //Codigo que va a hacer casi todo lo de la app
                    if (index == "1")
                    {

                        Console.WriteLine("\nCual es el numero de tu mesa: ");
                        index = Console.ReadLine();
                        Banner();

                        //convierte el numero en el ID de la mesa
                        index = "Mesa " + index;
                        foreach (string i in listaClientes)
                        {

                            //Recorre los elementos del queue
                            if (i == index)
                            {
                                Console.WriteLine("{0}, Este es su turno.", i);
                            }
                            else
                            {
                                Console.WriteLine("{0}", i);
                            }
                        }
                    }
                }



            } while (index == "1");
        }//MAIN

        static void Banner()
        {

            //Banner de la aplicacion

            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine(" Atencion al cliente Restaurante LasaSOn");
            Console.WriteLine("=========================================\n");

        }//BANNER

        static void Sleep(int milliseconds)
        {
            //Permite poder tener tiempo de espera en el codigo

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; ; i++)
            {
                if (i % 50000 == 0)
                {
                    stopwatch.Stop();
                    if (stopwatch.ElapsedMilliseconds > milliseconds)
                    {
                        break;
                    }
                    else
                    {
                        stopwatch.Start();
                    }
                }
            }

        }//SLEEP


    }//CLASS PROGRAM
}
