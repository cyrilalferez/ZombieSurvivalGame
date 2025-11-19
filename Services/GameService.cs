using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ZombieSurvivalGame.Domain;
using ZombieSurvivalGame.Model;
using ZombieSurvivalGame.Utils;
using static ZombieSurvivalGame.Domain.CharacterParts;

namespace ZombieSurvivalGame.Services
{
    public class GameService
    {
        public void Start()
        {
            GetCharacterFeatures();

            // Create Character

            // Save Character
        }

        public void GetCharacterFeatures()
        {
            ConsoleHelper consoleHelper = new ConsoleHelper(null);
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            ConsoleHelper.CharacterRoleOptions();
            string role = CharacterParts.RoleType[Validator.GetValidNumber("Choose your role: ", 1, 2) - 1];

            ConsoleHelper.AgeOptions();
            int ageChoice = Validator.GetValidNumber("Enter your age: ", 1, 4);

            consoleHelper.EyeTypeOptions();
            string eyeType = CharacterParts.EyeTypes[Validator.GetValidNumber("Choose your eye type: ", 1, CharacterParts.EyeTypes.Length) - 1];

            consoleHelper.NoseTypeOptions();
            string noseType = CharacterParts.NoseTypes[Validator.GetValidNumber("Choose your nose type: ", 1, CharacterParts.NoseTypes.Length) - 1];

            consoleHelper.MouthTypeOptions();
            string mouthType = CharacterParts.MouthTypes[Validator.GetValidNumber("Choose your nose type: ", 1, CharacterParts.MouthTypes.Length) - 1];

            while(true)
            {
                bool customizeHair = Validator.GetValidBoolean("Do you want to customize hair style? (y/n): ");

                // if yes: prompt hair style options based on role, else: break;

                // else (choice ng user is n or no) break;

                break;
            }

            string bodyType;
            if (role.Equals("Human"))
            {
                bodyType = CharacterParts.BodyTypeHuman[Validator.GetValidNumber("Choose your nose type: ", 1, CharacterParts.BodyTypeHuman.Length) - 1];
            } else {
                bodyType = CharacterParts.BodyTypeZombie[Validator.GetValidNumber("Choose your nose type: ", 1, CharacterParts.BodyTypeZombie.Length) - 1];
            }




            Console.WriteLine("Success");

            Character character = new Character(
            role,
            "Default",
            1,
            eyeType,
            noseType,
            mouthType,

            // complete this
            false,
            null,
            bodyType,
            SkinColor.Light,
            PostureType.Upright,
            ShirtType.TShirt,
            PantsType.Jeans,
            WeaponType.Axe
            );

            if (role.Equals("Human"))
            {
                Console.WriteLine("Human type");
            }
            else
            {
                Console.WriteLine("Not human.");
            }
        }
    }
}
