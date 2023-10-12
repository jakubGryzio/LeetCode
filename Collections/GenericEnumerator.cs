using System.Collections;
using LeetCode.Models;

namespace LeetCode.Collections
{
    internal class GenericEnumerator<T> : IEnumerator<T>
    {
        private ListNode<T> current;

        public GenericEnumerator(ListNode<T> node)
        {
            this.current = node;
        }

        public T Current
        {
            get
            {
                var current = this.current;
                this.current = this.current.next;
                return current.value;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return this.Current;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return this.current != null;
        }

        public void Reset()
        {
        }
    }
}
