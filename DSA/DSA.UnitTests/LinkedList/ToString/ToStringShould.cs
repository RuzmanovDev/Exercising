using DataStructures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.UnitTests.LinkedList.ToString
{
    [TestFixture]
    public class ToStringShould
    {
        [Test]
        public void RetrunCorectlyFormattedStringOfTheValues()
        {
            var list = new MyLinkedList<int>();
            var firstNode = new Node<int>() { Value = 3 };
            var secondNode = new Node<int>() { Value = 4 };
            var thirdNode = new Node<int>() { Value = 5 };
            list.Append(firstNode);
            list.Append(secondNode);
            list.Append(thirdNode);
            var expected = "3 -> 4 -> 5";

            var toStringOutput = list.ToString();

            Assert.AreEqual(expected, toStringOutput);
        }
    }
}
