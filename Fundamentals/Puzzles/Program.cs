using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static void RandomArray()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            int idx = 0;
            while(idx < arr.Length)
            {
                arr[idx] = rand.Next(5,26);
                idx++;
            }
            int min = arr[0];
            int max = arr[0];
            int sum = 0;
            foreach (var val in arr)
            {
                if(val < min)
                {
                    min = val;
                }
                if(val > max)
                {
                    max = val;
                }
                sum = sum + val;
            }
            Console.WriteLine("Min: " + min + " Max: " + max + " Sum: " + sum);
        }
        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int flip = rand.Next(0,2);
            if(flip == 0)
            {
                Console.WriteLine("Heads");
                return "Heads";
            }
            else
            {
                Console.WriteLine("Tails");
                return "Tails";
            }
        }
        public static double TossMultipleCoins(int total)
        {
            int tosses = 0;
            int heads = 0;
            while(tosses < total)
            {
                string result = TossCoin();
                if(result == "Heads")
                {
                    heads++;
                }
                tosses++;
            }
            double ratio;
            ratio = (double) heads/total;
            Console.WriteLine(ratio);
            return ratio;
        }
        public static List<string> Names()
        {
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            Random rand = new Random();
            for(int i = 0; i < names.Count; i++)
            {
                int idx = rand.Next(0, names.Count);
                string temp = names[idx];
                names[idx] = names[i];
                names[i] = temp;
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            List<string> greaterThan5 = new List<string>();
            for(int i = 0; i < names.Count; i++)
            {
                if(names[i].Length > 5)
                {
                    greaterThan5.Add(names[i]);
                }
            }
            return greaterThan5;
        }
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(5);
            Names();
        }
    }
}
