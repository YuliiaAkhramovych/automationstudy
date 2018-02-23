using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalProject
{
    class Human
    {
        public string Name { get; set; }

        public void WakeUp()
        {
            Console.WriteLine("7:30 - " + Name + " wakes up");
        }

        public void GoTo(string time, string where)
        {
            Console.WriteLine(time + Name + " goes to the " + where);
        }

        public void TakeShower(string time)
        {
            Console.WriteLine(time + Name + " takes a shower");
        }

        public Food Take(Food food, Fridge fridge)
        {
            Food result = fridge.Pull(food.Name);
            Console.WriteLine("8:00 - " + Name + " takes " + food.Name + " from " + fridge.Name);
            return result;
        }

        public Food Eat(Food food, Fridge fridge)
        {
            Food result = fridge.Pull(food.Name);
            Console.WriteLine("8:00 - " + Name + " drinks " + food.Name);
            return result;
        }

        public void Cover(Bed bed)
        {
            Console.WriteLine("8:30 - " + Name + " covers " + bed.Name);
        }

        public Clothes TakeWear(Clothes clothes, Cupboard myCupboard)
        {
            Clothes result = myCupboard.Pull(clothes.Name);
            Console.WriteLine("8:45 - " + Name + " takes " + clothes.Name + " from " + myCupboard.WhatCupboard);
            return result;
        }

        public Clothes Wear(Clothes clothesName1, Cupboard myCupboard)
        {
            Clothes result = myCupboard.Pull(clothesName1.Name);
            Console.WriteLine("8:50 - " + Name + " wears " + clothesName1.Name);
            return result;
        }

        public void Work(string time, string what)
        {
            Console.WriteLine(time + Name + " works with " + what + " now");
        }

        public void Return(string time, string where)
        {
            Console.WriteLine(time + Name + " returns to the " + where);
        }

        public void TakeDinner(string what, Cupboard kitchenCupboard)
        {
            Console.WriteLine("19:30 - " + Name + " takes " + what + " from " + kitchenCupboard.WhatCupboard);
        }

        public void Cook(string what)
        {
            Console.WriteLine("19:30 - " + Name + " cooks a " + what);
        }

        public void Eat1()
        {
            Console.WriteLine("20:00 - " + Name + " has a dinner");
        }

        public void Read(Books book)
        {
            Console.WriteLine("20:45 - " + Name + " reads " + book.whatBook);
        }
        public void GoSleep(string time)
        {
            Console.WriteLine(time + Name + " goes to sleep");
        }
    }
}
