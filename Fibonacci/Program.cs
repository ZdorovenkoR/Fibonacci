using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Написать программу, вычисляющую число Фибоначчи для заданного значения
//рекурсивным способом.

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число итераций числа Фибоначчи");
            int iteration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число Фибоначчи: {0}",Fibonacci(iteration));
            Console.ReadKey();
        }
        static int Fibonacci(int iteration)
        {
            if (iteration == 0 || iteration == 1)
            {
                return (iteration);
            }
            else
            {
                return Fibonacci(iteration - 1) + Fibonacci(iteration - 2);
            }
        }
    }
}
