using DataStructures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.UnitTests.LinkedList.Prepend
{
    [TestFixture]
    public class PrependShould
    {

        [Test]
        public void AddItemToTheStartOfTHeList_WhenValidItemIsPassed()
        {
            var list = new MyLinkedList<int>();
            var node = new Node<int>() { Value = 42 };

            list.Prepend(node);

            Assert.AreSame(list.Head, node);
            Assert.AreSame(list.Tail, node);
            Assert.AreEqual(list.Length, 1);
        }

        [Test]
        public void AddItemsToTheStartOfTHeList_WhenValidItemIsPassed()
        {
            var list = new MyLinkedList<int>();
            var node = new Node<int>() { Value = 42 };
            var node2 = new Node<int>() { Value = 422 };
            var node3 = new Node<int>() { Value = 423 };

            list.Prepend(node);
            list.Prepend(node2);
            list.Prepend(node3);

            Assert.AreSame(list.Head, node3);
            Assert.AreSame(list.Tail, node);
            Assert.AreEqual(list.Length, 3);
        }
    }
}
