using System.Xml;

namespace App.LinkedList
{
    public class LinkedList
    {
        public Node First { get; set; }


        // Insert of the head
        public void InsertFirst(int data)
        {
            Node firstNode = new Node(0);
            firstNode.Data = data;
            firstNode.Next = First;
            First = firstNode;
        }

        public Node DeleteFirst()
        {
            Node temp = First;
            First = First.Next;
            return temp;
        }

        
    }
}
