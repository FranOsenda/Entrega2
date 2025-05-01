using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Francisco_Osenda
{
    internal class ListasEj1
    {
        public static void Ejecutar()//Solicitar al usuario que ingrese 5 números enteros y guardarlos en una lista. Luego calcular y mostrar la suma total de los elementos.
        {
            List<int> numeros = new List<int>(); 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el valor N°{i+1}");
                int num = int.Parse(Console.ReadLine());
                numeros.Add(num); 
            }
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma += numeros[i];
            }
            Console.WriteLine($"La suma de los números ingresados es: {suma}");
        }
    }
}
