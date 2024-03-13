using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LinkedListBigPicture
{
    internal class MyLinkedListNode<T>
    {
        public T value {  get; set; }
        public MyLinkedListNode<T> next { get; set; }
        public MyLinkedListNode(T value)
        {
            this.value = value;
        }
    }
}
