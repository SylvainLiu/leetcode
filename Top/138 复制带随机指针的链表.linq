<Query Kind="Program" />

void Main()
{
	
}

public Node CopyRandomList(Node head)
{
	if (head == null) return null;

	var p = head;
	while (p != null)
	{
		var temp = p.next;
		p.next = new Node(p.val);
		p.next.next = temp;
		p = temp;
	}

	p = head;
	while (p != null)
	{
		if (p.random != null) p.next.random = p.random.next;
		p = p.next.next;
	}

	p = head;
	var cloneHead = head.next;
	var cloneP = cloneHead;
	while (cloneP.next != null)
	{
		p.next = p.next.next;
		p = p.next;
		cloneP.next = cloneP.next.next;
		cloneP = cloneP.next;
	}
	p.next = null;
	return cloneHead;
}
// Define other methods and classes here
//public class Solution
//{
//	public Node CopyRandomList(Node head)
//	{
//		if (head == null) return null;
//
//		var hash = new Dictionary<Node, Node>();
//		var cur = head;
//		while (cur != null)
//		{
//			hash.Add(cur, new Node(cur.val));
//			cur = cur.next;
//		}
//
//		cur = head;
//		while (cur != null)
//		{
//			if (cur.next != null) hash[cur].next = hash[cur.next];
//			if (cur.random != null) hash[cur].random = hash[cur.random];
//			cur = cur.next;
//		}
//
//		return hash[head];
//	}
//}

public class Node
{
	public int val;
	public Node next;
	public Node random;

	public Node(int _val)
	{
		val = _val;
		next = null;
		random = null;
	}
}