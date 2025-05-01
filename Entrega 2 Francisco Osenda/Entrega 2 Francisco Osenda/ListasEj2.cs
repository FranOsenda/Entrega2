using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Francisco_Osenda
{
    internal class ListasEj2
    {
        public static void Ejecutar()//Pedir al usuario que ingrese 7 números y guardarlos en una lista. Luego pedir otro número y verificar si está en la lista. Mostrar un mensaje informando si se encontró o no.{
        {
            List<int> numeros = new List<int>();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Ingrese el valor N°{i + 1}");
                int num = int.Parse(Console.ReadLine());
                numeros.Add(num);
            }
            Console.WriteLine("Ingrese el número que desea buscar dentro de la lista");
            int numero = int.Parse(Console.ReadLine());
            int contador = 1; 
            for (int i = 0; i < 7; i++)
            {
                if (numeros[i] == numero)
                {
                    Console.WriteLine($"El número {numero} está en la lista");
                    break;
                }                    
                else
                    contador++;                 
            }
            if (contador > numeros.Count)
                Console.WriteLine($"El número {numero} no se encuentra en la lista");
        }
    }
}
