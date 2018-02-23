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
                Console.WriteLine(numbers[i]);

            }

            var sortedNumbers = numbers.OrderByDescending(number => number).Take(3).ToList();

            Console.WriteLine($"The largest three numbers are: {string.Join(", ", sortedNumbers)}");
            Console.ReadLine();
        }
    }
}
