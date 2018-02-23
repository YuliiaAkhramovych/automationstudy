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
            var random = new Random();
            var list = new List<int>();


            for (int i = 0; i <= 100; i++)
            {
                list.Add(random.Next(100));

            }

            var sortedNumbers = list.OrderBy(n => n).ToList();
            Console.WriteLine($"Sorted numbers in your collection are: {string.Join(", ", sortedNumbers)}");


            if (list.Contains(50))
            {
                Console.WriteLine("There is number 50 in your collection");
            }
            else
            {
                Console.WriteLine("There is no number 50 in your collection");
            }

            Console.ReadLine();
        }
    }
}
