using System;
using System.Collections.Generic;


namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = {0,1,2,3,4,5,6,7,8,9};
            string[] namesArray = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] boolArray = {true, false, true, false, true, false, true, false, true, false};
            Console.WriteLine(intArray[3]);
            Console.WriteLine(namesArray[1]);
            Console.WriteLine(boolArray[2]);
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Rainbow Sherbert");
            flavors.Add("Cookies N' Cream");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);
            Dictionary<string,string> dict = new Dictionary<string,string>();
            Random rand = new Random();
            foreach (var name in namesArray)
            {
                int idx = rand.Next(0,4);
                dict.Add(name, flavors[idx]);
            }
            foreach(var entry in dict)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
