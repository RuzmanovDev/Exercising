using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node<T>
    {
        public Node(T value)
        {
            this.Value = value;
        }
        public T Value { get; set; }

        public Node<T> Next { get; set; }

    }

    public class MyLinkedList<T> : ICollection<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }


        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

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
            this.Count++;
        }

        public void Prepend(Node<T> node)
        {
            if (this.Count == 0)
            {
                this.Append(node);
            }
            else
            {
                var oldHead = this.Head;

                this.Head = node;
                this.Head.Next = oldHead;

                this.Count++;

                if (this.Count == 1)
                {
                    this.Head = this.Tail;
                }
            }
        }

        public void RemoveFirst()
        {
            var newHead = this.Head.Next;
            this.Head = newHead;
            this.Count--;
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

            this.Count--;
        }

        public override string ToString()
        {
            var result = string.Join(" -> ", this.ToArray());

            return result;
        }

        public T[] ToArray()
        {
            var node = this.Head;
            var array = new T[this.Count];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = node.Value;
                node = node.Next;
            }

            return array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var values = this.ToArray();

            for (int i = 0; i < values.Length; i++)
            {
                yield return values[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }
    }
}
