using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Francisco_Osenda
{
    internal class Arrays2Ej3
    {
        public static void Ejecutar() //Pedir el nombre y 3 notas de 5 estudiantes. Mostrar el promedio de cada uno
        {
            List<string> nombres = new List<string>();
            List<List<double>> notas = new List<List<double>>();
            string nombre;
            double nota;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre del estudiante");
                nombre = Console.ReadLine();
                nombres.Add(nombre);
                List<double> notaAlumno = new List<double>();

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese la nota N°{j + 1} de {nombres[i]}");
                    nota = double.Parse(Console.ReadLine());
                    notaAlumno.Add(nota);
                }
                notas.Add(notaAlumno);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"El promedio de {nombres[i]} es:");
                double promedio = 0;
                foreach (int j in notas[i])
                {
                    promedio += j;
                }
                promedio = promedio / notas[i].Count;
                Console.WriteLine(promedio);
            }
        }
    }
}
