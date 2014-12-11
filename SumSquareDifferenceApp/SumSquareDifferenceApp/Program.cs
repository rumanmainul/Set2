using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDifferenceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfsqr = 0;
            int sqrResult = 0;
            int sumResult = 0;
            int sqrOfSum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sqrResult = i*i;
                sumOfsqr =sumOfsqr+ sqrResult;
               
                
            }
            
            for (int a = 0; a <=100; a++)
            {
                sumResult = sumResult + a;
                sqrOfSum = sumResult*sumResult;
            }
            int substract = sqrOfSum - sumOfsqr;
            Console.WriteLine(substract);
            Console.ReadKey();
        }
    }
}
