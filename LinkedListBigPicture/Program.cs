namespace LinkedListBigPicture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> linkedList19 = new MyLinkedList<int> ();
            linkedList19.Add (1);
            linkedList19.Add (2);
            linkedList19.Add (3);
            linkedList19.Add (4);   
            linkedList19.Add (5);
            linkedList19.Add (6);
            linkedList19.Add (7);
            Print(linkedList19.tail);
        }
        public static void Print(MyLinkedListNode<int> node)
        {
            while(node != null)
            {
                Console.WriteLine(node.value);
                node = node.next;
            }
        }
    }
}
