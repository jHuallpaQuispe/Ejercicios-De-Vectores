using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            // - Número de Artículo (1 a 15)
            // - Cantidad Vendida 

            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10.

            int[] articulo = new int[15];
            int cantVendida, numArticulo;

            for (int x = 0; x < 15; x++)
            {
                articulo[x] = 0;
            }


            Console.WriteLine("NUMERO DE ARTICULO(1 A 15): ");
            numArticulo =  int.Parse(Console.ReadLine());
            Console.WriteLine("CANTIDAD VENDIDA: ");
            cantVendida = int.Parse(Console.ReadLine());

            while (numArticulo !=0){
                //   PASA QUE EL NUM DE ARTICULO SOLO VA DE 1 A 15 Y EL VEC ES DE 15 
                articulo[numArticulo - 1] += cantVendida; 

                Console.WriteLine("NUMERO DE ARTICULO(1 A 15): ");
                numArticulo =  int.Parse(Console.ReadLine());
                Console.WriteLine("CANTIDAD VENDIDA: ");
                cantVendida = int.Parse(Console.ReadLine());
            }

            int mayor = 0, posicion = 0;

            for (int x = 0; x < 15; x++){
                if(articulo[x] > mayor){
                    mayor = articulo[x];
                    posicion = x+1;
                }
                
            }
            Console.WriteLine("EL ARTICULO QUE MAS SE VENDIO: " + posicion + " CON " + mayor +" UNIDADES VENDIDAS");
            for (int x = 0; x < 15; x++){
                if(articulo[x] == 0)
                    Console.WriteLine("NO REGISTRO VENTA EL ARTICULO: "+ (x+1));
            }

            Console.WriteLine("EL ARTICULO 10 VENDIO: "+ articulo[9] + " UNIDADES");
        }   
    }
}
