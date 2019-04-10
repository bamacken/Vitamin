using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructure;

namespace UnitTest
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void Test_LinkedList_Insertion()
        {
            LinkedList list = new LinkedList(); 

            // Add a nore to the list
            list.InsertNode("4"); 

            // Check to see if the node has been added
            Node test = list.Traverse("4");

            Assert.AreEqual("4", test.getData().ToString(), "Node was not added correctly");
        }

        [TestMethod]
        public void Test_LinkedList_travesal()
        {
            LinkedList list = new LinkedList();

            // Add a nore to the list
            list.InsertNode("1");
            list.InsertNode("2");
            list.InsertNode("3");
            list.InsertNode("4");
            list.InsertNode("5");

            // Check to see if the node has been added
            Node test_1 = list.Traverse("1");
            Assert.AreEqual("1", test_1.getData().ToString(), "Excpected Node (1) not found");

            Node test_2 = list.Traverse("4");
            Assert.AreEqual("4", test_2.getData().ToString(), "Excpected Node (4) not found");
        }
    }
}
