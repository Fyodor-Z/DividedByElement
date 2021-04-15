using System;
using System.Linq;
using System.Collections.Generic;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X");
            int X = int.Parse(Console.ReadLine());

            Random rndm = new Random();
            List<int> Array = new List<int>();

            int arrayLength = rndm.Next(11, 31); //array length

            for (int i = 0; i < arrayLength; i++)
            {
                Array.Add(rndm.Next(1, 10));
            }
            Console.WriteLine("Given array:");
            Console.WriteLine(string.Join(",", Array));
            Console.WriteLine($"List of elements divided by X:");
            Console.WriteLine(string.Join(",", Array.Where(a => a % X == 0).ToList()));
            Console.WriteLine($"List of elements X is divided by:");
            Console.WriteLine(string.Join(",", Array.Where(a => X % a == 0).ToList()));
        }
    }
}
