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
	head.next.next = new ListNode(4);

	var head2 = new ListNode(1);
	head2.next = new ListNode(3);
	head2.next.next = new ListNode(4);

	MergeTwoLists(head, head2).Dump();
}

public ListNode MergeTwoLists(ListNode l1, ListNode l2)
{
	var dummy = new ListNode(0);
	var cur = dummy;

	while (l1 != null && l2 != null)
	{
		if (l1.val < l2.val)
		{
			cur.next = l1;
			cur = cur.next;
			l1 = l1.next;
		}
		else 
		{
			cur.next = l2;
			cur = cur.next;
			l2 = l2.next;
		}
	}

	if (l1 == null) 
	{
		cur.next = l2;
	}
	else 
	{
		cur.next = l1;
	}
	
	return dummy.next;
}