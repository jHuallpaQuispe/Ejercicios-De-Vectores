using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10 números enteros y los guarde en un vector.
            //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
            
            int[] numero = new int[10];
            int N, mayor = 0, posicion = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("INGRESE UN NUMERO: ");
                N = int.Parse(Console.ReadLine());

                numero[x] = N;
            }
            mayor = numero[0];
            posicion = 1;

            for (int x = 0; x < 10; x++)
            {
                if(numero[x] > mayor){
                    mayor = numero[x];
                    posicion = x+1;
                }
            }
            Console.WriteLine("\n\t\tEL VALOR MAXIMO ---> " + mayor);
            Console.WriteLine("\t\tSU POSICION ---> " + posicion );
        }
    }
}
