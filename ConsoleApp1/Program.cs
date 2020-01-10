using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.LinkedList;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates List
            LinkedList list = new LinkedList();

            //Creating Nodes that are Allocated Dynamically
            list.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            //links first with second
            list.head.next = second;
            
            //links second with third
            second.next = third;
            
        }
    }
}
