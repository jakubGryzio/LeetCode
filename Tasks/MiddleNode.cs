using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MiddleNode<T>
    {
        public static ListNode<T> Execute(ListNode<T> head)
        {
            if (head.next == null)
            {
                return head;
            }

            var arr = new List<ListNode<T>>();
            int len = 0;

            while(head.next != null)
            {
                arr.Add(head.next);
                head = head.next;
                len++;
            }

            return arr.Count() % 2 == 0 ? arr[len / 2 - 1] : arr[len / 2];
        }

        public static ListNode<T> ExecuteBetter(ListNode<T> head)
        {
            if (head.next == null)
            {
                return head;
            }

            ListNode<T> middle = head;
            ListNode<T> last = head;

            while (last != null && last.next != null)
            {
                middle = middle.next;
                last = last.next.next;
            }

            return middle;
        }
    }
}
