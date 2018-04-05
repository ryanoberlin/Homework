using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringsquish
{
    class Program
    {
        static void Main(string[] args)
        {
            Squish();
            SquishBetter();
        }
        private static void SquishBetter()
        {
            Stopwatch sw = new Stopwatch();
            StringBuilder test = new StringBuilder("aaabbbccccDDD");
            string output;
            int n = 1;
            int len = test.Length;
            char[] charArr = new char[test.Length];
            test.CopyTo(0, destination: charArr, destinationIndex: 0, count: test.Length);
            Console.WriteLine("Input String: {0}", test);
            Console.Write("Output string: ");

            sw.Start();
            for (int i = 0; i < test.Length -1; i++)
            {
                if (test[i] == test[i - 1])
                {
                    n++;
                }
                else
                {
                    output = test[i-1].ToString() + n.ToString();
                    Console.Write(output);
                    n = 1;
                }

            }

            sw.Stop();
            Console.WriteLine("");
            Console.WriteLine($"Elapsed Time in Milliseconds:{sw.Elapsed.TotalMilliseconds}");
        }

        private static void Squish()
        {
            Stopwatch sw = new Stopwatch();
            StringBuilder test = new StringBuilder("aaabbbccccDDD");
            int i = 0;
            string output;
            int len = test.Length;
            char[] charArr = new char[test.Length];
            test.CopyTo(0, destination: charArr, destinationIndex: 0, count: test.Length);
            char character;
            Console.WriteLine("Input String: {0}", test);
            Console.Write("Output string: ");

            sw.Start();
            while (i < len)
            {

                character = test[i];
                while (i < charArr.Length && charArr[i] == character)
                {
                       i++;
             
                }
            
                output = character.ToString() + i.ToString();
                Console.Write(output);
            }
            sw.Stop();
            Console.WriteLine("");
            Console.WriteLine($"Elapsed Time in Milliseconds:{sw.Elapsed.TotalMilliseconds}");

        }

    
    }
}