using System;

namespace FundamentalsI
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
            }
            int num = 1;
            while(num <= 100)
            {
                if(num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(num % 5 == 0 && num % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(num % 3 == 0 && num % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                num = num + 1;
            }
        }
    }
}
