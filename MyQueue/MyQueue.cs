using LinkedListBigPicture;
using System.Collections;
namespace MyQueue;

public class MyQueue<T> : IEnumerable<T>
{
    private MyLinkedList<T> myQueue = new MyLinkedList<T>();
    //MyLinkedListNode<T> top {  get; set; }

    public void Enqueue(T item)
    {
        myQueue.Add(item);
    }
    public T Dequeue()
    {
        T temp = myQueue.head.value;
        myQueue.RemoveFirst();
        return temp;
    }
    public T Peek()
    {
        return myQueue.head.value;
    }
    public IEnumerator<T> GetEnumerator()
    {
        return myQueue.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return myQueue.GetEnumerator();
    }
    public int Count => myQueue.Count;  
}
