using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Francisco_Osenda
{
    internal class Arrays2Ej2
    {
        public static void Ejecutar()// Cargar una matriz de 3x3. Mostrar la fila con mayor suma.
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
            double filaMax = sumaFila1;
            string Fila = "Fila 1";
            if (filaMax < sumaFila2)
            {
                filaMax = sumaFila2;
                Fila = "Fila 2";
                if (filaMax < sumaFila3)
                {
                    filaMax = sumaFila3;
                    Fila = "Fila 3";
                }                    
            }
            else if (filaMax < sumaFila3)
            {
                filaMax = sumaFila3;
                Fila = "Fila 3"; 
            }
            Console.WriteLine($"La fila con mayor suma es {Fila} y el total es: {filaMax}");
        }
    };
}
