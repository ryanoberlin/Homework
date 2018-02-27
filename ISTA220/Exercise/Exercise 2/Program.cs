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
            string choice = Console.ReadLine();
            caseswitch = int.Parse(choice);



            switch (caseswitch)
            {
                case 1:
                    Integersum();  //add positive integers
                    break;
                case 2:
                    Tenscoreavg();
                    // AVG Ten scores
                    break;
                case 3:
                    Useravg(); //user pre determined # score
                    break;
                case 4:
                    UndecidedAvg(); // average undecided # of scores 
                    break;
                default:
                    Console.WriteLine("Please make a Selection of 1-4");
                    break;
            }

        }

        private int ReadInt(string a) //read intergers
        {
            Console.Write(a); //need to add bounds checks [1-100]
            string input1 = Console.ReadLine();
            return int.Parse(input1);
        }

        private void Integersum() // do function 1
        {
            int a = ReadInt("Please Input your first Number:");
            int b = ReadInt("Please Input your second number:");
            Console.WriteLine($"The Sum of your Number is: {a + b}");
        }


        private void Tenscoreavg() //function 2
        {
            int[] scores = new int[10];
            int sum = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = ReadInt($"Please input score number {i + 1}: "); // add one here instead so the first score is 1
                sum += scores[i]; //update scores 
            }
            int mean = sum / 10;
            Console.WriteLine($"The Total value of all scores is: {sum}");
            Console.WriteLine($"The Mean test score is: {mean}");
        }

        private void Useravg() //user defined number of tests average [function3]
        {
            int arraylength = ReadInt("Please input the total # of tests to average: "); //get # of tests from user
            int[] scores = new int[arraylength]; //create an array based on user input
            int sum = 0;

            for (int i = 0; i < scores.Length; i++) //take input until the users # is done 
            {
                scores[i] = ReadInt($"Please input score number {i + 1}: ");
                sum += scores[i];
            }
            int mean = sum / arraylength;
            Console.WriteLine($"The Total value of all scores is: {sum}");
            Console.WriteLine($"The Mean test score is: {mean}");
        }
        //Finish this tomorrow 
        
      //  private void UndecidedAvg()

    } 
}
