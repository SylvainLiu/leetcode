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
	if (head == null || head.next == null) return head;
	
	ListNode pre = null;
	var cur = head;

	while (cur != null) 
	{
		var tmp = cur;
		cur = cur.next;
		tmp.next = pre;
		pre = tmp;
	}
	
	return pre;
}
