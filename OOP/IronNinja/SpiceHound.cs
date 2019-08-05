using System;
class SpiceHound : Ninja
{
    // provide override for IsFull (Full at 1200 Calories)
    public override bool IsFull
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
    public override void Consume(IConsumable item)
    {
        // provide override for Consume
        if(IsFull == false)
        {
            calorieIntake += item.Calories;
            if(item.IsSpicy == true)
            {
                calorieIntake -= 5;
            }
            ConsumptionHistory.Add(item);
            item.GetInfo();
        }
        else
        {
            Console.WriteLine("SpiceHound is full and cannot eat anymore!");
        }
    }
}