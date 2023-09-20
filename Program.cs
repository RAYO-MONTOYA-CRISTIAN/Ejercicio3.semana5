using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerccio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de notas: ");
            int limite = int.Parse(Console.ReadLine());

            int suma = 0;
            int promedio = 0;
            for (int i = 0; i < limite; i++)
            {
                Console.WriteLine("Ingrese la nota " + (i + 1));
                int numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
                promedio = suma / limite;
            }
            Console.WriteLine("El promedio es: " + promedio);

        }
    }
}
