using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Next { get; set; }

    }

    public class MyLinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public int Length { get; private set; }

        public void Append(Node<T> node)
        {
            if (this.Head == null)
            {
                this.Head = node;
            }
            else
            {
                this.Tail.Next = node;
            }

            this.Tail = node;
            this.Length++;
        }

        public void Prepend(Node<T> node)
        {
            if (this.Length == 0)
            {
                this.Append(node);
            }
            else
            {
                var oldHead = this.Head;

                this.Head = node;
                this.Head.Next = oldHead;

                this.Length++;

                if (this.Length == 1)
                {
                    this.Head = this.Tail;
                }
            }
        }

        public void RemoveFirst()
        {
            var newHead = this.Head.Next;
            this.Head = newHead;
            this.Length--;
        }

        public void RemoveLast()
        {
            var currentNode = this.Head;

            while (currentNode != this.Tail)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = null;
            this.Tail = currentNode;

            this.Length--;
        }

        public override string ToString()
        {
            var result = string.Join(" -> ", this.ToArray());

            return result;
        }

        public T[] ToArray()
        {
            var node = this.Head;
            var array = new T[this.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = node.Value;
                node = node.Next;
            }

            return array;
        }
    }
}
