using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalProject
{
    class Program
    {




        static void Main()
        {
            Options();


            int n = 0;
            bool isValid = int.TryParse(Console.ReadLine(), out n);
            if (isValid)
            {
                if (n == 1)
                {
                    Adding();
                }

                else if (n == 2)
                {
                    Substract();
                }
                else if (n == 3)
                {
                    Multiply();
                }
                else if (n == 4)
                {
                    Divide();
                }
                else if (n == 5)
                {
                    Exit();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("There is no such option.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Main();
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no such option.");
                Console.ForegroundColor = ConsoleColor.Green;
                Main();
            }
        }

        private static void Options()
        {
            Console.WriteLine("Please select an operation by number");
            Console.WriteLine(1 + " - Add");
            Console.WriteLine(2 + " - Substract");
            Console.WriteLine(3 + " - Multiply");
            Console.WriteLine(4 + " - Divide");
            Console.WriteLine(5 + " - Exit application");
        }

        private static void Adding()
        {
            Console.WriteLine("Please enter how many numbers you want to add");
            int quantity = GetQuantity();

            Console.WriteLine("Enter " + quantity + " numbers");

            double number = 0;
            double sum = 0;

            for (int i = 0; i < quantity; i++)
            {
                number = GetNumber();
                sum += number;
            }

            GiveResult(sum);
            Main();
        }

        private static void Substract()
        {

            Console.WriteLine("Please enter how many numbers you want to substract");
            int quantity = GetQuantity();

            Console.WriteLine("Enter " + quantity + " numbers");

            double substractResult = GetNumber();
            double number = 0;
            for (int i = 1; i < quantity; i++)
            {
                number = GetNumber();
                substractResult -= number;

            }

            GiveResult(substractResult);
            Main();

        }

        private static void Multiply()
        {
            Console.WriteLine("Please enter how many numbers you want to multiply");
            int quantity = GetQuantity();

            Console.WriteLine("Enter " + quantity + " numbers");

            double multiplyResult = 1;
            double number = 1;

            for (int i = 0; i < quantity; i++)
            {
                number = GetNumber();
                multiplyResult *= number;
            }

            GiveResult(multiplyResult);
            Main();

        }

        private static void Divide()
        {
            Console.WriteLine("Please enter how many numbers you want to divide");
            int quantity = GetQuantity();

            Console.WriteLine("Enter " + quantity + " numbers");

            double divideResult = GetNumber();
            double number = 1;

            for (int i = 1; i < quantity; i++)
            {
                number = GetNumber();
                divideResult /= number;
            }

            GiveResult(divideResult);
            Main();
        }

        private static void Exit()
        {
            Console.WriteLine("Thank you for using our application. Click Enter to exit");
            Console.ReadLine();

        }

        static int GetQuantity()
        {
            int quantity;
            bool validQuantity = int.TryParse(Console.ReadLine(), out quantity);

            if (validQuantity)
            {
                return quantity;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("It should be integer");
                Console.WriteLine("Enter how many numbers your operation will have");
                Console.ForegroundColor = ConsoleColor.Green;
                return GetQuantity();
            }
        }

        static double GetNumber()
        {
            double number;
            bool validNumber = double.TryParse(Console.ReadLine(), out number);

            if (validNumber)
            {
                return number;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your value is incorrect");
                Console.WriteLine("Enter a number");
                Console.ForegroundColor = ConsoleColor.Green;
                return GetNumber();
            }
        }

        static void GiveResult(double result)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The result is: " + result);
            Console.ForegroundColor = ConsoleColor.Green;

        }
    }
}
