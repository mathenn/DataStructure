using System.Xml;

namespace ArraysMethods.LinkedList
{
    class LinkedList
    {
        public Node First { get; set; }


        // Insert of the head
        public void InsertFirst(int data)
        {
            Node firstNode = new Node();
            firstNode.Data = data;
            firstNode.Next = First;
            First = firstNode;
        }

        
    }
}
