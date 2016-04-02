using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int number = 0;
        var sortedNumbers = new List<int>();

        while (!input.Equals(Environment.NewLine))
        {
            bool canParse = int.TryParse(input, out number);
            if (canParse)
            {
                if (number>=0)
                {
                    sortedNumbers.Add(number);
                }
            }
            else
            {
                break;
            }
            input = Console.ReadLine();
        }
        sortedNumbers.Sort();
        foreach (var num in sortedNumbers)
        {
            Console.WriteLine(num);
        }

    }
}

