namespace MyQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> myQueue = new MyQueue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Enqueue(6);
           
            Console.WriteLine(myQueue.Peek());
            myQueue.Dequeue();

            Console.WriteLine(myQueue.Peek());
            myQueue.Dequeue();

            Console.WriteLine(myQueue.Peek());
        }
    }
}
