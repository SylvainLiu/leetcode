<Query Kind="Program" />

void Main()
{
	var node = new ListNode(1);
	node.next = new ListNode(2);
	node.next.next = new ListNode(3);
	node.next.next.next = new ListNode(4);
	node.next.next.next.next = new ListNode(5);
	
	OddEvenList(node).Dump();
}

// Define other methods and classes here
public ListNode OddEvenList(ListNode head)
{
	if (head == null || head.next == null || head.next.next == null) return head;

	var odd = head;
	var even = head.next;
	var evenHead = even;

	var current = even.next;
	var flag = true;
	while (current != null)
	{
		if (flag) 
		{
			odd.next = current;
			odd = odd.next;
		}
		else
		{
			even.next = current;
			even = even.next;
		}
		
		flag = !flag;
		current = current.next;
	}
	
	odd.next = evenHead;
	even.next = null;
	return head;
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
	{
		this.val = val;
		this.next = next;
	}
}