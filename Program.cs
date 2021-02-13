using System;
using System.Collections.Generic;

namespace CS_Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {

            var objList = new List<object>
            {
                7,
                28,
                -1,
                true,
                "chair"
            };

            int sum = 0;
                foreach (var i in objList)
                {
                    if (i is int) {
                        //This shouldn't run
                        Console.WriteLine($"{i} is an integer");
                        sum += (int)i;
                    }
                    if (i is string) {
                        Console.WriteLine($"{i} is a string");
                    }
                }
                Console.WriteLine(sum);
        }
    }
}
