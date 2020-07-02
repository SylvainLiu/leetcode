<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public ListNode DeleteDuplicates(ListNode head)
{
	if (head == null || head.next == null) return head;
	
	var res = new ListNode(-1);
	var pre = res;
	pre.next = head;

	while (head != null)
	{
		var delete = false;
		if (head.next != null && head.val == head.next.val)
		{
			delete = true;
			while (head.next != null && head.val == head.next.val)
			{
				head = head.next;
			}
		}

		if (delete)
		{
			head = head.next;
			pre.next = head;
		}
		else
		{
			pre = head;
			head = head.next;
		}
	}
	return res.next;
}

public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int x) { val = x; }
}