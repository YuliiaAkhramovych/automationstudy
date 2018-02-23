using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalProject
{
    class Fridge
    {
        public string hello;

        public string Name { get; set; }
        public int Year { get; set; }

        public Fridge(string name, int whenibit)
        {
            Name = name;
            Year = whenibit;
        }

        public Food Pull(string foodName)
        {
            switch (foodName)
            {
                case "apple":
                    return new Food(foodName);

                case "milk":
                    return new Food(foodName);

                case "water":
                    return new Food(foodName);

                default:
                    throw new Exception("Kate is not eating today");

            }
        }
    }
}
