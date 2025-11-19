using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ZombieSurvivalGame.Domain;
using ZombieSurvivalGame.Model;

namespace ZombieSurvivalGame.Utils
{
    public class ConsoleHelper
    {
        public Character character;

        public ConsoleHelper(Character character)
        {
            this.character = character;
        }

        public static void AgeOptions()
        {
            for (int i = 0; i < CharacterParts.Ages.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.Ages[i]}");
            }
        }

        public static void CharacterRoleOptions()
        {
            for (int i = 0; i < CharacterParts.RoleType.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.RoleType[i]}");
            }
        }

        public void HairStyleOptions()
        {
            if (character.Role.Equals("Human"))
            {
                for (int i = 0; i < CharacterParts.HairStyleHuman.Length; i++)
                {
                    // TODO: Output options for human hair styles
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.HairStyleZombie.Length; i++)
                {
                    // TODO: Output options for zombie hair styles
                }
            }
        }

        public void EyeTypeOptions()
        {
            for (int i = 0; i < CharacterParts.EyeTypes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.EyeTypes[i]}");
            }
        }

        public void NoseTypeOptions()
        {
            for (int i = 0; i < CharacterParts.NoseTypes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.NoseTypes[i]}");
            }
        }

        public void MouthTypeOptions()
        {
            for (int i = 0; i < CharacterParts.MouthTypes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.MouthTypes[i]}");
            }
        }

        // Has hair part: Y/N
        public void HasHairOptions()
        {
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
        }

        public void BodyTypeOptions()
        {
            if (character.Role.Equals("Human"))
            {
                for (int i = 0; i < CharacterParts.BodyTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.BodyTypeHuman[i]}");
                    // TODO: Output options for human hair styles
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.BodyTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.BodyTypeZombie[i]}");
                    // TODO: Output options for zombie hair styles
                }
            }
        }
    }
}

