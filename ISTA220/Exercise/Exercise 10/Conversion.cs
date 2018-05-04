using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversion Util = new Conversion();
            string binarytest = "1100011";
            string octaltest = "42";
            /* Console.WriteLine("Binary input is 1100011");
             Console.WriteLine("Octal is: " + Util.Bin2Oct(binarytest));
             Console.WriteLine("Decimal is: " + Util.Bin2Dec(binarytest));
             Console.WriteLine($"Octal to Binary. Input: {octaltest} Output: " + Util.Oct2Bin(octaltest));*/
            Console.WriteLine($"Octal to Binary. Input: {octaltest} Output: " + Util.Oct2BinAlt(octaltest)); 

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

            while (number > 0)
            {
                rem = number % 10;
                dec = dec + rem * usul;
                number = number / 10;
                usul = usul * 2;
            }
            return dec.ToString();
        }
        //something isn't quite right....
        public string Oct2Bin(string oct)
        {
            StringBuilder Sb = new StringBuilder();
            string output = "";

            foreach (char i in oct) 
            {
                switch (i)
                {
                    case '0':
                        Sb.Append("000");
                        break;
                    case '1':
                        Sb.Append("001");
                        break;
                    case '2':
                        Sb.Append("010");
                        break;
                    case '3':
                        Sb.Append("011");
                        break;
                    case '4':
                        Sb.Append("100");
                        break;
                    case '5':
                        Sb.Append("101");
                        break;
                    case '6':
                        Sb.Append("110");
                        break;
                    case '7':
                        Sb.Append("111");
                        break;
                    default:
                        break;
                }
            }

            output = Sb.ToString();
            if (output.Length  > 8)
            {
               output = output.Remove(0, 2);
                
            }
            return output;
        }

        public string Oct2BinAlt(string input)
        {
            StringBuilder Sb = new StringBuilder();
            int oct = int.Parse(input);
            int half = oct / 2;
            string pass = half.ToString();
            string output;

            foreach(char i in input)
            {
                Sb.Append((oct > 1 ? Oct2Bin(pass) : "") + oct % 2);
            }

            Sb.Remove(0, oct % 2);
            
            output = Sb.ToString();
            return output;
        }
    }
}