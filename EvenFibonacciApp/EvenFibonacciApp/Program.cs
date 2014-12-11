using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciApp
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 1;
            int b = 2;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            int sumResult = 0;
            for (int i = 0; i < 10; i++)
            {
                int number = (Fibonacci(i));
                if (number%2 == 0)
                {
                  sumResult = sumResult+number;
                  //Console.WriteLine(sumResult);
                }
            }
            Console.WriteLine(sumResult);
            Console.ReadKey();
        }
    }
}
