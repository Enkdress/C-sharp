using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_Estudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedimos el numero de salones
            Console.Write("Dame el numero de salones: ");
            string Index = Console.ReadLine();
            int numSalones = Convert.ToInt32(Index);
            int numAlumnos = 0;

            /*float suma = 0;
            int count = 0;
            float minima = 1000.0f;
            float maxima = 0.0f;
            */


            //arreglo para la columna
            float[][] Calif = new float[numSalones][];

            Console.Clear();

            //asignacion de las filas que van a haber dentro de cada columna
            for (int i = 0; i < numSalones; i++)
            {
                Console.Write("Numero de Alumnos en el salon {0}: ", (i + 1/*borrar en caso de error*/));
                Index = Console.ReadLine();
                numAlumnos = Convert.ToInt32(Index);

                Calif[i] = new float[numAlumnos];
            }

            Console.Clear();

            //recogemos toda la informacion sobre las calificaciones
            for (int i = 0; i < numSalones; i++)
            {
                Console.Clear();
                Console.WriteLine("Salon: {0}", (i + 1));

                for (int j = 0; j < Calif[i].GetLength(0); j++)
                {
                    Console.Write("Calificacion: ");
                    Index = Console.ReadLine();

                    //la nota se guarda en el salon 'i' y en el alumno 'j'
                    Calif[i][j] = Convert.ToSingle(Index);

                }
            }

            Console.Clear();

            Console.Write("Que informacion desea saber: \n1. Promedio\n2. Nota minima\n3. Nota maxima\n4. Todo\n");
            Index = Console.ReadLine();
            int consulta = Convert.ToInt32(Index);


            Console.Clear();


            Console.WriteLine("           ____INFORMACION____\n");

            /*
            //calculemos el promedio de las notas

            //PROMEDIO
            for (int i = 0; i < numSalones; i++)
            {
                for (int j = 0; j < Calif[i].GetLength(0); j++)
                {
                    suma += Calif[i][j];
                    count++;
                }
            }

            //calculemos  la menos calificacion

            //MENOR NOTA
            for (int i = 0; i < numSalones; i++)
            {
                for (int j = 0; j < Calif[i].GetLength(0); j++)
                {
                    if (Calif[i][j] < minima)
                    {
                        minima = Calif[i][j];
                    }
                }
            }

            //calculemos la mayor calificacion

            //MAYOR NOTA
            for (int i = 0; i < numSalones; i++)
            {
                for (int j = 0; j < Calif[i].GetLength(0); j++)
                {
                    if (Calif[i][j] > maxima)
                    {
                        maxima = Calif[i][j];
                    }
                }
            }

            float prom = suma / count;
            Console.WriteLine("El promedio de notas es de: {0}", prom);
            Console.WriteLine("La nota minima es de: {0}", minima);
            Console.WriteLine("La nota maxima es de: {0}", maxima);
            */

            ArrayList returnedData = new ArrayList();

            for (int i = 0; i < numSalones; i++)
            {
                for (int j = 0; j < Calif[i].GetLength(0); j++)
                {
                    returnedData = Calculos(numSalones, numAlumnos, Calif);
                }
            }

            if (consulta == 1)
            {
                Console.WriteLine("El promedio de las notas es de: {0}", returnedData[0]);
            }
            if (consulta == 2)
            {
                Console.WriteLine("La nota minima es de: {0}", returnedData[1]);
            }
            if (consulta == 3)
            {
                Console.WriteLine("La nota maxima es de: {0}", returnedData[2]);
            }
            if (consulta == 4)
            {
                Console.WriteLine("El promedio de las notas es de: {0}", returnedData[0]);
                Console.WriteLine("La nota minima es de: {0}", returnedData[1]);
                Console.WriteLine("La nota maxima es de: {0}", returnedData[2]);
            }


        }//cierre main

        static ArrayList Calculos(int numSalones, int numAlumnos, float[][] calif)
        {
            int count = 0; //cuantos numeros son en total
            float suma = 0;
            float minima = 1000.0f;
            float maxima = 0.0f;


            for (int i = 0; i < numSalones; i++)
            {
                for (int j = 0; j < calif[i].GetLength(0); j++)
                {
                    //para el PROMEDIO
                    suma += calif[i][j];
                    count++;

                    //para la nota minima
                    if (calif[i][j] < minima)
                    {
                        minima = calif[i][j];
                    }

                    //para la nota maxima
                    if (calif[i][j] > maxima)
                    {
                        maxima = calif[i][j];
                    }
                }
            }

            //operacion para calcular el promedio
            float promedio = suma / count;

            //arreglo creado para poder devolver todos los valores
            ArrayList returnedData = new ArrayList();
            returnedData.Add(promedio);
            returnedData.Add(minima);
            returnedData.Add(maxima);


            return returnedData;

        }//cierre calculos
    }//cierre clase
}
