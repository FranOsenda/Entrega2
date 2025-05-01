using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Francisco_Osenda
{
    internal class ListasEj3
    {
        public static void Ejecutar()// Generar una lista con 10 números aleatorios entre 1 y 100. Luego pedir al usuario un valor límite y eliminar todos los elementos menores a ese valor. Mostrar la lista resultante.
        {
            List<int> numeros = new List<int>(); 
            Random random = new Random();            
            for (int i = 0; i < 10; i++)
                numeros.Add(random.Next(1, 101));
            Console.Write("Los números generados son: ");
            foreach(int i in numeros) 
                Console.Write(i + " ");
            Console.WriteLine(" ");

            Console.WriteLine("Ingrese un valor limite para eliminar los elementos dentro de la lista menores a este");
            int num = int.Parse(Console.ReadLine());
            for (int j = 0; j < numeros.Count; j++)
            {
                if (numeros[j] < num)
                {
                    numeros.RemoveAt(j);
                    j--;
                }                                    
            }
            Console.WriteLine($"En la lista generada los números mayores a {num} son:");
            foreach(int i in numeros)
                Console.Write(i + " ");
                
        }
    }
}
