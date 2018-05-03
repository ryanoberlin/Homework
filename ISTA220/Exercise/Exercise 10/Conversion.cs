using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversion Util = new Conversion();
            string teststring = "101010";
            Console.WriteLine("Input is 101010");
            Console.WriteLine("Octal is: " + Util.Bin2Oct(teststring));
            Console.WriteLine("Decimal is: " + Util.Bin2Dec(teststring));
            Console.WriteLine("Octal to Binary is:" + Util.Oct2Bin(7));
        }
    }

    class Conversion
    {

        public string Bin2Oct(string bin)
        {
            int adjusted = bin.Length % 3;
            string binary = new string('0', 3 - adjusted) + bin;
            int n = binary.Length / 3;
            char[] bindigits = binary.ToCharArray();
            char[] octdigits = new char[n];

            for (int i = 0; i < n; i++)
            {
                int digits = bindigits.Skip(3 * i).Take(3).Aggregate(0, (a, b) => b - '0' + 2 * a);
                octdigits[i] = (char)(digits + '0');
            }
            return new string(octdigits);
        }

        public string Bin2Dec(string bin)
        {
            int dec = 0;
            int usul = 1;
            int rem;
            int number = int.Parse(bin);

            while(number >0)
            {
                rem = number % 10;
                dec = dec + rem * usul;
                number = number / 10;
                usul = usul * 2;
            }
            return dec.ToString();
        }
        //something isn't quite right....
        public string Oct2Bin(int oct)
        {
            return (oct > 1 ? Oct2Bin(oct / 2) : "") + oct % 2;
        }
    }
}
