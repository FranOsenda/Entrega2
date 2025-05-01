using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Francisco_Osenda
{
    internal class Arrays1Ej4
    {
        public static void Ejecutar()//Crear un array con los días de la semana y mostrar solo los días laborales.
        {
            string[] semana = ["Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado",];
            Console.Write("Los dias de la semana laborales son los: ");
            for (int i = 0; i < semana.Length; i++)
            {
                if (semana[i] != "Domingo" && semana[i] != "Sabado") // tambien puede ser: if (i != 1 && i != 6) 
                    Console.Write(semana[i] + " ");
            }
        }
    }
}
