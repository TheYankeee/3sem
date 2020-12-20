using System;
using System.Collections.Generic;
using System.Text;
using MyList;

namespace MyStack
{
    public class SimpleStack<T> : SimpleList<T>
    where T : IComparable
    {
        public void Push(T el)
        {
            Add(el);
        }
        public object Pop()
        {
            var tmp = first;
            while (tmp != null && tmp.next != last)
                tmp = tmp.next;
            last = tmp;
            T data = last.next.data;
            last.next = null;
            Count--;
            return data;
        }
    }
}
