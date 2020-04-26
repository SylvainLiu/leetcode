<Query Kind="Program" />

void Main()
{
	var node = new ListNode(4);
	node.next = new ListNode(3);
	node.next.next = new ListNode(2);
	node.next.next.next = new ListNode(1);
	
	SortList(node).Dump();
}

public ListNode SortList(ListNode head) 
{
	if (head == null || head.next == null) return head;
	
	var fast = head.next;
	var slow = head;
	while (fast != null && fast.next != null) 
	{
		fast = fast.next.next;
		slow = slow.next;
	}
	
	var right = slow.next;
	slow.next = null;
	
	return Merge(SortList(head), SortList(right));
}

public ListNode Merge(ListNode left, ListNode right)
{
	if (left == null) return right;
	if (right == null) return left;

	var head = new ListNode(-1);
	var current = head;
	while (left != null && right != null)
	{		
		if (left.val < right.val)
		{
			current.next = left;
			left = left.next;
		}
		else
		{
			current.next = right;
			right = right.next;
		}		
		current = current.next;
	}
	
	current.next = left == null ? right : left;
	return head.next;
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}