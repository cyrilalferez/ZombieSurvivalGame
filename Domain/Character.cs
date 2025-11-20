namespace ZombieSurvivalGame.Model
{
    public class Character
    {
        // Constructor
        public Character(
            string role,
            string name,
            int age,
            string eye,
            string nose,
            string mouth,
            bool hasHair,
            string hairStyle,
            string body,
            string skin,
            string posture,
            string shirt,
            string pants,
            string weapon)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Eye = eye;
            this.Nose = nose;
            this.Mouth = mouth;
            this.HasHair = hasHair;
            this.HairStyle = hairStyle;
            this.Body = body;
            this.Skin = skin;
            this.Posture = posture;
            this.Shirt = shirt;
            this.Pants = pants;
            this.Weapon = weapon;
        }

        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; private set; }
        public int Age { get; private set; }
        public string Eye { get; private set; }
        public string Nose { get; private set; }
        public string Mouth { get; private set; }

        public bool HasHair { get; private set; }
        public string HairStyle { get; private set; }

        public string Body { get; private set; }
        public string Skin { get; private set; }

        public string Posture { get; private set; }

        public string Shirt { get; private set; }
        public string Pants { get; private set; }

        public string Weapon { get; private set; }

        public void DisplayCharacterInfo()
        {
            Console.WriteLine("Character Information:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Eye Type: {Eye}");
            Console.WriteLine($"Nose Type: {Nose}");
            Console.WriteLine($"Mouth Type: {Mouth}");
            Console.WriteLine($"Has Hair: {(HasHair ? "Yes" : "No")}");
            if (HasHair)
            {
                Console.WriteLine($"Hair Style: {HairStyle}");
            }
            Console.WriteLine($"Body Type: {Body}");
            Console.WriteLine($"Skin Color: {Skin}");
            Console.WriteLine($"Posture: {Posture}");
            Console.WriteLine($"Shirt Type: {Shirt}");
            Console.WriteLine($"Pants Type: {Pants}");
            Console.WriteLine($"Weapon Type: {Weapon}");
        }
    }
}