using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> boxes = new List<object>();
            boxes.Add(7);
            boxes.Add(28);
            boxes.Add(-1);
            boxes.Add(true);
            boxes.Add("chair");
            int sum = 0;
            foreach (var box in boxes)
            {
                if(box is int){
                    int intBox = (int) box;
                    sum = sum + intBox;
                    Console.WriteLine(intBox); 
                }
                if(box is bool){
                    bool boolBox = (bool) box;
                    Console.WriteLine(boolBox);
                }
                if(box is string){
                    string strBox = box as string;
                    Console.WriteLine(strBox);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
