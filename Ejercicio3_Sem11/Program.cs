//N00458733

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Sem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char omitir;
            int[] numeros = { 4, 8, 10, 15 };
            EscribirElementosDelArreglo(numeros);
            Console.WriteLine("Presione cualquier tecla para ver el arreglo cambiado.");
            numeros[2] = 36;
            omitir = char.ToUpper(Console.ReadKey(true).KeyChar);
            EscribirElementosDelArreglo(numeros);
            Console.ReadKey();
        }

        static void EscribirElementosDelArreglo(int[] arreglo)
        {
            Console.Write("Los números ingresados son: ");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"{arreglo[i]} ");
            }
            Console.WriteLine();
        }
    }
}

