using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус основания цилиндра");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту цилиндра");
            double h = Convert.ToDouble(Console.ReadLine());
            double V = Math.PI * (R * R) * h;
            Console.Write("Объем цилиндра равен: " + V);
        }
    }
}
