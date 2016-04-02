using System;
using System.Collections.Generic;

class PrintNumbersInReverse
{
    static void Main(string[] args)
    {
        Stack<int> numbers = new Stack<int>();
        string input = Console.ReadLine();
        int num = 0;
        while (true)
        {
            bool canParse = int.TryParse(input, out num);
            if (canParse)
            {
                numbers.Push(num);
            }
            else
            {
                break;
            }
            input = Console.ReadLine();
        }

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

