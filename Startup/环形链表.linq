<Query Kind="Program" />

void Main()
{
	var head = new ListNode(1);
	head.next = new ListNode(2);
	head.next.next = new ListNode(4);
	
	DetectCycle(head).Dump();
}

public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int x) { val = x; }
}


public ListNode DetectCycle(ListNode head)
{
	if (head == null || head.next == null) return null;

	var fast = head.next.next;
	var slow = head.next;

	while (fast != slow)
	{
		if (fast == null || fast.next == null) return null;

		slow = slow.next;
		fast = fast.next.next;
	}

	fast = head;
	while (fast != slow)
	{
		slow = slow.next;
		fast = fast.next;
	}

	return fast;
}