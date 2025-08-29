using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Francisco_Osenda
{
    internal class Arrays1Ej1
    {
        public static void Ejecutar() // Cargar un array con 10 números aleatorios entre 1 y 100. Mostrar el mayor y el menor.
        {
            int[] numeros = new int[10];
            Random random = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(1, 101);
            }
            int max = numeros[0];
            int min = numeros[0];
            for (int j = 0; j < numeros.Length; j++)
            {
                for (int k = (j + 1); k < numeros.Length; k++)
                {
                    if (numeros[j] < min)                  
                        min = numeros[j];                    
                    else if (numeros[j] > max)                   
                        max = numeros[j];
                }
            }
            Console.WriteLine("Los números generados son:");
            foreach (int i in numeros)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine($"El número máximo es: {max}");
            Console.WriteLine($"El número mínimo es: {min}");

        }
    }
}
