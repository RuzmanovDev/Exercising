using System;
using System.Collections.Generic;

class QueueDemo
{
    static void Main(string[] args)
    {
        int n = 3;
        int p = 16;
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(n);
        int index = 0;
        Console.WriteLine("S=");
        while (queue.Count > 0)
        {
            index++;
            int current = queue.Dequeue();
            Console.WriteLine(" " + current);
            if (current==p)
            {
                Console.WriteLine();
                Console.WriteLine("Index = " + index);
                return;
            }
            queue.Enqueue(current + 1);
            queue.Enqueue(2 * current);
        }

    }

}
