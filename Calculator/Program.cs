using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
        }


        static void Soma() {
            Console.Clear();
            //Console.WriteLine("Hello World!");

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine("Soma: {resultado}");
            // Console.WriteLine("Soma: {v1 + v2}");
            // Console.WriteLine("Soma: " + resultado);
        }
    }
}
