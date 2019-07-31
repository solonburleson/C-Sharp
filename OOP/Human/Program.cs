using System;

namespace Human
{
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
         
        // add a public "getter" property to access health
        public int Health
        {
            get
            {
                return health;
            }
        }

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
         
        // Add a constructor to assign custom values to all fields
        public Human(string name, int str, int intel, int dex, int Health)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = Health;
        }
         
        // Build Attack method
        public int Attack(Human target)
        {
            int health = target.Health;
            health = health - (Strength * 5);
            return health; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Steve");
            Human h2 = new Human("Sal", 4, 2, 5, 150);
            Console.WriteLine(h2.Health);
            Console.WriteLine(h1.Attack(h2));
        }
    }
}
