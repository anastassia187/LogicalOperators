using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //OR -|| - ili
            //true || false => true
            //true || true => true
            // false || true => true
            // false || false => false
            // username - admin , password - "1234"
            // dopolnit prelozenie, 3 popitki dlja vhoda v sistemu

            string username, password;
            Console.WriteLine("You have 3 Attempt to login");
            int count = 0;


            while (count != 3)
            {
                Console.WriteLine("Enter username:");
                username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                password = Console.ReadLine();


                if (username == "admin" || password == "1234")
                {
                    Console.WriteLine("Welcome!");
                   
                    break;




                }
                else
                {

                    if (username != "admin" || password != "1234")
                    {
                        Console.WriteLine("Access denied.");
                        Console.WriteLine($"You have made {count + 1} attempts");
                        count++;

                    }

                    if(count== 3)
                    {
                        Console.WriteLine("No attempt left! Try again later!");
                    }
                }
            }
        }
    }
}
