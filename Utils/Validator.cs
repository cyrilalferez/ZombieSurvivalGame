namespace ZombieSurvivalGame.Utils
{
    public static class Validator
    {
        public static string GetValidInput(string prompt)
        {
            string input = "";
            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine() ?? "";
                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                }
            }
        }
        public static int GetValidNumber(string prompt, int min, int max)
        {
            int choice = -1;

            while (true)
            {
                string input = GetValidInput(prompt);

                if (int.TryParse(input, out choice))
                {
                    if (choice >= min && choice <= max)
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
                string input = (GetValidInput(prompt).Trim().ToLower());

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
