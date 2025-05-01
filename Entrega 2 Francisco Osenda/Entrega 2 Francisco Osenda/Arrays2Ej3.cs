using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Francisco_Osenda
{
    internal class Arrays2Ej3
    {
        public static void Ejecutar() // Crear una matriz de 3x3. Reemplazar todos los elementos negativos por cero.
        {
            double[,] matriz = new double[3, 3];
            double num;
            for (int columna = 0; columna < 3; columna++)
            {
                Console.WriteLine($"Ingrese el valor de la fila N°{columna + 1}");
                for (int fila = 0; fila < 3; fila++)
                {
                    Console.WriteLine($"Ingrese el valor la columna N°{columna + 1} de la fila {fila + 1}");
                    num = double.Parse(Console.ReadLine());
                    matriz[fila, columna] = num;
                }
            }
            for (int columna = 0; columna < 3; columna++)
            {
                for (int fila = 0; fila < 3; fila++)
                {
                    if (matriz[fila, columna] < 0)
                        matriz[fila, columna] = 0;
                }
            }
            Console.WriteLine("La matriz con los valores negativos remplazados por 0 es: ");
            for (int columna = 0; columna < 3; columna++)
            {                
                for (int fila = 0; fila < 3; fila++)
                {
                    Console.Write($"  {matriz[fila, columna]}" );
                }
                Console.WriteLine(" ");
            }
        }
    }
}
