using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Handler();
        }

        private void Handler() //tell people whats up
        {
            string m = "Please select 1 thru 4:\n";
            string m1 = "1.) Sum of two positive integers[0-100].\n";
            string m2 = "2.) Average of ten Score\n";
            string m3 = "3.) Average of user defined number of scores.\n";
            string m4 = "4.) Average number of indeterminate scores.\n";
            int caseswitch;

            Console.WriteLine($"{m} {m1} {m2} {m3} {m4}");

            Console.WriteLine("Input Selection:");
            string choice =  Console.ReadLine();
            caseswitch = int.Parse(choice);

            

            switch (caseswitch)
            {
                case 1:
                    Integersum();  //add positive integers
                    break;
                case 2:
                 //   tenscoreavg(); // AVG Ten scores
                    break;
                case 3:
                   // predefinedaverage(); //user pre determined # score
                    break;
                case 4:
                   // undecidedavg(); // average undecided # of scores 
                    break;
                default:
                    Console.WriteLine("Please make a Selection of 1-4");
                    break;
            }
 
        }

        private int ReadInt(string a)
        {
            Console.Write(a);
            string input1 = Console.ReadLine();
            return int.Parse(input1);           
        }
        
        private void Integersum()
        {
            int a = ReadInt("Please Input your first Number:");
            int b = ReadInt("Please Input your second number:");
            
            Console.WriteLine($"The Sum of your Number is: {a+b}" );
        }
    }
}
