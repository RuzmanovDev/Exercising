using System;
using System.Collections.Generic;

class IsTheNumberPrime
{
    static void Main()
    {


        int number = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();

        for (int i = 0; i <= number; i++)
        {
            numbers.Add(i);
        }

        int m = number / 2;
        int p = 2;

    

        for (int i = p; i <= numbers.Count; i++)
        {
            if (numbers[i] % p != 0)
            {
                Console.Write(" "+ i+" ");
            }

        }
       

    }



}

