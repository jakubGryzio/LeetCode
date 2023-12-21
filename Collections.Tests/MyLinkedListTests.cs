using Exercises.Collections;
using Exercises.Models;
using Newtonsoft.Json.Linq;

namespace Collections.Tests;

public class MyLinkedListTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Get_From_Linked_List()
    {
        int value = 1;
        int firtElementIndex = 0;

        var listNode = new ListNode<int>(value);
        var linkedList = new MyLinkedList(listNode);
        var getValue = linkedList.Get(firtElementIndex);

        Assert.That(getValue, Is.EqualTo(value));
    }

    [Test]
    public void Get_From_OutOfBound_Linked_List()
    {
        int value = 1;

        var listNode = new ListNode<int>(value);
        var linkedList = new MyLinkedList(listNode);
        var outOfBoundValue = linkedList.Get(10);

        Assert.That(outOfBoundValue, Is.EqualTo(-1));
    }

    [Test]
    public void Adding_At_Head()
    {
        int value = 1;

        var linkedList = new MyLinkedList();
        linkedList.AddAtHead(value);
        var getValue = linkedList.Get(0);

        Assert.That(getValue, Is.EqualTo(value));
    }

    [Test]
    public void Adding_At_Head_2_Values()
    {
        int value = 1;
        int secondValue = 2;

        var linkedList = new MyLinkedList();
        linkedList.AddAtHead(value);
        linkedList.AddAtHead(secondValue);
        var getValue = linkedList.Get(0);

        Assert.That(getValue, Is.EqualTo(secondValue));
    }

    [Test]
    public void Adding_At_Tail()
    {
        int value = 1;

        var linkedList = new MyLinkedList();
        linkedList.AddAtTail(value);
        var getValue = linkedList.Get(0);

        Assert.That(getValue, Is.EqualTo(value));
    }

    [Test]
    public void Adding_At_Tail_2_Values()
    {
        int value = 1;
        int secondValue = 2;

        var linkedList = new MyLinkedList();
        linkedList.AddAtHead(value);
        linkedList.AddAtTail(secondValue);
        var getValue = linkedList.Get(1);

        Assert.That(getValue, Is.EqualTo(secondValue));
    }

    [Test]
    public void Delete_At_Index()
    {
        var linkedList = new MyLinkedList();
        linkedList.AddAtHead(1);
        linkedList.DeleteAtIndex(0);
        var getValue = linkedList.Get(0);

        Assert.That(getValue, Is.EqualTo(-1));
    }

    [Test]
    public void Test_Case()
    {
        var linkedList = new MyLinkedList();
        linkedList.AddAtHead(2);
        linkedList.DeleteAtIndex(1);
        linkedList.AddAtHead(2);
        linkedList.AddAtHead(7);
        linkedList.AddAtHead(3);
        linkedList.AddAtHead(2);
        linkedList.AddAtHead(5);
        linkedList.AddAtTail(5);
        var getValue = linkedList.Get(5);
        Assert.That(getValue, Is.EqualTo(2));
        linkedList.DeleteAtIndex(6);
        linkedList.DeleteAtIndex(4);
        var getAfterDelete = linkedList.Get(3);
        Assert.That(getAfterDelete, Is.EqualTo(7));
    }

    [Test]
    public void Has_Cycle()
    {
        var head = new ListNode<int>(3);
        var node2 = new ListNode<int>(2);
        var node0 = new ListNode<int>(0);
        var node4 = new ListNode<int>(-4);
        head.next = node2;
        node2.next = node0;
        node0.next = node4;
        node4.next = node2;

        var hasCycle = MyLinkedList.HasCycle(head);

        Assert.That(hasCycle, Is.EqualTo(true));
    }

    [Test]
    public void Another_Has_Cycle()
    {
        var head = new ListNode<int>(1);
        var node2 = new ListNode<int>(2);
        head.next = node2;
        node2.next = head;

        var hasCycle = MyLinkedList.HasCycle(head);

        Assert.That(hasCycle, Is.EqualTo(true));
    }

    [Test]
    public void Has_Not_Cycle()
    {
        var head = new ListNode<int>(1);

        var hasCycle = MyLinkedList.HasCycle(head);

        Assert.That(hasCycle, Is.EqualTo(false));
    }

    [Test]
    public void Has_Not_Cycle_Even_Length()
    {
        var head = new ListNode<int>(-21);
        var node10 = new ListNode<int>(10);
        var node17 = new ListNode<int>(17);
        var node5 = new ListNode<int>(5);
        head.next = node10;
        node10.next = node17;
        node17.next = node5;

        var hasCycle = MyLinkedList.HasCycle(head);

        Assert.That(hasCycle, Is.EqualTo(false));
    }

    [Test]
    public void Has_Not_Cycle_Odd_Length()
    {
        var head = new ListNode<int>(-21);
        var node10 = new ListNode<int>(10);
        var node17 = new ListNode<int>(17);
        var node5 = new ListNode<int>(5);
        var node100 = new ListNode<int>(100);
        head.next = node10;
        node10.next = node17;
        node17.next = node5;
        node5.next = node100;

        var hasCycle = MyLinkedList.HasCycle(head);

        Assert.That(hasCycle, Is.EqualTo(false));
    }

    [Test]
    public void Detect_Cycle()
    {
        var head = new ListNode<int>(3);
        var node2 = new ListNode<int>(2);
        var node0 = new ListNode<int>(0);
        var node4 = new ListNode<int>(-4);
        head.next = node2;
        node2.next = node0;
        node0.next = node4;
        node4.next = node2;

        var detectedCycle = MyLinkedList.DetectCycle(head);

        Assert.That(detectedCycle, Is.EqualTo(node2));
    }

    [Test]
    public void Another_Detect_Cycle()
    {
        var head = new ListNode<int>(1);
        var node2 = new ListNode<int>(2);
        head.next = node2;
        node2.next = head;

        var detectedCycle = MyLinkedList.DetectCycle(head);

        Assert.That(detectedCycle, Is.EqualTo(head));
    }

    [Test]
    public void Detect_Not_Cycle()
    {
        var head = new ListNode<int>(1);
        var node2 = new ListNode<int>(2);
        head.next = node2;
        node2.next = null;

        var detectedCycle = MyLinkedList.DetectCycle(head);

        Assert.That(detectedCycle, Is.EqualTo(null));
    }

    [Test]
    public void Intersect_Two_List()
    {
        var head = new ListNode<int>(4);
        var head1 = new ListNode<int>(1);
        var head8 = new ListNode<int>(8);
        var head4 = new ListNode<int>(4);
        var head5 = new ListNode<int>(5);
        head.next = head1;
        head1.next = head8;

        var headB = new ListNode<int>(5);
        var head6B = new ListNode<int>(6);
        var head1B = new ListNode<int>(1);
        headB.next = head6B;
        head6B.next = head1B;
        head1B.next = head8;

        head8.next = head4;
        head4.next = head5;
        head5.next = null;

        var intersectedNode = MyLinkedList.GetIntersectionNode(head, headB);

        Assert.That(intersectedNode, Is.EqualTo(head8));
    }

    [Test]
    public void Remove_Nth_Node_From_End_Null()
    {
        var head = new ListNode<int>(1);

        var removed = MyLinkedList.RemoveNthFromEnd(head, 1);

        Assert.That(removed, Is.EqualTo(null));
    }

    [Test]
    public void Remove_Nth_Node_From_End_1()
    {
        var head = new ListNode<int>(1);
        var head2 = new ListNode<int>(2);
        head.next = head2;

        var removed = MyLinkedList.RemoveNthFromEnd(head, 1);

        head.next = null;

        Assert.That(removed, Is.EqualTo(head));
    }

    [Test]
    public void Remove_Nth_Node_From_End_2()
    {
        var head = new ListNode<int>(1);
        var head2 = new ListNode<int>(2);
        var head3 = new ListNode<int>(3);
        var head4 = new ListNode<int>(4);
        var head5 = new ListNode<int>(5);
        var head6 = new ListNode<int>(6);

        head.next = head2;
        head2.next = head3;
        head3.next = head4;

        var removed = MyLinkedList.RemoveNthFromEnd(head, 2);

        Assert.That(removed, Is.EqualTo(head));
    }

    [Test]
    public void Reverse_List()
    {
        var head = new ListNode<int>(1);
        var head2 = new ListNode<int>(2);
        var head3 = new ListNode<int>(3);
        var head4 = new ListNode<int>(4);
        var head5 = new ListNode<int>(5);

        head.next = head2;
        head2.next = head3;
        head3.next = head4;
        head4.next = head5;

        var reversed = MyLinkedList.ReverseList(head);
    }

    [Test]
    public void Reverse_List_2()
    {
        var head = new ListNode<int>(1);
        var head2 = new ListNode<int>(2);

        head.next = head2;

        var reversed = MyLinkedList.ReverseList(head);
    }

    [Test]
    public void Remove_Elements()
    {
        var head = new ListNode<int>(1);
        var head2 = new ListNode<int>(2);
        var head3 = new ListNode<int>(3);
        var head4 = new ListNode<int>(4);
        var head5 = new ListNode<int>(5);
        var head6 = new ListNode<int>(6);
        var head6_2 = new ListNode<int>(6);
        head.next = head2;
        head2.next = head6;
        head6.next = head3;
        head3.next = head4;
        head4.next = head5;
        head5.next = head6_2;

        var removedElements = MyLinkedList.RemoveElements(head, 6);
    }

    [Test]
    public void Remove_Elements_2()
    {
        var head = new ListNode<int>(7);
        var head2 = new ListNode<int>(7);
        var head3 = new ListNode<int>(7);
        var head4 = new ListNode<int>(7);
        head.next = head2;
        head2.next = head3;
        head3.next = head4;

        var removedElements = MyLinkedList.RemoveElements(head, 7);
    }

    [Test]
    public void Remove_Elements_3()
    {
        var head = new ListNode<int>(1);
        var head2 = new ListNode<int>(2);
        head.next = head2;

        var removedElements = MyLinkedList.RemoveElements(head, 1);
    }

    [Test]
    public void Odd_Even_List()
    {
        var head = new ListNode<int>(1);
        var head2 = new ListNode<int>(2);
        var head3 = new ListNode<int>(3);
        var head4 = new ListNode<int>(4);
        var head5 = new ListNode<int>(5);

        head.next = head2;
        head2.next = head3;
        head3.next = head4;
        head4.next = head5;

        var oddEven = MyLinkedList.OddEvenList(head);
    }

    [Test]
    public void Odd_Even_List_2()
    {
        var head2 = new ListNode<int>(2);
        var head1 = new ListNode<int>(1);
        var head3 = new ListNode<int>(3);
        var head5 = new ListNode<int>(5);
        var head6 = new ListNode<int>(6);
        var head4 = new ListNode<int>(4);
        var head7 = new ListNode<int>(7);

        head2.next = head1;
        head1.next = head3;
        head3.next = head5;
        head5.next = head6;
        head6.next = head4;
        head4.next = head7;

        var oddEven = MyLinkedList.OddEvenList(head2);
    }

    [Test]
    public void Odd_Even_List_3()
    {
        var head1 = new ListNode<int>(1);
        var head2 = new ListNode<int>(2);
        var head3 = new ListNode<int>(3);
        var head4 = new ListNode<int>(4);
        var head5 = new ListNode<int>(5);
        var head6 = new ListNode<int>(6);
        var head7 = new ListNode<int>(7);
        var head8 = new ListNode<int>(8);

        head1.next = head2;
        head2.next = head3;
        head3.next = head4;
        head4.next = head5;
        head5.next = head6;
        head6.next = head7;
        head7.next = head8 ;

        var oddEven = MyLinkedList.OddEvenList(head1);
    }

    [Test]
    public void Is_Palindrome()
    {
        var head = new ListNode<int>(1);
        var head2 = new ListNode<int>(2);
        var head3 = new ListNode<int>(3);
        var head2_2 = new ListNode<int>(2);
        var head1_2 = new ListNode<int>(1);

        head.next = head2;
        head2.next = head3;
        head3.next = head2_2;
        head2_2.next = head1_2;

        var isPalindrome = MyLinkedList.IsPalindrome(head);
    }

    [Test]
    public void Is_Palindrome_2()
    {
        var head = new ListNode<int>(1);
        var head2 = new ListNode<int>(2);
        var head2_2 = new ListNode<int>(2);
        var head1_2 = new ListNode<int>(1);

        head.next = head2;
        head2.next = head2_2;
        head2_2.next = head1_2;

        var isPalindrome = MyLinkedList.IsPalindrome(head);
    }

    [Test]
    public void Is_Palindrome_3()
    {
        var head = new ListNode<int>(1);
        var head2 = new ListNode<int>(2);

        head.next = head2;

        var isPalindrome = MyLinkedList.IsPalindrome(head);
    }

    [Test]
    public void Is_Palindrome_4()
    {
        var head = new ListNode<int>(8);
        var head2 = new ListNode<int>(0);
        var head3 = new ListNode<int>(7);
        var head4 = new ListNode<int>(1);
        var head5 = new ListNode<int>(7);
        var head6 = new ListNode<int>(0);
        var head7 = new ListNode<int>(8);

        head.next = head2;
        head2.next = head3;
        head3.next = head4;
        head4.next = head5;
        head5.next = head6;
        head6.next = head7;

        var isPalindrome = MyLinkedList.IsPalindrome(head);
    }

    [Test]
    public void Merge_Two_Sorted_List_I()
    {
        var head1 = new ListNode<int>(1);
        var head_1 = new ListNode<int>(2);
        var head__1 = new ListNode<int>(4);
        var head2 = new ListNode<int>(1);
        var head_2 = new ListNode<int>(3);
        var head__2 = new ListNode<int>(4);

        head1.next = head_1;
        head_1.next = head__1;
        head2.next = head_2;
        head_2.next = head__2;

        var merged = MyLinkedList.MergeTwoLists(head1, head2);
    }

    [Test]
    public void Merge_Two_Sorted_List_II()
    {
        var head1 = new ListNode<int>(1);
        var head2 = new ListNode<int>(2);

        /*var merged = MyLinkedList.MergeTwoLists(head2, head1);*/
        var merged2 = MyLinkedList.MergeTwoLists(head1, head2);
    }

    [Test]
    public void Rotation_Right()
    {
        var head0 = new ListNode<int>(0);
        var head1 = new ListNode<int>(1);
        var head2 = new ListNode<int>(2);

        head0.next = head1;
        head1.next = head2;

        var rotationRight5 = MyLinkedList.RotateRight(head0, 5);
        var rotationRight6 = MyLinkedList.RotateRight(head0, 300000);
    }
}