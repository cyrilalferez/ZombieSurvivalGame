using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSurvivalGame.Utils
{
    public class Validator
    {
        public static int GetValidNumber(string prompt, int min, int max)
        {
            int choice = -1;

            while(true)
            {
                Console.Write(prompt);

                string input = Console.ReadLine() ?? "";

                if(string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input cannot be empty. Please enter a valid age.");
                    continue;
                }

                if(int.TryParse(input, out choice))
                {
                    if(choice >= min && choice <= max)
                    {
                        return choice;
                    }
                    else
                    {
                        Console.WriteLine($"Choice must be in range of {min} and {max}. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value for age.");
                }
            }
        }

        public static bool GetValidBoolean(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = (Console.ReadLine() ?? "").Trim().ToLower();

                if (input == "y" || input == "yes" || input == "true")
                {
                    return true;
                }
                else if (input == "n" || input == "no" || input == "false")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no' (y/n).");
                }
            }
        }
    }
}
