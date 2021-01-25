using System;

namespace Desafio_02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entradas
            Console.Write("Ingrese y: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Ingrese z: ");
            double z = double.Parse(Console.ReadLine());

            //proceso
            //variable t
            double t = Math.Sqrt(((y)*(y)) + ((z)*(z)));
            Console.Write("t: " + t);

            //varible c
            double c = Math.Asin((z / t));
            double cGrados = c * (180.0 / Math.PI);
            Console.Write("c: " + cGrados);
           
            //variable a
            double a = 180 - 90 - cGrados;
            Console.Write("a: " + a);

        }
    }
}
