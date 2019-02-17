using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario_hashtable_
{
    class Program
    {


        static void Main(string[] args)
        {
            Hashtable Dictionary = new Hashtable();
            string index = "";
            string key = "";
            string mainMenu =  "";

            do
            {

                
                //desplegamos el menu
                mainMenu = Menu();

                //ejecutar dependiendo de lo elegido
                if (mainMenu == "1")
                {
                    Console.Write("Palabra a ingresar: ");
                    index = Console.ReadLine();

                    key = index;

                    Console.Write("Significado de la palabra: ");
                    index = Console.ReadLine();

                    //anadimos la palabra y el significado al hash
                    Dictionary.Add(key, index);

                    Console.Clear();
                }
                if (mainMenu == "2")
                {

                    //guardamos la coleccion de la keys en una variable
                    ICollection hashesKeys = Dictionary.Keys;


                    Console.Write("Que palabra deseas buscar: ");
                    index = Console.ReadLine();
                    string sign = "";
                    string word = "";
                    Console.Clear();


                    //recorremos todas la keys
                    foreach (string i in hashesKeys)
                    {
                        //comparamos que la palabra que se esta buscando sea la correcta
                        if (i == index)
                        {
                            word = i;
                            sign = Convert.ToString(Dictionary[i]);
                        }
                    }

                    //imprimir la palabra con el significado
                    if (word == index)
                    {
                        Console.WriteLine("Estos son los resultados de tu busqueda: \n");
                        Console.WriteLine("{0}: {1}\n", word, sign);
                    }
                    
                    
                    //sacar error si la palabra ingresada no existe
                    if (word != index)
                    {
                        Console.WriteLine("No existe la palabra.\n");
                    }
                    
                }
            } while (mainMenu == "1" || mainMenu == "2");

        }//main function


        static string Menu()
        {
            //Creamos el menu para saber que es lo que el usuario desea hacer
            Console.Write("       __Diccionario__\n1. Ayudar a expandir el diccionario.\n2. Buscar una palabra en el diccionario.\n0. Salir.\n");

            string index = Console.ReadLine();
            Console.Clear();

            return index;
        }//Menu function


    }//class
}
