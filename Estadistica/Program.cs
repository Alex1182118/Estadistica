using System;

namespace Estadistica
{
    class Program
    {
        private static int[] rango;
        static void Main(string[] args)
        {
            Random rnd = new Random();
            rango = new int[2];
            for (int i = 0; i <2; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Ingrese el rango de inicio que desee");
                }
                else
                {
                    Console.WriteLine("Ingrese el rango final que desee");
                }
                string linea;
                linea = Console.ReadLine();
                rango[i] = int.Parse(linea);
            }
            int numeroRandom = rnd.Next(rango[0],rango[1]);
            Console.WriteLine("Número entre " + rango[0] +" y " + rango[1] + " : {0}", numeroRandom);
            Console.ReadKey();
        }
    }
}
