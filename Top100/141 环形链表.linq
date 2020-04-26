<Query Kind="Program" />

void Main()
{
	var head = new ListNode(1);
	head.next = new ListNode(2);
	head.next.next = new ListNode(4);
	
	//DetectCycle(head).Dump();
}

public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int x) { val = x; }
}

public bool HasCycle(ListNode head)
{
	if (head == null) return false;
	
	var fast = head.next;
	var slow = head;

	while (fast != null && fast.next != null && slow != null) 
	{
		slow = slow.next;
		fast = fast.next.next;
		
		if (slow == fast) return true;
	}
	
	return false;
}