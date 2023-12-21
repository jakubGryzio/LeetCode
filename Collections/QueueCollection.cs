using Exercises.Models;
using System.Collections;

namespace Exercises.Collections
{
    internal class QueueCollection<T> : IEnumerable<T>
    {
        private ListNode<T> first;
        private ListNode<T> last;
        private int length;

        public void Enqueue(T value)
        {
            var previousLast = this.last;
            this.last = new ListNode<T>();
            this.last.value = value;

            if (this.first == null) 
            {
                this.first = this.last;
            }
            else
            {
                previousLast.next = this.last;
            }

            this.length++;
        }

        public ListNode<T> Dequeue()
        {
            if (IsEmpty()) return null;
            var previousFirst = this.first;
            this.first = previousFirst.next;
            this.length--;
            if (IsEmpty())
            {
                this.last = null;
            }
            return previousFirst;
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
            return new GenericEnumerator<T>(this.first);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
