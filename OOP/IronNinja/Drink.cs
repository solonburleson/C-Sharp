using System;
class Drink : IConsumable
{
    public string Name {get;set;}
    public int Calories {get;set;}
    public bool IsSpicy {get;set;}
    public bool IsSweet {get;set;}
    
    // Implement a GetInfo Method
    public string GetInfo()
    {
        return $"Name: {Name}, Calories: {Calories}, Spicy?: {IsSpicy}, Sweet?: {IsSweet}.";
    }
    // Add a constructor method
    public Drink(string name, int calories, bool spicy)
    {
        Name = name;
        Calories = calories;
        IsSpicy = spicy;
        IsSweet = true;
    }
}   
