using Exercises.Models;

namespace Exercises.Collections
{
    public class MyLinkedList
    {
        private ListNode<int> head;
        private ListNode<int> tail;
        private int length;

        public MyLinkedList(ListNode<int> head = null)
        {
            this.head = head;
            if (this.head != null)
            {
                this.length++;
            }
        }
        public static bool HasCycle<T>(ListNode<T> head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }

            ListNode<T> slowPointer = head;
            ListNode<T> fastPointer = head;

            while (fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
                if (fastPointer == slowPointer)
                {
                    return true;
                }
            }

            return false;
        }

        public static ListNode<T> DetectCycle<T>(ListNode<T> head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }

            ListNode<T> slowPointer = head;
            ListNode<T> fastPointer = head;

            while (fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
                if (fastPointer == slowPointer)
                {
                    break;
                }
            }

            if (fastPointer == null || fastPointer.next == null)
            {
                return null;
            }

            while (head != slowPointer)
            {
                slowPointer = slowPointer.next;
                head = head.next;
            }

            return head;
        }

        public static ListNode<T> GetIntersectionNode<T>(ListNode<T> headA, ListNode<T> headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }

            HashSet<ListNode<T>> nodeSet = new HashSet<ListNode<T>>();

            while (headA != null)
            {
                nodeSet.Add(headA);
                headA = headA.next;
            }

            while (headB != null)
            {
                if (nodeSet.Contains(headB))
                {
                    return headB;
                }

                headB = headB.next;
            }

            return null;
        }

        public static ListNode<T> RemoveNthFromEnd<T>(ListNode<T> head, int n)
        {
            ListNode<T> fastPointer = head;
            ListNode<T> slowPointer = head;

            for (int i = 0; i < n; i++)
            {
                fastPointer = fastPointer.next;
            }
            if (fastPointer == null) return head.next;
            while(fastPointer.next != null)
            {
                fastPointer = fastPointer.next;
                slowPointer = slowPointer.next;
            }
            slowPointer.next = slowPointer.next.next;

            return head;
        }

        public static ListNode<T> ReverseList<T>(ListNode<T> head)
        {
            if (head == null) return head;

            ListNode<T> firstHead = head;

            while (firstHead.next != null)
            {
                var previousHead = head;
                head = firstHead.next;
                firstHead.next = firstHead.next.next;
                head.next = previousHead;   
            }

            return head;
        }

        public static ListNode<int> RemoveElements(ListNode<int> head, int val)
        {
            if (head == null) return head;

            ListNode<int> current = head;

            while (current.next != null)
            {
                var prev = current;
                current = current.next;
                if (current.value == val)
                {
                    prev.next = current.next;
                    current = prev;
                }
            }

            if (head.value == val)
            {
                head = head.next;
            }

            return head;
        }

        public static ListNode<T> OddEvenList<T>(ListNode<T> head)
        {
            if (head == null || head.next == null) return head;

            // I can create two new ListNode objects!
            ListNode<T> even_head = null;
            ListNode<T> prev = null;
            ListNode<T> even_last = even_head;
            ListNode<T> current = head;

            uint index = 1;
            while (current != null)
            {
                if (index++ % 2 == 0)
                {
                    if (even_head != null)
                    {
                        even_last.next = current;
                    }
                    else
                    {
                        even_head = current;
                    }

                    even_last = current;
                    prev.next = current.next;
                } 
                else
                {
                    prev = current;
                }
                
                current = current.next;
            }

            even_last.next = null;
            prev.next = even_head;

            return head;
        }

        public static bool IsPalindrome(ListNode<int> head)
        {
            // Fast Pointer and Slow Pointer can be use to find middle node
            if (head.next == null) return true;

            ListNode<int> current = head;
            ListNode<int> left_part = head;
            ListNode<int> right_part = head;
            uint count = 0;

            // counting elements
            while (current != null)
            {
                count++;
                current = current.next;
            }

            //find the righ_part
            for (int i = 0; i < count / 2; i++)
            {
                right_part = right_part.next;
            }

            if (count % 2 != 0)
            {
                right_part = right_part.next;
            }

            //swap the left_part
            for (int i = 0; i < count / 2 - 1; i++)
            {
                var previousHead = left_part; 
                left_part = head.next;
                head.next = left_part.next;
                left_part.next = previousHead;
            }

            //compare values
            while (right_part != null)
            {
                if (left_part.value != right_part.value)
                {
                    return false;
                }

                left_part = left_part.next;
                right_part = right_part.next;
            } 

            return true;
        }

        public static ListNode<int> MergeTwoLists(ListNode<int> list1, ListNode<int> list2)
        {
            if (list2 == null)
            {
                return list1;
            }

            var currentList2 = list2;
            var nextList1 = list1;
            var previousList2 = list2;
            while (nextList1 != null)
            {
                var currentList1 = nextList1;
                nextList1 = currentList1.next;
                while (currentList2 != null)
                {
                    if (currentList2.value >= currentList1.value)
                    {
                        currentList1.next = previousList2.next;
                        previousList2.next = currentList1;
                        currentList2 = currentList1;
                        break;
                    }
                    previousList2 = currentList2;
                    currentList2 = currentList2.next;
                }
            }

            return list2;
        }

        public static ListNode<int> RotateRight(ListNode<int> head, int k)
        {
            // slow/fast pointer approach will be also accurate
            if (head == null || head.next == null)
            {
                return head;
            }
            int listNodeLength = 0;
            var temp = head;
            while (temp != null)
            {
                listNodeLength++;
                temp = temp.next;
            }
            int rotationNumber = k % listNodeLength;
            for (int i = 0; i < rotationNumber; i++)
            {
                temp = head;
                var previousLast = temp;
                var last = temp;
                while (temp.next != null)
                {
                    temp = temp.next;
                    previousLast = last;
                    last = temp;
                }
                var oldHead = head;
                head = last;
                head.next = oldHead;
                previousLast.next = null;
            }

            return head;
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
            this.head = new ListNode<int>(val);
            this.head.next = oldHead;
            if (this.head.next == null)
            {
                this.tail = this.head;
            }
            else
            {
                oldHead.prev = this.head;
            }
            this.length++;
        }

        public void AddAtTail(int val)
        {
            var oldTail = this.tail;
            this.tail = new ListNode<int>(val);
            this.tail.prev = oldTail;
            if (oldTail != null)
            {
                oldTail.next = this.tail;
            }
            else
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

            var newNode = new ListNode<int>(val);
            newNode.next = node.next;
            newNode.prev = node;
            node.next.prev = newNode;
            node.next = newNode;

            this.length++;
        }

        public void DeleteAtIndex(int index)
        {
            if (index + 1 > this.length)
            {
                return;
            }

            ListNode<int> node = this.head;
            for (int i = 0; i < index; i++)
            {
                node = node.next;
            }

            if (node.prev == null)
            {
                this.head = node.next;
            }
            else
            {
                node.prev.next = node.next;
            }

            if (node.next != null)
            {
                node.next.prev = node.prev;
            }

            if (index + 1 == this.length)
            {
                this.tail = node.prev;
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
