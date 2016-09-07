using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Start
    {
        static void Main(string[] args)
        {
            var list = new MyLinkedList<int>();

            for (int i = 0; i < 3; i++)
            {
                var node = new Node<int>() { Value = i };

                list.Append(node);
            }

            Console.WriteLine(list.ToString());
            var arr = list.ToArray();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
