using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlnaFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {           
            bool isValid = true;

            do
            {
                try
                {
                    Console.WriteLine("Please enter Fibonacci Sequence n number");
                    int sequenceN = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{sequenceN}{GetSuffix(sequenceN)} number of Fibonacci Sequence is {Fib(sequenceN)}");
                    //isValid = false;
                }                
                catch (Exception)
                {
                    Console.WriteLine("Fibonacci Sequence n must be numeric int type number!");
                }
            } while (isValid);
        }

        private static long Fib(int sequenceN)
        {
            //if (sequenceN < 0) throw new ArgumentOutOfRangeException();
            long z = default(long);
            long x = default(long);
            long y = default(long);
            if (sequenceN == 0)
                y = 0;
            else if (sequenceN < 0)
            {
                sequenceN = -1 * sequenceN;
                y = -1;
            }
            else
                y = 1;

            for (int i = 1; i < sequenceN; i++)
            {
                z = y;
                y = x + z;
                x = z;
                //Console.Write(y + " ");
            }

            return y;
        }

        private static string GetSuffix(int sequenceN)
        {
            string suffix;
            switch (Math.Abs(sequenceN))
            {

                case (1):
                    suffix = "st";
                    break;
                case (2):
                    suffix = "nd";
                    break;
                case (3):
                    suffix = "rd";
                    break;
                default:
                    suffix = "th";
                    break;
            }
            return suffix;
        }
    }
}