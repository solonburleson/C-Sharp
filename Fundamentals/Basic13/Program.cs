using System;

namespace Basic13
{
    class Program
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            for(int i = 1; i <= 255; i++)
            {
                if(i % 2 != 0){
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for(int i = 0; i <= 255; i++)
            {
                sum = sum + i;
                Console.WriteLine("New number: " + i + " Sum: " + sum);
            }
        }
        public static void LoopArray(int[] numbers)
        {
            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        public static void FindMax(int[] numbers)
        {
            int max = numbers[0];
            foreach(var num in numbers)
            {
                if(num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            int avg;
            foreach(var num in numbers)
            {
                sum = sum + num;
            }
            avg = sum / numbers.Length;
            Console.WriteLine(avg);
        }
        public static int[] OddArray()
        {
            int arrLength = 256/2;
            int[] oddArray = new int[arrLength];
            int idx = 0;
            for(int i = 1; i <= 255; i++)
            {
                if(i % 2 != 0)
                {
                    oddArray[idx] = i;
                    idx++;
                }
            }
            return oddArray;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            foreach(var num in numbers)
            {
                if(num > y)
                {
                    count = count + 1;
                }
            }
            return count;
        }
        public static void SquareArrayValues(int[] numbers)
        {
            int[] squares = new int[numbers.Length];
            int idx = 0;
            foreach(var num in numbers)
            {
                squares[idx] = num * num;
                idx++;
            }
            Console.WriteLine(squares[0]);
            Console.WriteLine(squares[1]);
            Console.WriteLine(squares[2]);
            Console.WriteLine(squares[3]);
        }
        public static void EliminateNegatives(int[] numbers)
        {
            int idx = 0;
            foreach(var num in numbers)
            {
                if(num < 0)
                {
                    numbers[idx] = 0;
                }
                idx++;
            }
        }
        public static void MinMaxAverage(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;
            int avg;
            foreach (var num in numbers)
            {
                if(num > max)
                {
                    max = num;
                }
                if(num < min)
                {
                    min = num;
                }
                sum = sum + num;
            }
            avg = sum / numbers.Length;
            Console.WriteLine("Min: " + min + " Max: " + max+ " Avg: " + avg);
        }
        public static void ShiftValues(int[] numbers)
        {
            int idx = 0;
            while(idx < numbers.Length-1)
            {
                numbers[idx] = numbers[idx+1];
                idx++;
            }
            numbers[numbers.Length-1] = 0;
        }
        public static object[] NumToString(int[] numbers)
        {
            object[] objects = new object[numbers.Length];
            int idx = 0;
            foreach (var num in numbers)
            {
                if(num < 0)
                {
                    objects[idx] = "Dojo";
                }
                else
                {
                    objects[idx] = num;
                }
                idx++;
            }
            Console.WriteLine(objects[0]);
            Console.WriteLine(objects[1]);
            Console.WriteLine(objects[2]);
            return objects;
        }
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintOdds();
            PrintSum();
            int[] numbers = {1,5,4,2,3};
            LoopArray(numbers);
            FindMax(numbers);
            GetAverage(numbers);
            OddArray();
            int[] Y = {1,3,5,7};
            Console.WriteLine(GreaterThanY(Y, 3));
            int[] square = {1,5,10,-10};
            SquareArrayValues(square);
            int[] noNeg = {1,5,10,-2};
            EliminateNegatives(noNeg);
            int[] minmaxavg = {1,5,10,-2};
            MinMaxAverage(minmaxavg);
            int[] shiftArray = {1,5,10,7,-2};
            ShiftValues(shiftArray);
            int[] numToStr = {-1,-3,2};
            NumToString(numToStr);
        }
    }
}
