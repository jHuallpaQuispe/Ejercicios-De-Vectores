using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10  números enteros y los guarde en un vector.
            //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
            
            int[] numero = new int[10];
            int N;
            float promedio;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("INGRESE UN NUMERO: ");
                N = int.Parse(Console.ReadLine());

                numero[x] = N;
                
            }
            int acu = 0;
            for (int x = 0; x < 10; x++)
            {
                acu+= numero[x];
            }

            promedio = acu / 10;
            Console.WriteLine("\n\t\tEL PROMEDIO ES ---->" + promedio);
            for (int x = 0; x < 10; x++)
            {
                if(numero[x] > promedio)
                    Console.WriteLine("ES MAYOR AL PROMEDIO: " + numero[x]); 
            }
        }
    }
}
