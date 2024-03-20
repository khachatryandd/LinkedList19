using System.Security.Cryptography.X509Certificates;

namespace LinkedListBigPicture;
internal class Program
{

    static void Main(string[] args)
    {
        MyLinkedList<int>[] linkedList19 = new MyLinkedList<int>[4];
        int l = linkedList19.Length;
        for (int i = 0; i < linkedList19.Length; i++)
        {
            linkedList19[i] = new MyLinkedList<int>();
            linkedList19[i].Add(i);
           
            
                if (i == l - 1)
                {
                    NewArray(ref l, ref linkedList19);

                }
            
        }
        //linkedList19.Add(1);
        //linkedList19.Add (2);
        //linkedList19.Add (3);
        //linkedList19.Add (4);   
        //linkedList19.Add (5);
        //linkedList19.Add (6);
        //linkedList19.Add (7);
        for (int i = 0; i < linkedList19.Length; i++)
        {
            Console.WriteLine((linkedList19[i]));
        }
    }
    public static void NewArray(ref int a, ref MyLinkedList<int>[] array)
    {

        MyLinkedList<int>[] newLinkedList19 = new MyLinkedList<int>[a * 2];
        Array.Copy(array, newLinkedList19, a);
        array = newLinkedList19;
        a *= 2;
    }
    public static void Print(MyLinkedListNode<int> node)
    {
        while (node != null)
        {
            Console.WriteLine(node.value);
            node = node.next;
        }
    }
}
