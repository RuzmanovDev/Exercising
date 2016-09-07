using DataStructures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.UnitTests.LinkedList.Foreach
{
    [TestFixture]
    public class LinkedListShould
    {
        [Test]
        public void BeItteratable_UsingForeach()
        {
            var list = new MyLinkedList<int>();
            var node1 = new Node<int>() { Value = 1 };
            var node2 = new Node<int>() { Value = 2 };
            var node3 = new Node<int>() { Value = 3 };
            var node4 = new Node<int>() { Value = 4 };

            list.Append(node1);
            list.Append(node2);
            list.Append(node3);
            list.Append(node4);

            var valueOfNode = node1.Value;
            foreach (var item in list)
            {
                Assert.AreEqual(valueOfNode, item);
                valueOfNode++;
            }
        }
    }
}
