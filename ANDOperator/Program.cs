using System;

namespace ANDOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND - &&
            //true && true => true - username && password => welcome
            //true && false => false - username && password => access denied
            //false && true => false - username && password => access denied
            //false && false => false - username && password => access denied

            // username - admin , password - "1234"
            // dopolnit prelozenie, 3 popitki dlja vhoda v sistemu

            string username, password;
            Console.WriteLine("You have 3 Attempt to login");
            Console.WriteLine("");

            int count = 0;



           

            while (count != 3)
            {
                Console.WriteLine("Enter username:");
                username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                password = Console.ReadLine();


                if (username == "admin" && password == "1234")
                {
                    Console.WriteLine("Welcome!");
                    break;
                }

                else
                {
                    Console.WriteLine("Access Denied. Try again");
                    count++;
                    Console.WriteLine($"You have made {count} attemts");
                   if ( count == 3)
                    {
                        Console.WriteLine("No attempt left! Try again later!");
                    }
                }
                    Console.WriteLine("");
               
                }
                 
                 
                 Console.WriteLine("Have a nice day!");
            }
              

        }
    } 

