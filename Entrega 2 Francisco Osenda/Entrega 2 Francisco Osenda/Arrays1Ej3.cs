using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Francisco_Osenda
{
    internal class Arrays1Ej3
    {
        public static void Ejecutar()// Ingresar 10 números y mostrar cuántos son positivos, negativos y ceros.
        {
            int[] arreglo = new int[10];
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;
            Console.WriteLine("Ingrese 10 números");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"Ingrese el número N°{i+1}");
                int num = int.Parse(Console.ReadLine());
                arreglo[i] = num;
            }
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] > 0)
                    positivos++;
                else if (arreglo[i] < 0)
                    negativos++;
                else if (arreglo[i] == 0)
                    ceros++;
            }
            Console.WriteLine($"De los números ingresados {positivos} son positivos, {negativos} son negativos y {ceros} son igual a cero");
        }
    }
}
