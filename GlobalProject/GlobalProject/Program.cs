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
            var listLength = random.Next(100);

            List<int> numbers = new List<int>();
            for (int i = 0; i < listLength; i++)
            {
                numbers.Add(random.Next(100));
            }

            Console.WriteLine("The sum of values is: " + numbers.Sum());
            Console.WriteLine("Min value is: " + numbers.Min());
            Console.WriteLine("Max value is: " + numbers.Max());
            Console.WriteLine("The avarage of values is: " + Math.Round(numbers.Average(), 1));

            Console.ReadLine();
        }
    }
}
