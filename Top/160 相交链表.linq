<Query Kind="Program" />

void Main()
{
	var node = new ListNode(1);
	node.next = new ListNode(2);
	node.next.next = new ListNode(3);
	node.next.next.next = new ListNode(4);
	
	var nodeA = new ListNode(1);
	nodeA.next = new ListNode(1);
	nodeA.next.next = node;
	
	var nodeB = new ListNode(1);
	nodeB.next = node;
	
	GetIntersectionNode(nodeA, nodeB).Dump();
}

// Define other methods and classes here
public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
{
	if (headA == null || headB == null)	return null;
	
	var curA = headA;
	var curB = headB;
	while (curA != curB)
	{
		curA = curA == null ? headB : curA.next;
		curB = curB == null ? headA : curB.next;
	}
	return curA;
}

//public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
//{
//	if (headA == null || headB == null) return null;
//	var pA = headA;
//	var pB = headB;
//	while (pA != pB)
//	{
//		pA = pA == null ? headB : pA.next;
//		pB = pB == null ? headA : pB.next;
//	}
//	
//	return pA;
//}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}