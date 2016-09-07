using DataStructures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.UnitTests.LinkedList.Append
{
    [TestFixture]
    public class AppendShould
    {
        [Test]
        public void AddOneItemToTheList_WhenInputIsValid()
        {
            var list = new MyLinkedList<int>();
            var nodeToAdd = new Node<int> { Value = 2 };

            list.Append(nodeToAdd);

            Assert.AreSame(list.Head, nodeToAdd);
            Assert.AreEqual(list.Length, 1);
        }

        [Test]
        public void Add3ItemsToTheList_WhenInputIsValid()
        {
            var list = new MyLinkedList<int>();
            var nodeToAdd = new Node<int> { Value = 2 };
            var secondNode = new Node<int> { Value = 4 };
            var thirdNode = new Node<int> { Value = 55 };

            list.Append(nodeToAdd);
            list.Append(secondNode);
            list.Append(thirdNode);

            Assert.AreEqual(list.Length, 3);
        }
    }
}
