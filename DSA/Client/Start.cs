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

            for (int i = 0; i < 5; i++)
            {
                var node = new Node<int>() { Value = i };

                list.Append(node);
            }

            foreach (var v in list)
            {
                Console.WriteLine(v);
            }
        }
    }
}
