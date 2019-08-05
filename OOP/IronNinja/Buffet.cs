using System;
using System.Collections.Generic;
class Buffet
{
    public List<IConsumable> Menu;
    
    //constructor
    public Buffet()
    {
        Menu = new List<IConsumable>()
        {
            new Food("Burger", 1000, false, false),
            new Food("Hotdog", 1000, false, false),
            new Food("Hot Wings", 1000, true, false),
            new Food("French Fries", 300, false, true),
            new Drink("Coke", 150, false),
            new Drink("Dr Pepper", 150, false),
        };
    }
    
    public IConsumable Serve()
    {
        if(Menu.Count > 0)
        {
            Random rand = new Random();
            int index = rand.Next(0, Menu.Count);
            IConsumable item = Menu[index];
            Menu.RemoveAt(index);
            return item;
        }
        else
        {
            Console.WriteLine("Menu is Empty");
            return null;
        }
    }
}