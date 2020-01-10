using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LinkedList
    {
        //The First node of the Linked List
        //The Node will be an Object that is null by default
        public Node head;

        public class Node
        {
            public int data;
            public Node next;
           
            //Constructor to Make a Node
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        //Method to Print List
        public void printList()
        {
            Node n = head;
            while (n != null)//checks that the node is not null
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
        }
    }
}
