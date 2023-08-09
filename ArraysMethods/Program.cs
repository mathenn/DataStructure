using System;
using System.Security.Cryptography.X509Certificates;
using ArraysMethods.LinkedList;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Node nodeA = new Node();
            Node nodeB = new Node();
            Node nodeC = new Node();
            Node nodeD = new Node();

            nodeA.Data = 322;
            nodeB.Data = 398;
            nodeC.Data = 863;
            nodeD.Data = 284;

            nodeA.Next = nodeB;
            nodeB.Next = nodeC;
            nodeC.Next = nodeD;
            nodeD.Next = null;
        }
    }
}