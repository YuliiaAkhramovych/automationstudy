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

            char[] symbols = new Char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '“', '‘', '/', '!', '?' };

            var shortWords = Console.ReadLine()
                .Split(symbols)
                .Where(w => w != string.Empty)
                .Where(w => w.Length < 5)
                .OrderBy(word => word)
                .Select(a => a.ToLower()).Distinct();

            Console.WriteLine(string.Join(", ", shortWords));

            Console.ReadLine();

        }
    }
}
