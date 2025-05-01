using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Francisco_Osenda
{
    internal class Arrays2Ej1
    {
        public static void Ejecutar()// Crear una matriz de 3x3. Solicitar al usuario que ingrese todos los elementos y luego mostrar la suma de cada fila.
        {
            double[,] matriz = new double[3, 3];
            double num;
            double sumaFila1 = 0;
            double sumaFila2 = 0;
            double sumaFila3 = 0;
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
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    if (fila == 0)
                        sumaFila1 += matriz[fila, columna];
                    else if (fila == 1)
                        sumaFila2 += matriz[fila, columna];
                    else if (fila == 2)
                        sumaFila3 += matriz[fila, columna];

                }
            }
            Console.WriteLine($"La suma de la Fila 1 es: {sumaFila1}, la de la Fila 2 es: {sumaFila2} y la de la Fila 3 es: {sumaFila3}");
        }
    }
}
