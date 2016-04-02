using System;
using System.Collections.Generic;

class SumAndAverageOfSequence
{
    static void Main()
    {
        Console.WriteLine("Enter some numbers");
        string input = Console.ReadLine();
        List<int> numbers = new List<int>();
        int number = 0; ;

        while (!input.Equals(Environment.NewLine))
        {
            bool canParse = int.TryParse(input, out number);
            if (canParse)
            {
                numbers.Add(number);
            }
            else
            {
                break;
            }
            input = Console.ReadLine();
           
            
        }

        double sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        double average = sum / numbers.Count;

        Console.WriteLine("The sum is: {0}",sum);
        Console.WriteLine("The average is: {0}",average);

    }
}

