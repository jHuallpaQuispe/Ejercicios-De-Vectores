using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            // CADENA FUENTE: “La mar estaba serena"
            // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            // CADENA RESULTADO: “Li mir estibi sereni"
            
            char[] vecFrase = new char[100];

            char frase, letra1, letra2;

            int x = 0 ;

            Console.WriteLine("INGRESE LETRA POR LETRA UNA FRASE(Punto para cortar)");
            frase = char.Parse(Console.ReadLine());

            while(frase != '.' && x < 100){
                vecFrase[x] = frase;
                frase = char.Parse(Console.ReadLine());
                x++;
            }

            Console.WriteLine("INGRESE 2 LETRAS: ");
            letra1 = char.Parse(Console.ReadLine());

            letra2 = char.Parse(Console.ReadLine());

            Console.WriteLine("CADENA FUENTE: ");

            for (int y = 0; y < x; y++)
            {
                Console.Write(vecFrase[y]);
            }

            for(int y =0; y<x;y++){
                if(vecFrase[y] == letra1)
                    vecFrase[y] = letra2;
             
            }

            Console.WriteLine("\nCADENA RESULTADO : ");
            for (int y = 0; y < x; y++)
            {
                Console.Write(vecFrase[y]);
                
            }

    
        }
    }
}
