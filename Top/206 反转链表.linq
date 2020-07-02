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
	if (head == null) return null;
	if (head.next == null) return head;

	var pre = head;
	var current = head.next;
	pre.next = null;
	
	while (current.next != null) 
	{
		var temp = current.next;
		current.next = pre;
		pre = current;
		current = temp;
	}
	
	current.next = pre;
	return current;
}

//public ListNode ReverseList(ListNode head)
//{
//	var current = head;
//	var dummy = new ListNode(0);
//	dummy.next = null;
//
//	while (current != null)
//	{
//		var temp = current;
//		current = current.next;
//		temp.next = dummy.next;
//		dummy.next = temp;
//	}
//
//	return dummy.next;
//}