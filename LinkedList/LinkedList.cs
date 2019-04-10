using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        Node headNode;

        // Insert
        public void InsertNode(object data)
        {
            Node new_node = new Node(data);
            new_node.NextNode = headNode;
            headNode = new_node;
        }

        // Delete
        public void Delete(object data)
        {
            // Check if we are attempting to detele the head node
            if (headNode.Data == data)
            {
                headNode = headNode.NextNode;
                return;
            }

            Node currentNode = headNode;
            Node previousNode = null;
            while (currentNode.Data != data)
            {
                previousNode = currentNode;
                currentNode = currentNode.NextNode;
            }
            previousNode.NextNode = currentNode.NextNode;
        }

        public Node Traverse(object data)
        {
            Node currentNode = headNode;
            while (currentNode.Data != data)
            {
                currentNode = currentNode.NextNode;
            }
            return currentNode;
        }
    }

    /// <summary>
    /// Node class for singly linkedlist
    /// </summary>
    public class Node
    {
        internal object Data;
        internal Node NextNode;

        public Node(object data)
        {
            this.Data = data;
        }

        public object getData()
        {
            return this.Data;
        }
    }

    /// <summary>
    /// Node class for doubly linked list
    /// </summary>
    public class DoubleNode
    {
        private object Data;
        private DoubleNode NextNode;
        private DoubleNode PrevNode;

        public DoubleNode(object data, DoubleNode nextNode, DoubleNode prevNode)
        {
            this.Data = data;
            this.NextNode = nextNode;
            this.PrevNode = prevNode;
        }

        public object getData()
        {
            return this.Data;
        }

    }
}
