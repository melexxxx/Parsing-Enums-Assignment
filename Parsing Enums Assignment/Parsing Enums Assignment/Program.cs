using System;

namespace Parsing_Enums_Assignment
{
    // Define an enumeration for the days of the week
    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            // Read the user input from the console
            string userInput = Console.ReadLine();

            try
            {
                // Attempt to parse the user input into the DaysOfWeek enum
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                // Output the parsed day to the console
                Console.WriteLine("You entered: " + currentDay);
            }
            catch (ArgumentException)
            {
                // If an error occurs during parsing, print this message
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keep the console open until a key is pressed
            Console.ReadLine();
        }
    }
}
