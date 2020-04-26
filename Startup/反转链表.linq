<Query Kind="Program" />

public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int x) { val = x; }
}

void Main()
{
	var head = new ListNode(1);
	head.next = new ListNode(2);
	head.next.next = new ListNode(3);
	head.next.next.next = new ListNode(4);
	head.next.next.next.next = new ListNode(5);

	ReverseList(head).Dump();
}

public ListNode ReverseList(ListNode head)
{
	var current = head;
	var dummy = new ListNode(0);
	dummy.next = null;

	while (current != null)
	{
		var temp = current;
		current = current.next;
		temp.next = dummy.next;
		dummy.next = temp;
	}

	return dummy.next;
}