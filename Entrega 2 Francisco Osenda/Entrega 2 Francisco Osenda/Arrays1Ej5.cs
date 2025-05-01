using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Francisco_Osenda
{
    internal class Arrays1Ej5
    {
        public static void Ejecutar() //Cargar un array de 5 números. Crear un segundo array con los mismos valores pero inverso(?
        {
            int[] arreglo = new int[5];
            int c = 1;
            for (int i = arreglo.Length - 1; i > -1; i--)
            {
                Console.WriteLine($"Ingrese el valor N°{c}");
                int num = int.Parse(Console.ReadLine());
                arreglo[i] = num;
                c++;
            }
            Console.WriteLine("El arreglo en orden inverso es: ");
            foreach(int i in arreglo)
                Console.Write(i+" ");
        }
    }
}
