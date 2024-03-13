using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListBigPicture
{
    internal class MyLinkedList<T> : ICollection<T>
    {
        public MyLinkedListNode<T> head { get; private set; }
        public MyLinkedListNode<T> tail { get; private set; }
        #region ICollection
        public int Count {  get; private set; }

        public bool IsReadOnly { get => false; }

        public void Add(T item)
        {
            //AddFirst(item);
            AddLast(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        } 

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
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
        #endregion
    }
}
