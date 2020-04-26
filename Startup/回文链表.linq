<Query Kind="Program" />

void Main()
{
	var head = new ListNode(1);
	head.next = new ListNode(2);
	head.next.next = new ListNode(4);
	
	IsPalindrome(head).Dump();
}

public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int x) { val = x; }
}

public bool IsPalindrome(ListNode head)
{
	if (head == null) return true;
	if (head.next == null) return true;
	
	var dummy = new ListNode(0);
	dummy.next = head;
	var stack = new Stack<int>();

	var fast = dummy;
	var slow = dummy;
	while (fast != null && fast.next != null) 
	{
		slow = slow.next;
		stack.Push(slow.val);

		fast = fast.next.next;
	}

	if (fast == null) 
	{
		stack.Pop();
	}
	
	while (stack.Any()) 
	{
		if (stack.Pop() != slow.next.val) 
		{
			return false;
		}
		
		slow = slow.next;
	}
	
	return true;
}