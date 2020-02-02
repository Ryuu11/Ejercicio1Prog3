using System;

namespace Ejercicio1prog3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu numero ");

            int numero, invertido, decenas, unidades;

            numero = Convert.ToInt32(Console.ReadLine());

            decenas = numero / 10;
            unidades = numero % 10;
            invertido = (unidades * 10) + decenas;

            Console.WriteLine("Su numero invertido es:" + invertido);
        }
    }
}
