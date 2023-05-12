using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x");
            float x = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите координату y");
            float y = Convert.ToSingle(Console.ReadLine());
            if (((x * x) + (y * y)) > 1)
            {
                Console.WriteLine("Точка принадлежит указанной области");
            }
            else 
            {
                Console.WriteLine("Точка не принадлежит указанной области");
            }
        }
    }
}
