using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bDivisibleby10 = false;
            ulong currentNum = 0;
            while (true)
            {
                currentNum++;
                for (ulong i = 1; i <= 18; i++)
                {
                    if ((currentNum % i) == 0)
                    {
                        bDivisibleby10 = true;
                    }
                    else
                    {
                        bDivisibleby10 = false;
                        break;
                    }
                }
                if (bDivisibleby10==true)
                {
                    Console.WriteLine("Answer : " + currentNum);
                    Console.ReadKey();
                    break;

                }
            }
        }
    }
}
