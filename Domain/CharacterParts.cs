namespace ZombieSurvivalGame.Domain
{
    public class CharacterParts
    {

        // sundan ang role type
        public readonly static string[] RoleType =
        {
            "Human", "Zombie"
        };

        public readonly static int[] Ages = { 15, 26, 41, 60 };

        public readonly static string[] EyeTypes =
        {
            "Almond",
            "Round",
            "Hooded",
            "Monolid"
        };

        public readonly static string[] NoseTypes =
        {
            "Small",
            "Normal",
            "Flat",
            "Broken"
        };

        public readonly static string[] MouthTypes =
        {
            "Small",
            "Normal",
            "Wide",
            "Frown",
            "Smile"
        };


        // hairstyle
        public readonly static string[] HairStyleHuman =
        {
            "Straight",
            "Curly",
            "Messy",
            "Short",
            "Long"
        };

        public readonly static string[] HairStyleZombie =
        {
            "Thinning",
            "Patchy"
        };


        // body type
        public readonly static string[] BodyTypeHuman =
        {
            "Skinny",
            "Slim",
            "Normal",
            "Burly",
            "Bulk"
        };
        public readonly static string[] BodyTypeZombie =
        {

           "Decayed",
            "Bloated",
            "Hunched"
        };

        // skin color
        public readonly static string[] SkinColorHuman =
          {
            "Dark",
            "Light",
            "Brown",
            "Pale",
            "Tan"
        };

        public readonly static string[] SkinColorZombie =
        {
            "Gray",
            "Green",
            "Decayed",
            "Rotting"
        };


        public readonly static string[] PostureTypeHuman =
        {
            "Upright",
            "Slouched",
            "LeaningForward",
            "Hunched",
            "Defensive",
        };

        public readonly static string[] PostureTypeZombie =
        {
            "Slouched",
            "Leaning Forward",
            "Hunched",
            "Casual",
            "Alert",
        };

        public readonly static string[] ShirtTypeHuman =
        {
            "TShirt",
            "Hoodie",
            "LongSleeve",
            "Ripped",
            "Military",
        };

        public readonly static string[] ShirtTypeZombie =
        {
            "Torn",
            "Dirty",
            "BloodStained",
        };

        public readonly static string[] PantsTypeHuman =
        {
            "Jeans",
            "Cargo",
            "Shorts",
            "Tactical",
            "Ripped"
        };
        public readonly static string[] PantsTypeZombie =
        {
            "Dirty",
            "Torn",
            "Loose",
            "Decayed"
        };

        public readonly static string[] WeaponTypeHuman =
        {
            "Machete",
            "Axe",
            "Shotgun",
            "Handgun",
            "BaseballBat"
        };
        public readonly static string[] WeaponTypeZombie =
        {
        "Bite",
        "Claws"
        };

        public enum PantsType
        {
            Jeans,
            Cargo,
            Shorts,
            Tactical,
            Ripped,

            // Zombie
            Dirty,
            Torn,
            Loose,
            Decayed
        }

        public enum WeaponType
        {
            Machete,
            Axe,
            Shotgun,
            Handgun,
            BaseballBat,

            // Zombie
            Bite,
            Claws
        }
    }
}
