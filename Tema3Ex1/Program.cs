using System;

namespace Tema3Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 3 numere");
            int numar1 = int.Parse(Console.ReadLine());
            int numar2 = int.Parse(Console.ReadLine());
            int numar3 = int.Parse(Console.ReadLine());
            int aux = 0;

            if (numar1 >= numar2 & numar1 >= numar3)
            {
                aux = numar1;
            }
            if (numar2 >= numar1 & numar2 >= numar3)
            {
                aux = numar2;
            }
            if (numar3 >= numar1 & numar3 >= numar2)
            {
                aux = numar3;
            }


            Console.WriteLine("Maximul numerelor este " + aux);


        }


       
    }
}
