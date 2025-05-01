using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Francisco_Osenda
{
    internal class Arrays1Ej2
    {
        public static void Ejecutar() //  Solicitar al usuario 8 nombres y almacenarlos en un array. Mostrar cuántos empiezan con la letra 'A'.

        {
            string[] nombres = new string[8];
            string[] nombres_A = new string[8];
            int contador1 = 1; 
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre N°{contador1}");
                string nombre = Console.ReadLine();
                nombres[i] = nombre;
                contador1++;
            }
            int contador2 = 0; 
            for (int j = 0; j < nombres.Length; j++)
            {
                foreach(char k in nombres[j])
                {
                    if(k == 'A' || k == 'a')
                    {
                        nombres_A[contador2] = nombres[j];
                        contador2++;
                    }
                }
            }
            foreach (string i in nombres_A)
                Console.Write(i+" ");
        }

    }
}
