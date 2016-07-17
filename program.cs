using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace _33333challenge
{
    static class Program
    {
        static void Main(string[] args)
        {
            const int targetNumber = 33333;

            const int maxNumber = 98765;
            const int minNumber = 12345;

            const int maxNumber2 = 9876;
            const int minNumber2 = 1234;

            int tempNumber = minNumber;
            int tempNumber2 = minNumber2;            

            for (; tempNumber <= maxNumber; tempNumber++)
            {
                for(;tempNumber2 <= maxNumber2; tempNumber2++)
                {
                    if ((tempNumber - tempNumber2) == targetNumber)
                    {
                        List<int> tempNumberDigits = breakIntoDigits(tempNumber).Concat(breakIntoDigits(tempNumber2)).ToList();
                        if (!tempNumberDigits.GroupBy(n => n).Any(c => c.Count() > 1))
                        {
                            Console.Write(tempNumber.ToString() + " - " + tempNumber2.ToString() + " = " + targetNumber.ToString() );
                            Console.WriteLine("\n=============");
                        }
                    }
                 }
                tempNumber2 = minNumber2; 
             }
            Console.ReadKey();
        }

        static List<int> breakIntoDigits(int number)
        {
            List<int> digits = new List<int>();
            while(number > 0)
            {
                digits.Add(number % 10);
                number = number / 10;
            }
            return digits;
        }

    }
}
