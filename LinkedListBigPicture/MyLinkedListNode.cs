namespace LinkedListBigPicture;

public class MyLinkedListNode<T>
{
    public T value {  get; set; }
    public MyLinkedListNode<T> next { get; set; }
    public MyLinkedListNode(T value)
    {
        this.value = value;
    }
}
