<Query Kind="Program" />

void Main()
{
	var head = new ListNode(1);
	head.next = new ListNode(2);
	head.next.next = new ListNode(3);
	head.next.next.next = new ListNode(2);
	head.next.next.next.next = new ListNode(1);

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
	if (head == null || head.next == null) return true;

	var slow = head.next;
	var fast = head.next.next;
	while (fast != null && fast.next != null) 
	{
		slow = slow.next;
		fast = fast.next.next;
	}
	
	var mid = slow;
	var second = slow.next;
	mid.next = null;

	second = Reverse(second);
	
	var index1 = head;
	var index2 = second;
	while (index2 != null) 
	{
		if (index1.val != index2.val) return false;
		index1 = index1.next;
		index2 = index2.next;
	}
	
	second = Reverse(second);
	mid.next = second;
	return true;
}

public ListNode Reverse(ListNode node) 
{
	ListNode pre = null;
	var cur = node;
	while (cur != null) 
	{
		var temp = cur.next;
		cur.next = pre;
		pre = cur;
		cur = temp;
	}
	return pre;
}

//public bool IsPalindrome(ListNode head)
//{
//	if (head == null) return true;
//	if (head.next == null) return true;
//
//	var fast = head.next;
//	var slow = head;
//
//	while (fast != null && fast.next != null)
//	{
//		slow = slow.next;
//		fast = fast.next.next;
//	}
//	
//	var head2 = slow.next;
//	slow.next = null;
//		
//	ListNode pre = null;
//	var cur = head2;
//	while (cur != null) 
//	{
//		var temp = cur;
//		cur = cur.next;
//		temp.next = pre;
//		pre = temp;
//	}
//	
//	var tail = pre;
//	var tempHead = head;
//	while (pre != null) 
//	{
//		if (tempHead.val != pre.val) return false;
//		tempHead = tempHead.next;
//		pre = pre.next;
//	}
//	
//	pre = null;
//	cur = tail;
//	while (cur != null) 
//	{
//		var temp = cur;
//		cur = cur.next;
//		temp.next = pre;
//		pre = temp;
//	}
//	
//	slow.next = pre;
//	return true;
//}


//public bool IsPalindrome(ListNode head)
//{
//	if (head == null) return true;
//	if (head.next == null) return true;
//
//	var fast = head.next;
//	var slow = head;
//
//	while (fast != null && fast.next != null) 
//	{
//		slow = slow.next;
//		fast = fast.next.next;
//	}
//	var stack = new Stack<int>();
//	slow = slow.next;
//	while (slow != null) 
//	{
//		stack.Push(slow.val);
//		slow = slow.next;
//	}
//
//	while (stack.Any()) 
//	{
//		if (stack.Pop() != head.val) return false;
//		head = head.next;
//	}
//	
//	return true;
//}

//public bool IsPalindrome(ListNode head)
//{
//	if (head == null) return true;
//	if (head.next == null) return true;
//	
//	var dummy = new ListNode(0);
//	dummy.next = head;
//	var stack = new Stack<int>();
//
//	var fast = dummy;
//	var slow = dummy;
//	while (fast != null && fast.next != null) 
//	{
//		slow = slow.next;
//		stack.Push(slow.val);
//
//		fast = fast.next.next;
//	}
//
//	if (fast == null) 
//	{
//		stack.Pop();
//	}
//	
//	while (stack.Any()) 
//	{
//		if (stack.Pop() != slow.next.val) 
//		{
//			return false;
//		}
//		
//		slow = slow.next;
//	}
//	
//	return true;
//}