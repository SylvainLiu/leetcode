<Query Kind="Program" />

void Main()
{
	AddTwoNumbers(new ListNode(1), new ListNode(9) {next = new ListNode(9)}).Dump();
}

public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
	if (l1 == null) return l2;
	if (l2 == null) return l1;

	var addition = 0;
	var current = new ListNode(-1);
	var res = current;
	while (l1 != null || l2 != null)
	{
		var val1 = l1 == null ? 0 : l1.val;
		var val2 = l2 == null ? 0 : l2.val;

		current.next = new ListNode((val1 + val2 + addition) % 10);
		addition = current.val / 10;

		current = current.next;
		l1 = l1 == null ? null : l1.next;
		l2 = l2 == null ? null : l2.next;
	}

	if (addition == 1) { current.next = new ListNode(1); }
	return res.next;
}

//public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
//{
//	if (l1 == null) return l2;
//	if (l2 == null) return l1;
//
//	var addition = false;
//	var current = new ListNode(-1);
//	var res = current;
//	while (l1 != null && l2 != null) 
//	{
//		current.next = new ListNode(-1);
//		current = current.next;
//		
//		current.val = l1.val + l2.val + (addition ? 1 : 0);
//		addition = current.val >= 10;
//		if (addition) current.val -= 10;
//		
//		l1 = l1.next;
//		l2 = l2.next;
//	}
//
//	if (l1 == null && l2 == null & addition)
//	{
//		current.next = new ListNode(1);
//		return res.next;
//	}
//
//	var rest = l1 == null ? l2 : l1;
//	current.next = rest;
//	while (addition && rest != null)
//	{
//		rest.val += 1;
//		addition = rest.val >= 10;
//		if (addition) rest.val -= 10;
//		if (rest.next != null) rest = rest.next;
//		else if (addition) { rest.next = new ListNode(1); break;}
//	}
//
//	return res.next;
//}

//public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
//{
//	if (l1 == null) return l2;
//	if (l2 == null) return l1;
//
//	var head = new ListNode(0);
//	var current = head;
//	var add = 0;
//	while (l1 != null || l2 != null)
//	{
//		var x = l1 == null ? 0 : l1.val;
//		var y = l2 == null ? 0 : l2.val;
//
//		current.next = new ListNode((x + y + add) % 10);
//		add = (x + y + add) / 10;
//		current = current.next;
//
//		l1 = l1 == null ? null : l1.next;
//		l2 = l2 == null ? null : l2.next;
//	}
//
//	if (add == 1)
//	{
//		current.next = new ListNode(1);
//	}
//	
//	return head.next;
//}

public class ListNode
{
	public int val;
	public ListNode next;
     public ListNode(int x) { val = x; }
}