using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        class Food
        {
            public string Name;
            public int Calories;
            // Foods can be Spicy and/or Sweet
            public bool IsSpicy; 
            public bool IsSweet; 
            
            // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
            public Food(string name, int calories, bool spicy, bool sweet)
            {
                Name = name;
                Calories = calories;
                IsSpicy = spicy;
                IsSweet = sweet;
            }
        }

        class Buffet
        {
            public List<Food> Menu;
            
            //constructor
            public Buffet()
            {
                Menu = new List<Food>()
                {
                    new Food("Burger", 1000, false, false),
                    new Food("Hotdog", 1000, false, false)
                };
            }
            
            public Food Serve()
            {
                if(Menu.Count > 0)
                {
                    Food item = Menu[0];
                    Menu.RemoveAt(0);
                    return item;
                }
                else
                {
                    Console.WriteLine("Menu is Empty");
                    return null;
                }
            }
        }

        class Ninja
        {
            private int calorieIntake;
            public List<Food> FoodHistory;
             
            // add a constructor
            public Ninja()
            {
                calorieIntake = 0;
                FoodHistory = new List<Food>();
            }
             
            // add a public "getter" property called "IsFull"
            public bool IsFull
            {
                get
                {
                    if(calorieIntake >= 1200)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
             
            // build out the Eat method
            public void Eat(Food item)
            {
                calorieIntake = calorieIntake + item.Calories;
                FoodHistory.Add(item);
            }
        }

        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            Ninja ninja = new Ninja();
            while(ninja.IsFull != true)
            {
                ninja.Eat(buffet.Serve());
            }
        }
    }
}
