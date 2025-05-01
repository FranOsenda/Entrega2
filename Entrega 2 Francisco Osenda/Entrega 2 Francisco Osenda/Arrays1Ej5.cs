using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Francisco_Osenda
{
    internal class Arrays1Ej5
    {
        public static void Ejecutar() // Cargar un array de 5 números. Crear un segundo array con los mismos valores pero ?
        {
            int[] arreglo = new int[5]; 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el númeroo N°{i+1}");
                int num = int.Parse(Console.ReadLine()); 
            }
        }
    }
}
