namespace DataStructures
{
    using System;

    class DynamicList
    {
        private class Node
        {
            private object element;
            private Node next;

            public object Element
            {
                get { return element; }
                set { element = value; }
            }

            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            public Node(object element, Node prevNode)
            {
                this.element = element;
                prevNode.next = this;
            }

            public Node(object element)
            {
                this.element = element;
                next = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }
        //Add element at the end of the list
        public void Add(object item)
        {
            if (head == null)
            {
                //we have empty list
                head = new Node(item);
                tail = head;
            }
            else
            {
                // we have non-empty list
                Node newNode = new Node(item, tail);
                tail = newNode;
            }
            count++;
        }
    }
}
