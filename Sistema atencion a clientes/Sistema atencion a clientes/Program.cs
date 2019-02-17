using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_atencion_a_clientes
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue nombresClientes = new Queue();
            string index = "";
            string menu = "0";
            int cantPersonas = 0;
            int freeComputer = 0;


            do
            {
                menu = Menu("__Nueva informacion__\n1. Ingreso\n0. Cerrar\n");

                Console.WriteLine("Vas a usar una PC?\nPresiona 1");
                index = Console.ReadLine();

                if (index == "1")
                {
                    Console.WriteLine("Cual es tu nombre: ");
                    index = Console.ReadLine();

                    //indexamos el nombre escrito dentro de nuestro queue
                    nombresClientes.Enqueue(index);
                }
                
                //obtenemos el valor de cuantas personas hay en el queue
                cantPersonas = nombresClientes.Count;

                //"obtenemos un pc libre"
                freeComputer = FreeComputer(cantPersonas);

                //Menu para saber si se desea coger esa PC
                menu = Menu("Un computador esta libre, deseas cogerlo?\n1. Si\n2. No\n");

                if (menu == "1")
                {
                    if (freeComputer == 1)
                    {
                        string primerNombre = ""; //primer nombre en la lista

                        primerNombre = Convert.ToString(nombresClientes.Dequeue());
                        Console.WriteLine(primerNombre);    
                    }
                }
                

            } while (menu == "1");
           
        }//cierre de main

        static int FreeComputer(int personas)
        {
            int a = 0;
            //cada "cierto tiempo" un pc esta disponible
            if(personas != 0)
            {
                for (int i = 300; i >= 0; i--)
                {
                    a = i + 1;
                }
            }

            return a;

        }//cierre de freeComputer

        static string Menu(string message)
        {
            //Creamos el menu para saber que es lo que el usuario desea hacer
            Console.Write(message);

            string index = Console.ReadLine();
            Console.Clear();

            return index;
        }//Menu function
    }
}
