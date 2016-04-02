using System;
using System.Collections.Generic;
using System.Linq;

class LongestSequenceInList
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the numbers seperated with ,");
        string[] input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<int> numbers = Array.ConvertAll(input, n => int.Parse(n)).ToList() ;
        List<int> equalNumbers = new List<int>();
        int maxSequence = int.MinValue;
        int currentSequence = 0;
        int number = 0;
       
        for (int i = 0; i < numbers.Count - 1; i++)
        {

            if (numbers[i] == numbers[i + 1])
            {
                currentSequence++;
                number = numbers[i];
            }
            else
            {
                currentSequence = 0;
            }
            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
              
            }
        }
        for (int i = 0; i <= maxSequence; i++)
        {
            equalNumbers.Add(number);
        }
        PrintResult(equalNumbers, maxSequence);
    }

    private static void PrintResult(List<int> equalElements, int maxSequence)
    {
        Console.WriteLine("The most frequent sequence is: ");
        Console.Write("{");
        for (int i = 0; i < equalElements.Count; i++)
        {
            if (i < maxSequence)
            {
                Console.Write(equalElements[i] + ", ");

            }
            else
            {
                Console.Write(equalElements[i]);
            }

        }
        Console.WriteLine("}");
    }
}
