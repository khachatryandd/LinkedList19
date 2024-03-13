namespace LinkedList19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node { Value = 3 };
            Node middle = new Node { Value = 5 };
            first.Next = middle;

            Node last = new Node { Value = 7 };
            middle.Next = last;
            Print(first);
        }
        public static void Print(Node node)
        {
            Console.WriteLine(node.Value);
            while (node.Next != null)
            {
                node = node.Next;
                Console.WriteLine(node.Value);
                
            }
        }
    }
}
