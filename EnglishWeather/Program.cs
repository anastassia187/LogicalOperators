using System;

namespace EnglishWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            //Temp < 0 - Freezing cold
            //Temp 0-10 -Very cold
            //Temp 10 - 20 - Cold
            //Temp 20 - 30 - Warm
            //Temp 30-35 - Hot
            // Temp >= 35 - Boiling hot
            // prilozenie pozvoljaet polzovatelju vvesti tekuwuju temperaturu vozduha
            // prilozenije otvecaet, kak nazivaetsja temperatura v dannom diapazone predlozeniem na angliiskom
            int currentTemp;
            Console.WriteLine("Enter the temperature:");
            currentTemp = Convert.ToInt32(Console.ReadLine());

            if(currentTemp < 0)
            {
                Console.WriteLine("Freezing cold");
            }
            else if (currentTemp >= 0 && currentTemp <= 10)
            {
                Console.WriteLine("Very cold");
            }
            else if (currentTemp > 10 && currentTemp <= 20)
            {
                Console.WriteLine("Cold");
            }
            else if ( currentTemp >= 20 && currentTemp <= 30)
            {
                Console.WriteLine("Warm");
            }
            else if (currentTemp >= 30 && currentTemp <= 35)
            {
                Console.WriteLine("Hot");
            }
            else
            {
               Console .WriteLine("Boiling hot");
            }

            Console.WriteLine("Have a nice day!");  
            
        }
    }
}
