namespace App.LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }

        public Node(int data)
        {
            Data = data;
        }


        public int CountNodes(Node node)
        {
            int count = 0;
            Node current = node;
            while (current.Next != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
    }
}
