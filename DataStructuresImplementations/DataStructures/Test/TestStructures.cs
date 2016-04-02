
namespace Test
{
    using System;
    using DataStructures;
    using System.Collections.Generic;
    class TestStructures
    {
        static void Main()
        {
            int[] numbers = new int[] { 2, 3, 4, 2, 2 };
            int[] secondNUmbers = new int[numbers.Length];
            Console.WriteLine(numbers.Length);


            Array.Copy(numbers, 1, numbers, 0, numbers.Length-1);

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
