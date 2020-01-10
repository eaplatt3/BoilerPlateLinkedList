using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinkedList
    {
        //The First node of the Linked List
        //The Node will be an Object that is null by default
        Node head;

        class Node
        {
            int data;
            Node nect;

            //Constructor to Make a Node
            Node(int d) { data = d; }
        }
    }
}
