using System.Collections;

namespace LinkedListBigPicture;

public class MyLinkedList<T> : ICollection<T>
{
    public MyLinkedListNode<T> head { get; private set; }
    public MyLinkedListNode<T> tail { get; private set; }
    #region ICollection
    public int Count {  get; private set; }

    public bool IsReadOnly { get => false; }

    public void Add(T item)
    {
        AddFirst(item);
        //AddLast(item);
    }

    public void Clear()
    {
        head = null;
        tail = null;
        Count = 0;
    }

    public bool Contains(T item)
    {
        MyLinkedListNode<T> current = head;
        while(current != null)
        {
            if (current.value.Equals(item))
            {
                return true;
            }
            current = current.next;
        }
        return false;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        MyLinkedListNode<T> current = head;
        while(current != null)
        {
            yield return current.value;
            current = current.next;
        }
    }

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    } 

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<T>)this).GetEnumerator();
    }
 
    #endregion
    #region Add
    public void AddFirst(T item)
    {
        AddFirst(new MyLinkedListNode<T>(item));

    }
    public void AddLast(T item)
    {
        AddLast(new MyLinkedListNode<T>(item));

    }
    private void AddFirst(MyLinkedListNode<T> node)
    {
        MyLinkedListNode<T> temp = head;
        head = node;
        head.next = temp;
        Count++;
        if(Count == 1)
        {
            tail= head;
        }
    }
    private void AddLast(MyLinkedListNode<T> node)
    {

        if(Count == 0)
        {
            head = node;
        }
        else
        {
            tail.next = node;
        }
        tail = node;
        Count++;
    }
    #region Remove
    public void RemoveFirst()
    {
        if(Count != 0)
        {
            head = head.next;
            Count--;
            if(Count == 0)
            {
                tail = null;
            }
        }
    }
    public void RemoveLast()
    {
        if(Count != 0)
        {
            if(Count == 1)
            {
                head = null;
                tail = null;
            }
            else
            {
                MyLinkedListNode<T> current = head;
                while(current.next != tail)
                {
                    current = current.next;
                }
                current.next = null;
                tail= current;
            }
            Count--; 
        }
    }
    #endregion
    #endregion
}
