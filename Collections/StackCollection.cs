using Exercises.Models;
using System.Collections;

namespace Exercises.Collections
{
    internal class StackCollection<T> : IEnumerable<T>
    {
        private int length;
        private ListNode<T> head;

        public StackCollection(ListNode<T> head = null)
        {
            this.head = head;
        }

        public void Push(T value)
        {
            ListNode<T> oldhead = this.head;
            this.head = new ListNode<T>(value);
            this.head.next = oldhead;
            this.length++;
        }

        public T Pop()
        {
            ListNode<T> head = this.head;
            this.head = head.next;
            this.length--;
            return head.value;
        }

        public int GetSize()
        {
            return this.length;
        }

        public bool IsEmpty()
        {
            return this.length == 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new GenericEnumerator<T>(this.head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
