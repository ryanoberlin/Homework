using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryptexercise
{
    class Program
    {
        //store attempts 
        static int attempts = 0;
        //store username and pword in a generic dictionary
        protected static Dictionary<string, string> loginInfo = new Dictionary<string, string>();

        static void Main(string[] args)
        {
       
                Handler();

            //check dictionary 
            Console.WriteLine("Users Added");
            foreach (KeyValuePair<string, string> kvp in loginInfo)
            {
                Console.WriteLine("UserName = {0}, SHA256 Hash = {1}", kvp.Key, kvp.Value);
            }
            //clean break 
            Console.WriteLine("Exiting....\nGoodBye.");
            return;
            //check dictionary 
            // loginInfo.ToList().ForEach(x =>  Console.WriteLine(x.Key));
        }

        private static void Handler()
        {
            string m = "\nPlease choose 1 thru 3:\n";
            string m1 = "1.) Create a new account.\n";
            string m2 = "2.) Login to an existing account.\n";
            string m3 = "3.) Exit the Application.\n";
            string m4 = "Please select an option: ";

            Console.Write($"{m} {m1} {m2} {m3} {m4}");

            string choice = Console.ReadLine();

            if (!int.TryParse(choice, out int caseswitch))
            {
                Console.WriteLine("Invalid Choice.");
                Handler();
            }

            switch (caseswitch)
            {
                case 1:
                    CreateUser();
                    break;
                case 2:
                    Login();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Please make a Selection of 1-3.");
                    Handler();
                    break;

            }
        }

        private static string GetPass(string v)
        {
            Console.Write(v);
            string pass = Console.ReadLine();
            Console.Write("Please confirm your password: ");
            string pass2 = Console.ReadLine();

            if (pass == pass2)
            {
                string hashpass = Encrypt(pass);
                Console.Write("Success! Account Created.");
                return hashpass;
            }
            else
            {
                Console.WriteLine("Passwords do not match. Try Again.");
                return GetPass(v);
            }
        }

        private static string Encrypt(string pass)
        {
            StringBuilder Sb = new StringBuilder();
            byte[] hashin = Encoding.UTF8.GetBytes(pass);

            HashAlgorithm pass256 = SHA256.Create();

            byte[] hashout = pass256.ComputeHash(hashin);

            foreach (Byte b in hashout)
                Sb.Append(b.ToString("x2"));

            return Sb.ToString();

        }

        private static bool ImplyDecrypt(string pass)
        {
            string passcheck = Encrypt(pass);

            do
            {
                attempts++;

                if (attempts == 2)
                {
                    Console.WriteLine("Maximum number of attempts exceeded. Try Again Later.");
                    return false;
                }

                if (loginInfo.ContainsValue(passcheck))
                {
                    Console.WriteLine("Password Authenticated. Welcome.");
                    //reset attempts for future
                    attempts = 0;
                    return true;
                }

                if (!loginInfo.ContainsValue(passcheck) && attempts < 2)
                {
                    ImplyDecrypt(GetString("Password Incorrect. Please try again: "));
                }
            } while (attempts < 3);
           
            return false;
        }
        private static void Login()
        {
            string user = GetString("Logging In...\nPlease input a Username: ");

            if (loginInfo.ContainsKey(user))
            {
                Console.WriteLine("Found User: {0}", user);
                ImplyDecrypt(GetString("Please input your password:"));
            }
            else
            {
                Console.WriteLine("Username not found, please create an account first.");
                Handler();
            }

        }

        private static string GetString(string v)
        {
            Console.Write(v);
            string value = Console.ReadLine();
            return value;
        }

        private static void CreateUser()
        {
            loginInfo.Add(GetString("Creating new user...\nPlease input your username: "), GetPass("Please input your password: "));
            Handler();
        }
    }
}
