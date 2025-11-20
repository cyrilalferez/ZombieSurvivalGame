using ZombieSurvivalGame.Data;
using ZombieSurvivalGame.Model;
using ZombieSurvivalGame.Utils;

namespace ZombieSurvivalGame.Services
{
    public class GameService
    {
        private CharacterService characterService;
        private CharacterRepository characterRepository;
        private Character character;
        private ConsoleHelper consoleHelper;

        public GameService()
        {
            characterService = new CharacterService();
            characterRepository = new CharacterRepository();
            consoleHelper = new ConsoleHelper();
        }

        public void Start()
        {
            bool start = true;
            while (start)
            {
                // INTRO
                int menuChoice = GetMenuChoice("Select an option: ", 0, 3);
                switch (menuChoice)
                {
                    case 0:
                        // Exit
                        start = false;
                        break;
                    case 1:
                        // New game logic here
                        // Create character
                        character = characterService.GetCharacterFeatures();

                        // Save Character to DB
                        characterRepository.SaveCharacter(character);

                        character.DisplayCharacterInfo();
                        return;
                    case 2:
                        Console.WriteLine("Campaign Mode selected.");
                        // Campaign mode logic here
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HOLD 'SPACE' TO SPEED UP");
                        Console.ResetColor();

                        ConsoleHelper.TypeEffect("Suddenly, a strange virus infects people in the city, transforming them into zombies, fast, aggressive, and mutated, as though a nightmare manifested itself in reality. You are a messenger that is accustomed to live in a hurry and is familiar with all shortcuts, tunnels, and shadows.");
                        ConsoleHelper.TypeEffect("As communication towers are collapsing one after another, you have to provide a critical antiviral sample before the military will decide to firebomb the whole city to put the outbreak in check.\r\n");
                        ConsoleHelper.TypeEffect("Squeezing through deserted streets, broken houses and underground tunnels, you are not only avoiding various forms of infection, you are also dealing with survivors who are now losing hope.");
                        ConsoleHelper.TypeEffect("Some of them come with you, and each has his talents and tragic histories, and in addition to all those, fears and desperation which are going to divide your camp.\r\n");
                        ConsoleHelper.TypeEffect("As you get further in you get more tragedies: teammates you have to leave behind to allow others to survive, rescue missions that go terribly astray, and tough decisions that haunt your conscience.");
                        ConsoleHelper.TypeEffect("With all the sacrifice, weariness and uncertainty, you start discovering the real cause of the outbreak- and the staggering fact that you were the very one the virus was targeting at the dawn of time.\r\n");
                        break;
                    case 3:
                        ConsoleHelper.TypeEffect("Credits selected.");
                        // Display credits logic here
                        return;
                }
            }
            ConsoleHelper.TypeEffect("Thanks for using this program!");

        }

        private int GetMenuChoice(string prompt, int min, int max)
        {
            consoleHelper.MenuOptions();
            return Validator.GetValidNumber(prompt, min, max);
        }
    }
}

