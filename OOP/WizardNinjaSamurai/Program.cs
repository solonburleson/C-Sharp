using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        class Human
        {
            public string Name;
            public int Strength;
            public int Intelligence;
            public int Dexterity;
            private int health;
            
            public int Health
            {
                get { return health; }
                set { health = value; }
            }
            
            public Human(string name)
            {
                Name = name;
                Strength = 3;
                Intelligence = 3;
                Dexterity = 3;
                health = 100;
            }
            
            public Human(string name, int str, int intel, int dex, int hp)
            {
                Name = name;
                Strength = str;
                Intelligence = intel;
                Dexterity = dex;
                health = hp;
            }
            
            // Build Attack method
            public virtual int Attack(Human target)
            {
                int dmg = Strength * 3;
                target.health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.health;
            }
        }

        class Wizard : Human
        {
            public Wizard(string name) : base(name)
            {
                Health = 50;
                Intelligence = 25;
            }

            public override int Attack(Human target)
            {
                int dmg = Intelligence * 5;
                target.Health -= dmg;
                Health += dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.Health;
            }

            public int Heal(Human target)
            {
                int healing = 10* Intelligence;
                target.Health += healing;
                Console.WriteLine($"{Name} has healed {target.Name} for {healing} points!");
                return target.Health;
            }
        }

        class Ninja : Human
        {
            public Ninja(string name) : base(name)
            {
                Dexterity = 175;
            }

            public override int Attack(Human target)
            {
                int dmg = 5 * Dexterity;
                Random rand = new Random();
                int chance = rand.Next(1,6);
                if(chance == 5)
                {
                    dmg += 10;
                }
                target.Health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.Health;
            }

            public int Steal(Human target)
            {
                int dmg = 5;
                target.Health -= dmg;
                Health += dmg;
                return target.Health;
            }
        }

        class Samurai : Human
        {
            public Samurai(string name) : base(name)
            {
                Health = 200;
            }

            public override int Attack(Human target)
            {
                if(Health < 50)
                {
                    target.Health = 0;
                    Console.WriteLine($"{Name} attacked {target.Name} and reduced their health to 0!");
                }
                else
                {
                    base.Attack(target);
                }
                return target.Health;
            }

            public int Meditate()
            {
                Health = 200;
                return Health;
            }
        }
        static void Main(string[] args)
        {
            Human joe = new Human("Joe");
            Wizard gandalf = new Wizard("Gandalf");
            Ninja naruto = new Ninja("Naruto");
            Samurai hanzo = new Samurai("Hanzo");
            Console.WriteLine(hanzo.Health);
            gandalf.Attack(hanzo);
            gandalf.Attack(hanzo);
            naruto.Attack(gandalf);
            hanzo.Attack(naruto);
            gandalf.Heal(gandalf);
            hanzo.Meditate();
            naruto.Steal(hanzo);
            Console.WriteLine(hanzo.Health);
            Console.WriteLine(gandalf.Health);
            Console.WriteLine(naruto.Health);
        }
    }
}
