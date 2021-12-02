using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Необходимо ввести целое положительное число(N):");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N >= Convert.ToInt32(1))
            {
                for (int I = 1, Y = 1; I <= N; I++, Y += (2 * I - 1))

                {
                    Console.WriteLine("Квадрат {0} равен {1}", I, Y);
                }
            }
            if (N < Convert.ToInt32(1))
            {
                Console.WriteLine("Ошибка: Укакзанное число не соответствует заданным условиям");
            }
            Console.ReadKey();
        }
    }
}
