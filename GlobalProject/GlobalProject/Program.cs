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
            Human kate = new Human();
            kate.Name = "Kate";
            Fridge samsung = new Fridge("Samsung", 1990);
            Fridge indesit = new Fridge("Indesit", 2000);
            Food food = new Food("milk");

            Bed ikeaBed = new Bed("Ikea");

            Cupboard myCupboard = new Cupboard();
            myCupboard.WhatCupboard = "clothes cupboard";
            Clothes todaysWear1 = new Clothes("dress");
            Cupboard kitchenCupboard = new Cupboard();
            kitchenCupboard.WhatCupboard = "kitchen cupboard";
            Books nightBook = new Books();
            nightBook.whatBook = "\"Learn C# in one day and learn it well\"";








            kate.WakeUp();
            kate.GoTo("7:40 - ", "bathroom");
            kate.TakeShower("7:40 - ");


            kate.GoTo("8:00 - ", "kitchen");
            try
            {
                kate.Take(food, samsung);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                kate.Eat(food, samsung);
            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
            }

            kate.Cover(ikeaBed);


            try
            {
                kate.Wear(todaysWear1, myCupboard);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            kate.GoTo("9:00 - ", "office");
            kate.Work("9:30 - ", "documents");
            kate.GoTo("13:00 - ", "lanch");
            kate.Return("14:00 - ", "office");
            kate.Work("14:00 - ", "bookkeeping");
            kate.Return("19:00 - ", "home");

            kate.GoTo("19:30 - ", "kitchen");
            kate.TakeDinner("spaghetti", kitchenCupboard);
            kate.Cook("dinner");
            kate.Eat1();
            kate.Read(nightBook);
            kate.GoTo("22:00 - ", "bathroom");
            kate.TakeShower("22:00 - ");
            kate.GoSleep("22:30 - ");


            Console.ReadLine();

        }
    }
}

