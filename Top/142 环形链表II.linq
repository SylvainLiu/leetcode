<Query Kind="Program" />

void Main()
{
	
}


public ListNode DetectCycle(ListNode head)
{
	if (head == null || head.next == null) return null;
	var slow = head.next;
	var fast = head.next.next;

	while (slow != fast)
	{
		if (fast == null || fast.next == null) return null;
		slow = slow.next;
		fast = fast.next.next;
	}

	fast = head;
	while (slow != fast)
	{
		slow = slow.next;
		fast = fast.next;
	}
	return fast;
}
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
	{
		val = x;
		next = null;
	}
}





















//public ListNode DetectCycle(ListNode head)
//{
//	if (head == null || head.next == null) return null;
//
//	var fast = head.next.next;
//	var slow = head.next;
//
//	while (fast != slow)
//	{
//		if (fast == null || fast.next == null) return null;
//
//		slow = slow.next;
//		fast = fast.next.next;
//	}
//
//	fast = head;
//	while (fast != slow)
//	{
//		slow = slow.next;
//		fast = fast.next;
//	}
//
//	return fast;
//}