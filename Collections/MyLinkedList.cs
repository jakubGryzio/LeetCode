using LeetCode.Models;

namespace LeetCode.Collections
{
    internal class MyLinkedList
    {
        private ListNode<int> head;
        private ListNode<int> tail;
        private int length;

        public MyLinkedList()
        {

        }

        public int Get(int index)
        {
            if (index + 1 > this.length)
            {
                return -1;
            }

            var node = this.head;
            for (int i = 0; i < index; i++)
            {
                node = node.next;
            }

            return node.value;
        }
        
        public void AddAtHead(int val)
        {
            var oldHead = this.head;
            this.head = new ListNode<int>();
            this.head.value = val;
            this.head.next = oldHead;
            if (this.head.next == null)
            {
                this.tail = this.head;
            }
            this.length++;
        }

        public void AddAtTail(int val)
        {
            var oldTail = this.tail;
            this.tail = new ListNode<int>();
            this.tail.value = val;
            if (oldTail != null)
            {
                oldTail.next = this.tail;
            }
            if (this.head == null)
            {
                this.head = this.tail;
            }
            this.length++;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index > this.length)
            {
                return;
            }

            if (index == 0)
            {
                this.AddAtHead(val);
                return;
            }

            if (index == this.length)
            {
                this.AddAtTail(val);
                return;
            }

            var node = this.head;
            for (int i = 0; i < index - 1; i++)
            {
                node = node.next;
            }

            var newNode = new ListNode<int>();
            newNode.value = val;
            newNode.next = node.next;
            node.next = newNode;
            
            if (index == this.length)
            {
                this.tail = newNode;
            }

            this.length++;
        }

        public void DeleteAtIndex(int index)
        {
            if (index + 1 > this.length)
            {
                return;
            }

            ListNode<int> node = this.head;
            ListNode<int> prev = null;
            for (int i = 0; i < index; i++)
            {
                prev = node;
                node = node.next;
            }

            if (prev == null)
            {
                this.head = node.next;
            }
            else
            {
                prev.next = node.next;
            }

            if (index + 1 == this.length)
            {
                this.tail = prev;
            }

            length--;
        }

        private ListNode<int> GetNode(int index)
        {
            if (index + 1 > this.length)
            {
                return null;
            }

            var node = this.head;
            for (int i = 0; i < index; i++)
            {
                node = node.next;
            }

            return node;
        }
    }
}
