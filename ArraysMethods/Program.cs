using System;
using System.Security.Cryptography.X509Certificates;
using App.LinkedList;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(4);
            Node nodeB = new Node(2);
            Node nodeC = new Node(3);
            Node nodeD = new Node(10);

            head.Next = nodeB;
            nodeB.Next = nodeC;
            nodeC.Next = nodeD;
            nodeD.Next = null;

            
            Console.WriteLine(head.CountNodes(head));
        }
    }
}