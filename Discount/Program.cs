using System;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentSum;
            Console.WriteLine("Enter your check summa!");
            currentSum = Convert.ToInt32(Console.ReadLine());

            if (currentSum == 10)
            {
                Console.WriteLine("You have 1 euro discount on your next purchase!");

            }
            else if (currentSum < 10)
            {
                Console.WriteLine("Buy from 10 euro and more and get s discount!");
            }
          
            else if (currentSum >= 20 & currentSum <= 50)
            {
                Console.WriteLine("You have 5 euro discount on your next purchase!");
            }
            else if (currentSum >= 50 & currentSum <= 100)
            {
                Console.WriteLine("You have 10 euro discount on your next purchase");
            }
            else
            {
                Console.WriteLine("You have 15 euro discount on your next purchase");
            }
                  Console.WriteLine("Have a nice day!");
        }
       
    }
}
