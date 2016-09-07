using DataStructures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.UnitTests.LinkedList.RemoveLast
{
    [TestFixture]
    public class RemoveLastShould
    {
        [Test]
        public void RemoveTheLastelement()
        {
            var list = new MyLinkedList<int>();
            var firstNode = new Node<int>() { Value = 3 };
            var secondNode = new Node<int>() { Value = 4 };
            list.Append(firstNode);
            list.Append(secondNode);

            list.RemoveLast();

            Assert.AreSame(list.Head, firstNode);
            Assert.AreEqual(list.Length, 1);
        }
    }
}
