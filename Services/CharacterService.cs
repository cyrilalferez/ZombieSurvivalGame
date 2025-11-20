using ZombieSurvivalGame.Domain;
using ZombieSurvivalGame.Model;
using ZombieSurvivalGame.Utils;

namespace ZombieSurvivalGame.Services
{
    internal class CharacterService
    {
        public Character GetCharacterFeatures()
        {
            ConsoleHelper consoleHelper = new ConsoleHelper();
            Console.Clear();
            Console.WriteLine("========== CHARACTER CREATION ==========");

            // username
            string username = Validator.GetValidInput("Enter username: ");

            // role
            ConsoleHelper.CharacterRoleOptions();
            string role = CharacterParts.RoleType[Validator.GetValidNumber("Choose your role: ", 1, 2) - 1];

            // age
            ConsoleHelper.AgeOptions();
            int ageChoice = Validator.GetValidNumber("Enter your age: ", 1, 4);
            int age = CharacterParts.Ages[ageChoice - 1];

            // eye type
            consoleHelper.EyeTypeOptions();
            string eyeType = CharacterParts.EyeTypes[Validator.GetValidNumber("Choose your eye type: ", 1, CharacterParts.EyeTypes.Length) - 1];

            // nose type
            consoleHelper.NoseTypeOptions();
            string noseType = CharacterParts.NoseTypes[Validator.GetValidNumber("Choose your nose type: ", 1, CharacterParts.NoseTypes.Length) - 1];

            // mouse type
            consoleHelper.MouthTypeOptions();
            string mouthType = CharacterParts.MouthTypes[Validator.GetValidNumber("Choose your mouth type: ", 1, CharacterParts.MouthTypes.Length) - 1];

            // has hair
            bool hasHair = Validator.GetValidBoolean("Do you have hair? (y/n): ");
            string hairStyle = "";

            if (hasHair)
            {
                consoleHelper.HairStyleOptions(role);

                if (role.Equals("Human"))
                {
                    hairStyle = CharacterParts.HairStyleHuman[Validator.GetValidNumber("Choose your hairstyle: ", 1, CharacterParts.HairStyleHuman.Length) - 1];
                }
                else
                {
                    hairStyle = CharacterParts.HairStyleZombie[Validator.GetValidNumber("Choose your hairstyle: ", 1, CharacterParts.HairStyleZombie.Length) - 1];
                }
            }

            // body type
            consoleHelper.BodyTypeOptions(role);
            string bodyType = "";
            if (role.Equals("Human"))
            {
                bodyType = CharacterParts.BodyTypeHuman[Validator.GetValidNumber("Choose your body type: ", 1, CharacterParts.BodyTypeHuman.Length) - 1];
            }
            else
            {
                bodyType = CharacterParts.BodyTypeZombie[Validator.GetValidNumber("Choose your body type: ", 1, CharacterParts.BodyTypeZombie.Length) - 1];
            }

            //skin color 
            consoleHelper.SkinColorOptions(role);
            string skinColor = "";
            if (role.Equals("Human"))
            {
                skinColor = CharacterParts.SkinColorHuman[Validator.GetValidNumber("Choose your skin color: ", 1, CharacterParts.SkinColorHuman.Length) - 1];
            }
            else
            {
                skinColor = CharacterParts.SkinColorZombie[Validator.GetValidNumber("Choose your skin color: ", 1, CharacterParts.SkinColorZombie.Length) - 1];
            }

            // posture
            consoleHelper.PostureOptions(role);
            string posture = "";
            if (role.Equals("Human"))
            {
                posture = CharacterParts.PostureTypeHuman[Validator.GetValidNumber("Choose your Posture Type: ", 1, CharacterParts.PostureTypeHuman.Length) - 1];
            }
            else
            {
                posture = CharacterParts.PostureTypeZombie[Validator.GetValidNumber("Choose your Posture Type: ", 1, CharacterParts.PostureTypeZombie.Length) - 1];
            }

            // shirt type
            consoleHelper.ShirtTypeOptions(role);
            string shirt = "";
            if (role.Equals("Human"))
            {
                shirt = CharacterParts.ShirtTypeHuman[Validator.GetValidNumber("Choose your Shirt Type: ", 1, CharacterParts.ShirtTypeHuman.Length) - 1];
            }
            else
            {
                shirt = CharacterParts.ShirtTypeZombie[Validator.GetValidNumber("Choose your Shirt Type: ", 1, CharacterParts.ShirtTypeZombie.Length) - 1];
            }

            // pants type
            consoleHelper.PantsTypeOptions(role);
            string pantsType = "";
            if (role.Equals("Human"))
            {
                pantsType = CharacterParts.PantsTypeHuman[
                    Validator.GetValidNumber("Choose your pants type: ", 1, CharacterParts.PantsTypeHuman.Length) - 1];
            }
            else
            {
                pantsType = CharacterParts.PantsTypeZombie[
                    Validator.GetValidNumber("Choose your pants type: ", 1, CharacterParts.PantsTypeZombie.Length) - 1];
            }

            // weapon type
            consoleHelper.WeaponTypeOptions(role);
            string weaponType = "";
            if (role.Equals("Human"))
            {
                weaponType = CharacterParts.WeaponTypeHuman[
                    Validator.GetValidNumber("Choose your weapon type: ", 1, CharacterParts.WeaponTypeHuman.Length) - 1];
            }
            else
            {
                weaponType = CharacterParts.WeaponTypeZombie[
                    Validator.GetValidNumber("Choose your weapon type: ", 1, CharacterParts.WeaponTypeZombie.Length) - 1];
            }

            // create character object
            return new Character(
                    role,
                    name: username,
                    age,
                    eye: eyeType,
                    nose: noseType,
                    mouth: mouthType,
                    hasHair, hairStyle,
                    body: bodyType,
                    skin: skinColor,
                    posture,
                    shirt,
                    pants: pantsType,
                    weapon: weaponType
                );
        }
    }
}
