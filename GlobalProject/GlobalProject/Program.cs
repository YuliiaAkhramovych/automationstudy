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
            var arrayLength = random.Next(100);
            var array = new int[arrayLength];


            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(0, 500);
            }

            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine("Even: " + array[i]);
                }

                else
                {
                    Console.WriteLine("Odd: " + array[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
