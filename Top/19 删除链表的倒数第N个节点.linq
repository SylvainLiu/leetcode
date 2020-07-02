<Query Kind="Program" />

void Main()
{
	var head = new ListNode(1);
	head.next = new ListNode(2);
	head.next.next = new ListNode(3);
	head.next.next.next = new ListNode(4);
	head.next.next.next.next = new ListNode(5);

	RemoveNthFromEnd(head, 2).Dump();
}

public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int x) { val = x; }
}

public ListNode RemoveNthFromEnd(ListNode head, int n)
{
	if (n == 0) return head;
	if (head.next == null) return null;

	var dummy = new ListNode(0);
	dummy.next = head;

	var first = dummy;
	var second = dummy;

	while (n >= 0) 
	{
		first = first.next;
		n--;
	}

	while (first != null) 
	{
		first = first.next;
		second = second.next;
	}
	
	second.next = second.next.next;
	return dummy.next;
}

//public ListNode RemoveNthFromEnd(ListNode head, int n)
//{
//	if (n == 0) return head;
//	if (head.next == null) return null;
//
//	var stack = new Stack<ListNode>();
//
//	stack.Push(head);
//	var current = head;
//	while (current.next != null)
//	{
//		stack.Push(current.next);
//		current = current.next;
//	}
//
//	ListNode target = new ListNode(0);
//	while (n > 0)
//	{
//		target = stack.Pop();
//		n--;
//	}
//
//	if (target.next == null)
//	{
//		target = stack.Pop();
//		target.next = null;
//		return head;
//	}
//
//	target.val = target.next.val;
//	target.next = target.next.next;
//	return head;
//}