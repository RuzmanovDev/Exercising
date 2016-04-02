// 2,3,5,4,4,7,5,6,11,7,5,9,6...

using System;
using System.Collections.Generic;


class QueueSequence
{
    static void Main(string[] args)
    {
        Queue<int> numbers = new Queue<int>();
        int counter = 1;
        numbers.Enqueue(2);
        while (counter<50)
        {
            counter++;
            int current = numbers.Peek();
            
            Console.WriteLine(current);
          
            numbers.Enqueue(current+1);
            numbers.Enqueue(2*current + 1);
            numbers.Enqueue(current + 2);
            numbers.Dequeue();
        }

    }
}

