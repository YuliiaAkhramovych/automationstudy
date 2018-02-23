using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var x = random.Next(100);
            var y = random.Next(0);

            Console.WriteLine("Hi there! Try to guess my number");
            var i = 0;

            do
            {


                bool isValid = int.TryParse(Console.ReadLine(), out y);
                if (isValid)
                {

                    i++;
                    if (x < y && x != y)
                    {
                        ShowResult("bigger");
                        continue;
                    }

                    if (x > y && x != y)
                    {
                        ShowResult("smaller");
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("Enter a number");
                }

            } while (x != y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Congratulations! Your number is correct");
            Console.WriteLine($"You've made {i} attempt(s)");
            Console.ReadLine();

        }
        static void ShowResult(string result)
        {
            Console.WriteLine("Wrong value");
            //Console.WriteLine("Your value is " + result + " than mine. Try again");
            Console.WriteLine($"Your value is {result} than mine. Try again");
        }
    }
}
