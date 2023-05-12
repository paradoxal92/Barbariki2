using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine("Введите {0}-й элемент массива", k + 1);
                a[k] = int.Parse(Console.ReadLine());
            }
            int max = a[0];
            int min = a[0];
            for (int i = 1; i < n; i++) 
            {
                if (a[i] < min)
                {
                    if (min>max)
                    {
                        max = min;
                        min = a[i];
                        i = i++;
                        
                    }
                    else
                    {
                        min = a[i];
                        i = i++;
                        
                    }
                }
                else
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                        i = i++;
                        

                    }
                    else
                    {
                        i = i++;
                       
                    }
                }
            }
            int S = max + min;
            Console.Write("сумма наибольшего и наименьшего элемента массива: " + S);
        }
    }
}
