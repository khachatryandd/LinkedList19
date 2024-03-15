using LinkedListBigPicture;
using System.Collections;
namespace MyStack;

public class MyStack<T> : IEnumerable<T>
{
    private MyLinkedList<T> myStack = new MyLinkedList<T>();
    //MyLinkedListNode<T> top {  get; set; }

    public void Push(T item)
    {
        myStack.AddFirst(item);
    }
    public T Pop()
    {
        T temp = myStack.head.value;
        myStack.RemoveFirst();
        return temp;
    }
    public T Peek()
    {
        
        return myStack.head.value;
    }
    public IEnumerator<T> GetEnumerator()
    {
        return myStack.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return myStack.GetEnumerator();
    }
}
