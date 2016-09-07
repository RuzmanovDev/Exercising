using DataStructures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.UnitTests.LinkedList.RemoveFirst
{
    [TestFixture]
    public class RemoveFirstShould
    {
        [Test]
        public void RemoveThelastElement()
        {
            var list = new MyLinkedList<int>();
            var firstNode = new Node<int>() { Value = 3 };
            var secondNode = new Node<int>() { Value = 4 };
            list.Append(firstNode);
            list.Append(secondNode);

            list.RemoveFirst();

            Assert.AreSame(list.Head, secondNode);
            Assert.AreEqual(list.Count, 1);
        }
    }
}
