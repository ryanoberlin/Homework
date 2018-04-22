using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
//            Console.WriteLine(Util.Sum(null));
           // Console.WriteLine(Util.Sum());
            Console.WriteLine(Util.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1));
            Console.WriteLine(Util.Sum(1));
            Console.WriteLine(Util.Sum(1,2));
            Console.WriteLine(Util.Sum(1,2,3));
            Console.WriteLine(Util.Sum(1,2,3,4));
            Console.WriteLine(Util.Sum(1,2,3,4,5));


        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
